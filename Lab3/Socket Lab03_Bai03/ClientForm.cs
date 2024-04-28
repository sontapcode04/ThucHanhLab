using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Windows.Forms.VisualStyles;

namespace Lab3.Socket_Lab03_Bai03
{
    public partial class ClientForm : Form
    {
        private int i = 1;
        private TcpClient client;
        private NetworkStream stream;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 1234); // Connect to localhost, port 1234
                stream = client.GetStream();
                textBoxStatus.Text = "Connected to server";
            }
            catch (Exception ex)
            {
                textBoxStatus.Text = "Error: " + ex.Message;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                Send(textBoxMessage.Text);
                Connect();
            }
            else
            {
                textBoxStatus.Text = "Vui lòng ấn lại nút Connect!";
                i = 1;
            }
        }

        private void Send(string message)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
                textBoxMessage.Clear();
            }
            catch (Exception ex)
            {
                textBoxStatus.Text = "Error: " + ex.Message;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
            i = 0;
        }

        private void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
            textBoxStatus.Text = "Disconnected from server";
        }

        // Trong hàm tải form của ClientForm
        private void ClientForm_Load(object sender, EventArgs e)
        {
            textBoxStatus.Text = "Vui lòng nhấn nút Connect nếu bạn muốn gửi tin!";
            // Gán các sự kiện cho các control trên form (ví dụ: buttonConnect_Click, buttonSend_Click, buttonDisconnect_Click)
            buttonConnect.Click += buttonConnect_Click;
            buttonSend.Click += buttonSend_Click;
            buttonDisconnect.Click += buttonDisconnect_Click;

           
        }

        private void buttonOpenClientForm_Click(object sender, EventArgs e)
        {
            Application.Run(new ClientForm());
        }
    }
}
