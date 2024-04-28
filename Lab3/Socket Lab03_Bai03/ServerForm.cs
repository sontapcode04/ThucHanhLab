using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Lab3.Socket_Lab03_Bai03
{
    public partial class ServerForm : Form
    {
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        private Thread listenThread;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 1234);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();


        }

        private void ListenForClients()
        {
            listener.Start();

            while (true)
            {
                client = listener.AcceptTcpClient();
                stream = client.GetStream();

                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                DisplayMessage(message);

                stream.Close();
                client.Close();
            }
        }

        private void DisplayMessage(string message)
        {
            if (textBoxReceived.InvokeRequired)
            {
                textBoxReceived.Invoke(new Action<string>(DisplayMessage), new object[] { message });
            }
            else
            {
                textBoxReceived.AppendText(message + Environment.NewLine);
            }
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listener != null)
                listener.Stop();
        }


    }
}
