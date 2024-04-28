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

namespace Bai01
{
    public partial class FormClient : Form
    {
        UdpClient client;
        IPEndPoint serverEP;
        public FormClient()
        {
            InitializeComponent();
            client = new UdpClient();
            serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = MessageTextBox.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                client.Send(data, data.Length, serverEP);
                MessageBox.Show("Đã gửi tin nhắn thành công!");
                MessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi tin nhắn: " + ex.Message);
            }
        }
    }
}
