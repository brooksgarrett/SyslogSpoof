using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SyslogSpoof
{
    public partial class fmMaster : Form
    {
        public fmMaster()
        {
            InitializeComponent();
        }

        private void fmMaster_Load(object sender, EventArgs e)
        {
            cbDestination.SelectedItem = cbDestination.Items[0];
            bnReset.PerformClick();
        }

        private void bnReset_Click(object sender, EventArgs e)
        {
            cbDestination.SelectedItem = cbDestination.Items[0];
            tbSRC.Text = String.Empty;
            tbSRC.Text = Dns.GetHostByName(Dns.GetHostName()).AddressList.GetValue(0).ToString();
            tbMsg.Text = String.Empty;
        }

        private void bnSend_Click(object sender, EventArgs e)
        {
            // Build and send the Syslog message
            IPEndPoint txpt = new IPEndPoint(IPAddress.Parse(tbSRC.Text), 0);
            IPEndPoint rcvpt = new IPEndPoint(IPAddress.Parse((string)cbDestination.SelectedItem), 514);
            UdpClient client = new UdpClient(txpt);
            byte[] datagram = buildBytes(tbMsg.Text);

            try
            {
                client.Connect(rcvpt);
                int intStatus = client.Send(datagram, datagram.Length);
                string stStatus;

                if (intStatus == datagram.Length)
                {
                    stStatus = "Message Sent";
                }
                else stStatus = "Error";

                MessageBox.Show("Status:\t" + stStatus.ToString());
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] buildBytes(string str)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            return encoding.GetBytes(str);
        }
    }
}
