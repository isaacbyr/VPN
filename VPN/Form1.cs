using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace VPN
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            if(serverComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select A Server");
                return;
            }

            if (!udpButton.Checked && !tcpButton.Checked)
            {
                MessageBox.Show("Please Choose UDP or TCP");
                return;
            }

            if(serverComboBox.Text.Equals("New York") && udpButton.Checked)
            {
                try
                {
                    string args = @"--config usUDP.ovpn";
                    StartProcess(args);
                    MessageBox.Show("You are connected to New York server with UDP", "Connected To Server");
                } 
                catch (Exception)
                {
                    MessageBox.Show("Error Connecting To Server", "Error");
                }


            } 
            else if (serverComboBox.Text.Equals("New York") && tcpButton.Checked)
            {
                try
                {
                    string args = @"--config usTCP.ovpn";
                    StartProcess(args);
                    MessageBox.Show("You are connected to New York server with TCP", "Connected To Server");
                } 
                catch (Exception)
                {
                    MessageBox.Show("Error Connecting To Server", "Error");
                }
                
            }
            else if (serverComboBox.SelectedItem.Equals("Singapore") && udpButton.Checked)
            {
                try
                {
                    string args = @"--config singaporeUDP.ovpn";
                    StartProcess(args);
                    MessageBox.Show("You are connected to Singapore server with UDP", "Connected To Server");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Connecting To Server", "Error");
                }


            }
            else if (serverComboBox.SelectedItem.Equals("Singapore") && tcpButton.Checked)
            {
                try
                {
                    string args = @"--config singaporeTCP.ovpn";
                    StartProcess(args);
                    MessageBox.Show("You are connected to Singapore server with UDP", "Connected To Server");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Connecting To Server", "Error");
                }
                
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            disconnect();
            string ip = GetCurrentIp();
            MessageBox.Show($"Your IP is now {ip}", "Disconnected From Server");
            
        }

        private string GetCurrentIp()
        {
            WebClient wc = new WebClient();
            string ip = wc.DownloadString("https://api.ipify.org");
            return ip;
        }

        private void disconnect()
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.StartsWith("openvpn"))
                {
                    p.Kill();
                    
                    break;
                };
            };
        }

        private void StartProcess(string args)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
            startInfo.Arguments = args;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
           
        }

        
    }
}
