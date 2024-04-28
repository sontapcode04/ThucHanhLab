using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UDPClient_Click(object sender, EventArgs e)
        {
            FormClient frmClient = new FormClient();
            frmClient.Show();
        }

        private void UDPServer_Click(object sender, EventArgs e)
        {
            FormServer frmServer = new FormServer();
            frmServer.Show();
        }
    }
}
