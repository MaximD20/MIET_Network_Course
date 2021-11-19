import os
import sys
import socket
import datetime
import time
import threading
from pathlib import Path
from scapy.all import *
from PySide2.QtWidgets import QApplication, QWidget, QTreeWidget, QTreeWidgetItem
from PySide2.QtCore import QFile, QRegExp
from PySide2.QtUiTools import QUiLoader
from PySide2.QtGui import QRegExpValidator, QValidator


class Widget(QWidget):
    # Проверяет корректность ввода ip-адресов для генерации ip пакета
    def CheckIPData(self):
       if((self.ui.SCRData.validator().validate(self.ui.SCRData.text(), 0)[0] == QValidator.State.Acceptable) and
          self.ui.DSTData.validator().validate(self.ui.DSTData.text(), 0)[0] == QValidator.State.Acceptable):
              self.ui.GenerateButton.setEnabled(True)
       else:
           self.ui.GenerateButton.setEnabled(False)
    # Устанавливает обработчики событий кнопок
    def SetEventButtons(self):
        self.ui.StartButton.clicked.connect(
                               lambda: self.StartButtonClicked())
        self.ui.StopButton.clicked.connect(
                               lambda: self.StopButtonClicked())
        self.ui.ClearButton.clicked.connect(
                               lambda: self.ClearButtonClicked())
        self.ui.GenerateButton.clicked.connect(
                               lambda: self.GenerateButtonClicked())
        self.ui.SCRData.textChanged.connect(
                               lambda: self.CheckIPData())
        self.ui.DSTData.textChanged.connect(
                               lambda: self.CheckIPData())
    # Инициализация виджета
    def __init__(self):
        super(Widget, self).__init__()
        self.load_ui()

    # Запускает сниффер с отлавливанием пакетов локального ip пользователя
    def _sniff(self, e):
        sniff(prn=self.network_monitoring_for_visualization_version, filter="host "+self.ui.LIP.text(),stop_filter=lambda p: e.is_set())
    # Настройки UI (Валидаторы, события, состояния объектов)
    def load_ui(self):
        self.setFixedWidth(620)
        self.setFixedHeight(600)

        loader = QUiLoader()
        path = os.fspath(Path(__file__).resolve().parent / "form.ui")
        ui_file = QFile(path)
        ui_file.open(QFile.ReadOnly)
        self.ui = loader.load(ui_file, self)
        ui_file.close()

        self.ui.StartButton.setEnabled(True)
        self.ui.StopButton.setEnabled(False)

        tree = self.ui.sniffs
        tree.setColumnCount(2)
        tree.setHeaderLabels(["Field Name", "Value"])
        tree.setColumnWidth(1,66)

        self.ui.ClearButton.setEnabled(False)
        self.ui.GenerateButton.setEnabled(False)

        self.ui.LIP.setText(socket.gethostbyname(socket.gethostname()))

        ipRegex = QRegExp("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.)"
                                  "{3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")
        ipValidator = QRegExpValidator(ipRegex)
        self.ui.SCRData.setValidator(ipValidator)
        self.ui.DSTData.setValidator(ipValidator)

    # Генерирует и отправляет IP пакет
    def GenerateButtonClicked(self):
        packet = IP(src = self.ui.SCRData.text(), dst = self.ui.DSTData.text())
        send(packet)

    # Запускает работу сниффера в отдельном потоке
    def StartButtonClicked(self):
        # Получаем выбранные для перехвата типы пакетов
        self.x = {}
        self.x['TCP'] = self.ui.TCP.isChecked()
        self.x['UDP'] = self.ui.UDP.isChecked()
        self.x['IP'] = self.ui.IP.isChecked()
        self.x['ICMP'] = self.ui.ICMP.isChecked()
        isOneCheck = False

        # Проверяем, что выбран хотя бы один тип пакета
        for key in self.x:
            if self.x[key]:
                isOneCheck = True
                break

        # Вызов метода запуска сниффера, изменение состояний элементов
        if isOneCheck:
            self.ui.StartButton.setEnabled(False)
            self.ui.StopButton.setEnabled(True)
            self.ui.ClearButton.setEnabled(False)
            self.ui.TCP.setEnabled(False)
            self.ui.UDP.setEnabled(False)
            self.ui.IP.setEnabled(False)
            self.ui.ICMP.setEnabled(False)
            self.e = threading.Event()
            t = threading.Thread(target=self._sniff, args=(self.e,))
            t.start()

    # Очищает дерево пакетов
    def ClearButtonClicked(self):
        self.ui.sniffs.clear()
        self.ui.ClearButton.setEnabled(False)

    # Останавливает сниффер
    def StopButtonClicked(self):
        self.e.set()
        self.ui.StartButton.setEnabled(True)
        self.ui.StopButton.setEnabled(False)
        self.ui.ClearButton.setEnabled(True)
        self.ui.TCP.setEnabled(True)
        self.ui.UDP.setEnabled(True)
        self.ui.IP.setEnabled(True)
        self.ui.ICMP.setEnabled(True)

    # Обрабатывает получаемый пакет
    def network_monitoring_for_visualization_version(self,pkt):
            time=datetime.now()

            #Если в полученном пакете есть IP пакет, выводим его данные
            if pkt.haslayer(IP):
                if self.x["IP"]:
                    item = QTreeWidgetItem(["IP"])

                    child = QTreeWidgetItem(["Version", str(pkt[IP].version)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Tos", str(pkt[IP].tos)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Tlen", str(pkt[IP].len)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Id", str(pkt[IP].id)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Flags", str(pkt[IP].flags)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["TTL", str(pkt[IP].ttl)])
                    item.addChild(child)

                    try:
                        proto_field = pkt[IP].get_field('proto')
                        child = QTreeWidgetItem(["Proto", (proto_field.i2s[pkt[IP].proto]).upper()])
                        item.addChild(child)
                    except:
                        pass

                    child = QTreeWidgetItem(["CRC", str(pkt[IP].chksum)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Src", str(pkt[IP].src)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Dst", str(pkt[IP].dst)])
                    item.addChild(child)

                    self.ui.sniffs.insertTopLevelItem(0, item)

            # Если содержит TCP пакет
            if pkt.haslayer(TCP):
                if self.x["TCP"]:
                    item = QTreeWidgetItem(["TCP"])

                    child = QTreeWidgetItem(["Src",str(pkt[IP].src) + ":" + str(pkt[TCP].sport)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Dst", str(pkt[IP].dst) + ":" + str(pkt[TCP].dport)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Seq", str(pkt[TCP].seq)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Ackn", str(pkt[TCP].ack)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Offeset", str(pkt[TCP].dataofs)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Flags", str(pkt[TCP].flags)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Window", str(pkt[TCP].window)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["CRC", str(pkt[TCP].chksum)])
                    item.addChild(child)

                    data = " "

                    try:
                        data = str(pkt.getlayer(Raw).load, "utf-8")
                        if (len(data) < 2):
                            data = " "
                        else:
                            print(data)
                        child = QTreeWidgetItem(["Data", data])
                    except Exception:
                        pass

                    item.addChild(child)

                    self.ui.sniffs.insertTopLevelItem(0, item)

            #Если содержит UDP пакет
            if pkt.haslayer(UDP):
                if self.x["UDP"]:
                    item = QTreeWidgetItem(["UDP"])
                    child = QTreeWidgetItem(["Src",str(pkt[IP].src) + ":" + str(pkt[UDP].sport)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Dst", str(pkt[IP].dst) + ":" + str(pkt[UDP].dport)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Tlen", str(pkt[UDP].len)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["CRC", str(pkt[UDP].chksum)])
                    item.addChild(child)

                    data = " "
                    try:
                        data = str(pkt.getlayer(Raw).load, "utf-8")
                        if (len(data) < 2):
                            data = " "
                        else:
                            print(data)
                        child = QTreeWidgetItem(["Data", data])
                    except Exception:
                        pass
                    item.addChild(child)

                    self.ui.sniffs.insertTopLevelItem(0, item)
            # Если содержит ICMP пакет
            if pkt.haslayer(ICMP):
                if self.x["ICMP"]:
                    item = QTreeWidgetItem(["ICMP"])

                    child = QTreeWidgetItem(["Type", str(pkt[ICMP].type)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["Code", str(pkt[ICMP].code)])
                    item.addChild(child)

                    child = QTreeWidgetItem(["CRC", str(pkt[ICMP].chksum)])
                    item.addChild(child)

                    self.ui.sniffs.insertTopLevelItem(0, item)

if __name__ == "__main__":
    app = QApplication([])
    widget = Widget()
    widget.setWindowTitle("Sniffer & Generator IP packets")
    widget.show()
    widget.SetEventButtons()
    sys.exit(app.exec_())
