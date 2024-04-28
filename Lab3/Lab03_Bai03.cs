using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Socket_Lab03_Bai03;

namespace Lab3
{
    public partial class Lab03_Bai03 : Form
    {
        public Lab03_Bai03()
        {
            InitializeComponent();
        }

        private void buttonOpenServer_Click(object sender, EventArgs e)
        {
            OpenServerForm();
        }

        private void buttonOpenClient_Click(object sender, EventArgs e)
        {
            OpenClientForm();
        }

        private void OpenServerForm()
        {
            ServerForm serverForm = new ServerForm();
            serverForm.Show();
        }

        private void OpenClientForm()
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }
    }
}
