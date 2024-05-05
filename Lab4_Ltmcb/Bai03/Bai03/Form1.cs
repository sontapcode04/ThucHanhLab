using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace Bai03
{
    public partial class Form1 : Form
    {
        WebBrowser wb = new WebBrowser();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            wb.Width = 900;
            wb.Height = 400;
            webBrowser1.Controls.Add(wb);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string link = txtLink.Text;
            wb.Navigate(link);
        }

        private void btnDownFile_Click(object sender, EventArgs e)
        {
            string url = txtLink.Text;

            // Kiểm tra tính hợp lệ của URL
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri validatedUri))
            {
                MessageBox.Show("URL không hợp lệ!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WebClient mywebClient = new WebClient();
                try
                {
                    // Mở stream để đọc nội dung từ URL
                    using (Stream response = mywebClient.OpenRead(validatedUri))
                    {
                        // Tải xuống và lưu nội dung vào tệp đã chỉ định
                        mywebClient.DownloadFile(validatedUri, sfd.FileName);
                        MessageBox.Show("Tải xuống hoàn tất!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải xuống: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo rằng WebClient được giải phóng
                    mywebClient.Dispose();
                }
            }
        }

        private void btnDownRecource_Click(object sender, EventArgs e)
        {
            string url = txtLink.Text;

            // Kiểm tra tính hợp lệ của URL
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri validatedUri))
            {
                MessageBox.Show("URL không hợp lệ!");
                return;
            }

            WebClient mywebClient = new WebClient();
            try
            {
                // Tải trang web vào một chuỗi HTML
                string htmlContent = mywebClient.DownloadString(validatedUri);

                // Sử dụng HTML Agility Pack để phân tích HTML
                HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(htmlContent);

                // Lặp qua các thẻ <img> trong HTML để tìm hình ảnh và tải xuống chúng
                foreach (HtmlNode imgNode in htmlDocument.DocumentNode.SelectNodes("//img"))
                {
                    string imageUrl = imgNode.GetAttributeValue("src", "");
                    Uri imageUri = new Uri(validatedUri, imageUrl);
                    string imageName = Path.GetFileName(imageUri.LocalPath);
                    string savePath = Path.Combine(Environment.CurrentDirectory, imageName);

                    // Tải xuống hình ảnh và lưu vào thư mục hiện tại
                    mywebClient.DownloadFile(imageUri, savePath);
                    Console.WriteLine($"Đã tải xuống {imageName}");
                }

                MessageBox.Show("Tải xuống tài nguyên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải xuống tài nguyên: " + ex.Message);
            }
            finally
            {
                // Đảm bảo rằng WebClient được giải phóng
                mywebClient.Dispose();
            }
        }
    }
}

