using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.Odbc;

namespace Bai01
{
    public partial class FormServer : Form
    {
        UdpClient server;
        IPEndPoint clientEP;

        public FormServer()
        {
            InitializeComponent();
            server = new UdpClient(8080); // Port mà server lắng nghe
            clientEP = new IPEndPoint(IPAddress.Any, 8080);
            CheckForIllegalCrossThreadCalls = false; // Không kiểm tra gọi chéo
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            // Khởi động một luồng mới để lắng nghe dữ liệu từ máy khách
            Thread thread = new Thread(new ThreadStart(ListenForMessages));
            thread.IsBackground = true; // Đặt luồng là luồng nền
            thread.Start(); // Bắt đầu luồng
        }

        private void ListenForMessages()
        {
            try
            {
                while (true)
                {
                    var receiveBytes = new Byte[1024];
                    receiveBytes = server.Receive(ref clientEP);
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    string mess = clientEP.Address.ToString() + ":" + returnData.ToString();
                    InfoMessage(mess);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Lỗi khi lắng nghe dữ liệu từ máy khách: " + ex.Message);
            }
        }
        private void InfoMessage(string message)
        {
            // Kiểm tra xem có cần chạy trên luồng chính hay không
            if (listBox1.InvokeRequired)
            {
                // Nếu không, gọi lại phương thức này trên luồng chính
                listBox1.Invoke(new MethodInvoker(() => InfoMessage(message)));
            }
            else
            {
                // Nếu cần, thêm tin nhắn vào ListBox
                listBox1.Items.Add(message);
                // Cuộn xuống dòng mới nhất
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1; // Hủy chọn để cuộn tự động
            }
        }
    }
}
