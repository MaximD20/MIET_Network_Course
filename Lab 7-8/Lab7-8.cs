using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab_7_8
{
    public partial class Form1 : Form
    {
        #region Fields

        public Dictionary<string, string> dictText = new Dictionary<string, string>();
        public string Username { get; set; }

        #endregion

        #region .ctor

        public Form1()
        {
            InitializeComponent();
            DateEndReceive.MaxDate = DateTime.Now;
            DateEndReceive.Value = DateTime.Now.AddDays(-15);
            SendMessage.Enabled = false;
            TextMessage.Enabled = false;
            ReceiveMessagesButton.Enabled = false;
            DateEndReceive.Enabled = false;
            To.Enabled = false;
            SubjectMessage.Enabled = false;
            Messages.Enabled = false;
            LabelMessage.Visible = false;
            TextRecieveMessage.Visible = false;
            Password.PasswordChar = '*';
        }

        #endregion

        #region Private methods

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LabelMessage.Visible = false;
            TextRecieveMessage.Visible = false;
        }

        /// <summary>
        /// Событие авторизации на почтовом сервере
        /// </summary>
        private void AuthButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(NameT.Text))
                {
                    throw new Exception("Имя, логин и пароль не могут быть пустыми!");
                }

                using (var client = new Pop3Client())
                {
                    client.Connect($"pop.mail.ru", 995, true);

                    client.Authenticate(Login.Text, Password.Text);
                    if (client.IsAuthenticated)
                    {
                        SendMessage.Enabled = true;
                        TextMessage.Enabled = true;
                        ReceiveMessagesButton.Enabled = true;
                        DateEndReceive.Enabled = true;
                        To.Enabled = true;
                        SubjectMessage.Enabled = true;
                        Messages.Enabled = false;
                        Login.Enabled = false;
                        Password.Enabled = false;
                        AuthButton.Enabled = false;
                        NameT.Enabled = false;
                    }
                    Username = NameT.Text;

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Отправка письма
        /// </summary>
        private void SendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(To.Text) || string.IsNullOrEmpty(SubjectMessage.Text) || string.IsNullOrEmpty(TextMessage.Text))
                {
                    throw new Exception("Поле получатель, тема письма и текст письма не могут быть пустыми!");
                }

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(Username, Login.Text));
                message.To.Add(new MailboxAddress(To.Text, To.Text));
                message.Subject = SubjectMessage.Text;

                message.Body = new TextPart("plain")
                {
                    Text = TextMessage.Text
                };

                using (var client = new SmtpClient())
                {
                    client.Connect($"smtp.mail.ru", 465, true);

                    client.Authenticate(Login.Text, Password.Text);

                    client.Send(message);
                    client.Disconnect(true);
                }
                MessageBox.Show("Message succesfuly send!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubjectMessage.Text = "";
                To.Text = "";
                TextMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LabelMessage.Visible = false;
            TextRecieveMessage.Visible = false;
        }

        /// <summary>
        /// Получение писем
        /// </summary>
        private void ReceiveMessagesButton_Click(object sender, EventArgs e)
        {
            Messages.Nodes.Clear();
            dictText.Clear();
            LabelMessage.Visible = false;
            TextRecieveMessage.Visible = false;
            try
            {
                if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Password.Text))
                {
                    throw new Exception("Логин и пароль не могут быть пустыми!");
                }

                using (var client = new Pop3Client())
                {
                    //8uGqAQ9UPt90XrHD8WGb
                    client.Connect($"pop.mail.ru", 995, true);

                    client.Authenticate(Login.Text, Password.Text);
                    var countMessages = client.GetMessageCount();

                    for(int i = countMessages - 1; i>=0; i--)
                    {
                        var message = client.GetMessage(i);
                        if (message.Date.DateTime < DateEndReceive.Value)
                        {
                            break;
                        }
                        var node = new TreeNode($"Письмо от {message.From.First()} - ID: {i}");
                        
                        dictText[$"Письмо от {message.From.First()} - ID: {i}"] = message.BodyParts.OfType<TextPart>().FirstOrDefault().Text;
                        TreeNode childNode;

                        childNode = new TreeNode("Дата письма");
                        childNode.Nodes.Add(new TreeNode(message.Date.DateTime.ToString()));
                        node.Nodes.Add(childNode);

                        childNode = new TreeNode("Тема письма");
                        childNode.Nodes.Add(new TreeNode(message.Subject));
                        node.Nodes.Add(childNode);

                        Messages.Nodes.Add(node);
                    }
                    Messages.Enabled = true;
                    Messages.NodeMouseClick += Messages_MouseClick;
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Messages_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                TextRecieveMessage.Text = dictText[e.Node.Text];
                LabelMessage.Visible = true;
                TextRecieveMessage.Visible = true;
                TextRecieveMessage.ReadOnly = true;
                if (!e.Node.IsExpanded)
                {
                    LabelMessage.Visible = false;
                    TextRecieveMessage.Visible = false;
                }
            }
        }

        #endregion

    }
}
