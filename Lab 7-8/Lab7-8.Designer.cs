
namespace Lab_7_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Messages = new System.Windows.Forms.TreeView();
            this.DateEndReceive = new System.Windows.Forms.DateTimePicker();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendMessage = new System.Windows.Forms.Button();
            this.ReceiveMessagesButton = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextRecieveMessage = new System.Windows.Forms.TextBox();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubjectMessage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NameT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(399, 105);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(434, 312);
            this.Messages.TabIndex = 0;
            // 
            // DateEndReceive
            // 
            this.DateEndReceive.Location = new System.Drawing.Point(633, 53);
            this.DateEndReceive.MaxDate = new System.DateTime(2021, 12, 16, 0, 0, 0, 0);
            this.DateEndReceive.Name = "DateEndReceive";
            this.DateEndReceive.Size = new System.Drawing.Size(200, 20);
            this.DateEndReceive.TabIndex = 1;
            this.DateEndReceive.Value = new System.DateTime(2021, 12, 16, 0, 0, 0, 0);
            this.DateEndReceive.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(22, 133);
            this.TextMessage.MaximumSize = new System.Drawing.Size(364, 283);
            this.TextMessage.MinimumSize = new System.Drawing.Size(4, 4);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(364, 255);
            this.TextMessage.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(167, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 25);
            this.label.TabIndex = 3;
            this.label.Text = "SMTP Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(560, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "POP3 Client";
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(64, 53);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(322, 20);
            this.To.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кому:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(169, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текст письма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(892, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Авторизация";
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(22, 394);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(364, 23);
            this.SendMessage.TabIndex = 8;
            this.SendMessage.Text = "Отправить письмо";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // ReceiveMessagesButton
            // 
            this.ReceiveMessagesButton.Location = new System.Drawing.Point(399, 76);
            this.ReceiveMessagesButton.Name = "ReceiveMessagesButton";
            this.ReceiveMessagesButton.Size = new System.Drawing.Size(434, 23);
            this.ReceiveMessagesButton.TabIndex = 9;
            this.ReceiveMessagesButton.Text = "Показать входящие";
            this.ReceiveMessagesButton.UseVisualStyleBackColor = true;
            this.ReceiveMessagesButton.Click += new System.EventHandler(this.ReceiveMessagesButton_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(914, 81);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(136, 20);
            this.Login.TabIndex = 10;
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(857, 133);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(193, 23);
            this.AuthButton.TabIndex = 11;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(864, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Логин:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(854, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Пароль:";
            // 
            // TextRecieveMessage
            // 
            this.TextRecieveMessage.Location = new System.Drawing.Point(839, 177);
            this.TextRecieveMessage.MaximumSize = new System.Drawing.Size(364, 255);
            this.TextRecieveMessage.MinimumSize = new System.Drawing.Size(4, 240);
            this.TextRecieveMessage.Multiline = true;
            this.TextRecieveMessage.Name = "TextRecieveMessage";
            this.TextRecieveMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextRecieveMessage.Size = new System.Drawing.Size(246, 240);
            this.TextRecieveMessage.TabIndex = 15;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessage.Location = new System.Drawing.Point(911, 159);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(86, 15);
            this.LabelMessage.TabIndex = 16;
            this.LabelMessage.Text = "Текст письма";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(19, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Тема:";
            // 
            // SubjectMessage
            // 
            this.SubjectMessage.Location = new System.Drawing.Point(64, 91);
            this.SubjectMessage.Name = "SubjectMessage";
            this.SubjectMessage.Size = new System.Drawing.Size(322, 20);
            this.SubjectMessage.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(396, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Показать письма, присланные после:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(914, 107);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(136, 20);
            this.Password.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(864, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Имя:";
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(914, 56);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(136, 20);
            this.NameT.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 424);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SubjectMessage);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.TextRecieveMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.ReceiveMessagesButton);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.To);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.DateEndReceive);
            this.Controls.Add(this.Messages);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Mail Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Messages;
        private System.Windows.Forms.DateTimePicker DateEndReceive;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Button ReceiveMessagesButton;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextRecieveMessage;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubjectMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameT;
    }
}

