using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Lab6 : Form
    {
        public Lab6()
        {
            InitializeComponent();
            ErrorBox.Visible = false;
            SuccessBox.Visible = false;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            ErrorBox.Visible = false;
            SuccessBox.Visible = false;
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FileAdress.Text);

                request.Method = WebRequestMethods.Ftp.DownloadFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();

                FileStream fs = new FileStream(PathSave.Text, FileMode.Create);

                byte[] buffer = new byte[64];
                int size = 0;

                while ((size = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fs.Write(buffer, 0, size);

                }
                fs.Close();
                response.Close();

                SuccessBox.Text = "File successfuly download and saved!";
                SuccessBox.Visible = true;
            }
            catch (Exception ex)
            {
                ErrorBox.Text = ex.Message;
                ErrorBox.Visible = true;
            }
        }
    }
}
