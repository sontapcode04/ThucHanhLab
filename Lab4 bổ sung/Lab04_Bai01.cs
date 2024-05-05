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

namespace Lab4
{
    public partial class Lab04_Bai01 : Form
    {
        public Lab04_Bai01()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();

            // Kiểm tra xem URL có hợp lệ không
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uri) || !uri.Scheme.StartsWith("http"))
            {
                MessageBox.Show("URL không hợp lệ.");
                return;
            }

            try
            {
                // Tạo WebRequest
                WebRequest request = WebRequest.Create(url);

                // Nhận WebResponse
                using (WebResponse response = request.GetResponse())
                {
                    // Đọc dữ liệu từ WebResponse
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);

                        // Đọc nội dung HTML
                        string htmlContent = reader.ReadToEnd();

                        // Hiển thị nội dung HTML trong TextBox
                        txtHTMLContent.Text = htmlContent;
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}");
            }
        }
    }
}
