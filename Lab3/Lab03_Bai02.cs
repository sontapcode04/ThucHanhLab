using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab03_Bai02 : Form
    {
        private TcpListener tcpListener;
        private Thread listenThread;

        public Lab03_Bai02()
        {
            InitializeComponent();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            // Start listening for connections
            IPAddress ipAddress = GetLocalIPv4(); // Lấy địa chỉ IPv4 của máy
            int port = 8080; // Cổng telnet

            tcpListener = new TcpListener(ipAddress, port);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();

            MessageBox.Show("Listening for Telnet connections on port 8080...");
        }

        private IPAddress GetLocalIPv4()
        {
            // Lấy tất cả các địa chỉ IP của máy tính hiện tại
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

            // Lặp qua các địa chỉ IP và trả về địa chỉ IPv4 đầu tiên tìm thấy
            foreach (IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    return addr;
                }
            }

            // Trong trường hợp không tìm thấy địa chỉ IPv4 nào, trả về địa chỉ loopback 127.0.0.1
            return IPAddress.Parse("127.0.0.1");
        }

            private void ListenForClients()
        {
            tcpListener.Start();

            while (true)
            {
                // Blocks until a client has connected to the server
                TcpClient client = tcpListener.AcceptTcpClient();

                // Create a thread to handle communication with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    // Blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    // A socket error has occurred
                    break;
                }

                if (bytesRead == 0)
                {
                    // The client has disconnected from the server
                    break;
                }

                // Message decoding
                string incomingMessage = Encoding.ASCII.GetString(message, 0, bytesRead);

                // Update UI with received message
                Invoke(new Action(() => textBoxReceived.AppendText(incomingMessage)));
            }

            tcpClient.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listenThread != null && listenThread.IsAlive)
            {
                // Stop listening thread when the form is closing
                listenThread.Abort();
            }

            tcpListener.Stop();
        }
    }
}
