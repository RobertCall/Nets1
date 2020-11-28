using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Windows.Threading;
using System.IO;
using PacketDotNet;
using SharpPcap;

namespace Network_lab2
{
    public partial class Form1 : Form
    {
        Dispatcher disp;
        ICaptureDevice captureDevice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            disp = Dispatcher.CurrentDispatcher;
            Thread serverThread = new Thread(new ThreadStart(start));
            serverThread.Start();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            captureDevice.StopCapture();
            captureDevice.Close();
            captureDevice = null;
        }

        void start()
        {
            if(captureDevice != null)
            {
                MessageBox.Show("Sniffer already started");
                return;
            }
            try
            {
                CaptureDeviceList deviceList = CaptureDeviceList.Instance;
                captureDevice = deviceList[4];
                captureDevice.OnPacketArrival += new PacketArrivalEventHandler(Program_OnPacketArrival);
                // открываем в режиме promiscuous, поддерживается также нормальный режим
                captureDevice.Open(DeviceMode.Promiscuous, 1000);
                // начинаем захват пакетов
                captureDevice.Capture();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        }
        void Program_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            // парсинг всего пакета
            Packet packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            // получение только TCP и UDP пакетов из всего фрейма
            UdpPacket udpPacket = udp_checkBox.Checked ? (UdpPacket)packet.Extract<UdpPacket>() : null;
            TcpPacket tcpPacket = tcp_checkBox.Checked ? (TcpPacket)packet.Extract<TcpPacket>() : null;
            IcmpV4Packet icmpPacket = icmp_checkBox.Checked ? (IcmpV4Packet)packet.Extract<IcmpV4Packet>() : null;
            IPv4Packet IPPacket = ip_checkBox.Checked ? (IPv4Packet)packet.Extract<IPv4Packet>() : null;
            // получение только IP пакета из всего фрейма
            IPPacket ipPacket = (IPPacket)packet.Extract<IPPacket>();
            if ((tcpPacket != null || udpPacket != null ) && ipPacket != null)
            {
                ListViewItem lvi = new ListViewItem();
                DateTime time = e.Packet.Timeval.Date;
                lvi.Text = time.ToString();
                int len = e.Packet.Data.Length;

                // IP адрес отправителя
                var srcIp = ipPacket.SourceAddress.ToString();
                lvi.SubItems.Add(srcIp);
                // IP адрес получателя
                var dstIp = ipPacket.DestinationAddress.ToString();
                lvi.SubItems.Add(dstIp);

                if(udpPacket != null)
                {
                    // порт отправителя
                    var srcPort = udpPacket.SourcePort.ToString();
                    lvi.SubItems.Add(srcPort);
                    // порт получателя
                    var dstPort = udpPacket.DestinationPort.ToString();
                    lvi.SubItems.Add(dstPort);
                    lvi.SubItems.Add("UDP");
                    // данные пакета
                    var data = udpPacket.PayloadData;
                    lvi.SubItems.Add(Encoding.ASCII.GetString(data));
                }
                if(tcpPacket != null)
                {
                    // порт отправителя
                    var srcPort = tcpPacket.SourcePort.ToString();
                    lvi.SubItems.Add(srcPort);
                    // порт получателя
                    var dstPort = tcpPacket.DestinationPort.ToString();
                    lvi.SubItems.Add(dstPort);
                    lvi.SubItems.Add("TCP");
                    // данные пакета
                    var data = tcpPacket.PayloadData;
                    lvi.SubItems.Add(Encoding.ASCII.GetString(data));
                }
                disp.BeginInvoke(new Action<ListViewItem>((item) => packets_list.Items.Add(item)), lvi);
            }
        }

        private void packets_list_ItemActivate(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in ((ListView)sender).Items)
                if(lvi.Selected)
                    MessageBox.Show("Time: " + lvi.SubItems[0].Text + 
                                    "\nType: " + lvi.SubItems[5].Text +
                                    "\nSource: " + lvi.SubItems[1].Text + ":" + lvi.SubItems[3].Text + 
                                    "\nDestination: " + lvi.SubItems[2].Text + ":" + lvi.SubItems[4].Text + 
                                    "\nData: " + lvi.SubItems[6].Text);
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            Thread sendThread = new Thread(new ThreadStart(send_packet));
            sendThread.Start();
        }

        void send_packet()
        {       
            var tcpPacket = new TcpPacket(UInt16.Parse(SRC_port_textBox.Text), UInt16.Parse(DST_port_textBox.Text));

            var ipSourceAddress = IPAddress.Parse(SRC_IP_textBox.Text); // "127.0.0.1"
            var ipDestinationAddress = IPAddress.Parse(DST_IP_textBox.Text); //"127.0.0.1"
            var ipPacket = new IPv4Packet(ipSourceAddress, ipDestinationAddress);
            tcpPacket.PayloadData = Encoding.Default.GetBytes(Data_textBox.Text); // "I like dogs"

            var sourceHwAddress = "90-90-90-90-90-90";
            var ethernetSourceHwAddress = System.Net.NetworkInformation.PhysicalAddress.Parse(sourceHwAddress);
            var destinationHwAddress = "80-80-80-80-80-80";
            var ethernetDestinationHwAddress = System.Net.NetworkInformation.PhysicalAddress.Parse(destinationHwAddress);
            EthernetPacket ethernetPacket = new EthernetPacket(ethernetSourceHwAddress,
                ethernetDestinationHwAddress,
                EthernetType.None);

            ipPacket.PayloadPacket = tcpPacket;
            ethernetPacket.PayloadPacket = ipPacket;
            captureDevice.SendPacket(ethernetPacket);
        }
    }
}
