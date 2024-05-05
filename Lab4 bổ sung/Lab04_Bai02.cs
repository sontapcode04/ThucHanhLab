using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab4
{
    public partial class Lab04_Bai02 : Form
    {
        public Lab04_Bai02()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text;
            string savePath = savePathTextBox.Text;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(savePath))
            {
                MessageBox.Show("Please enter URL and save path.");
                return;
            }

            WebClient webClient = new WebClient();

            try
            {
                // Download HTML content from the specified URL
                string htmlContent = webClient.DownloadString(url);

                // Save the HTML content to the specified file
                File.WriteAllText(savePath, htmlContent);

                // Display the HTML content on the form
                webBrowser.DocumentText = htmlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Dispose WebClient to release resources
                webClient.Dispose();
            }
        }
    }
}
