using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Threading;
using System.IO;

namespace Network_lab1
{
    public partial class Form1 : Form
    {
        Server server1;
        public Form1()
        {
            InitializeComponent();
        }

        //#################################################################################
        //####################################   Lab1    ##################################
        //#################################################################################
        private void Server_Button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = folderBrowserDialog1.SelectedPath;
            try
            {
                int port = Int32.Parse(Server_Port_textBox.Text);
                server1 = new Server(port, Dispatcher.CurrentDispatcher, this, path);// @"c:\Users\rober\OneDrive\Рабочий стол\Институт\Nets\server");
                Thread serverThread = new Thread(new ThreadStart(server1.Start));
                serverThread.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to parse port");
            }
        }
        private void Stop_Button_Click(object sender, EventArgs e)
        {
            if (server1 != null)
            {
                server1.work = false;
                Server_Status_Label.Text = "Shutdown server ....";
            }
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            try
            {
                int port = Int32.Parse(Port_textBox.Text);
                Client client1 = new Client(IP_textBox.Text, port, filename, Dispatcher.CurrentDispatcher, this);// @"c:\Users\rober\OneDrive\Рабочий стол\Институт\Nets\client\image.jpg");
                Thread clientThread = new Thread(new ThreadStart(client1.connect));
                clientThread.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to parse port");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (server1 != null) server1.work = false;
        }
    }
}
