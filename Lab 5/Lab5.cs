using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            ErrorBox.Visible = false;
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(UrlBox.Text);
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    HTMLBox.Text = responseBody;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString() + ": " + response.ReasonPhrase);
                } 
            }
            catch (Exception ex)
            {
                ErrorBox.Text = ex.Message;
                ErrorBox.Visible = true;
            }
        }
    }
}
