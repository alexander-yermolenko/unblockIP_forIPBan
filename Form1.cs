using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NetFwTypeLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace unblockIP_forIPBan
{
    public partial class App : Form
    {
        private int mySecond = 0;
        public App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFirewall();
        }

        private void buttonReadFirewall_Click(object sender, EventArgs e)
        {
            ReadFirewall();
        }

        private void ReadFirewall()
        {
            myComboBox.Items.Clear();

            // Get firewall rules manager instance
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            // Get all rules
            foreach (INetFwRule rule in firewallPolicy.Rules)
            {
                // Check if the rule is the one we are looking for
                if (rule.Name == "IPBan_Block_0" && rule.Direction == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN)
                {
                    // List blocked IP addresses
                    string[] blockedIPs = rule.RemoteAddresses.Split(',');
                    // Console.WriteLine("Blocked IP addresses in the rule IPBan_Block_0:");
                    foreach (string ip in blockedIPs)
                    {
                        myComboBox.Items.Add(ip.Replace("/255.255.255.255", ""));
                    }
                }
            }
        }

        private void buttonUnblockIP_Click(object sender, EventArgs e)
        {

            string newIP = myComboBox.Text.Trim(); // Trim whitespace from input

            if (IsValidIPAddress(newIP))
            {

                if (myComboBox.FindStringExact(myComboBox.Text) == -1)
                {
                    MessageBox.Show("IP is not in the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }

                // IP address is valid, proceed with saving or using it
                try
                {

                    Unblock_begin(newIP);

                    timer1.Start();

                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // IP address is not valid, show error message
                MessageBox.Show("Please enter a valid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Unblock_begin(string newIP)
        {
            string filePath = "c:\\Program Files\\IPBan\\unban.txt";
            buttonUnblockIP.Enabled = false;

            // Append the new IP to the file or process it as needed
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(newIP);
            }

        }
        private void Unblock_end()
        {
            mySecond = 0;
            buttonUnblockIP.Text = "Unblock IP";
            buttonUnblockIP.Enabled = true;
            MessageBox.Show("IP unblock successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReadFirewall();
        }

        private bool IsValidIPAddress(string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
                return false;

            // Split the IP address by '.'
            string[] ipSegments = ipAddress.Split('.');

            // Check that we have exactly 4 segments
            if (ipSegments.Length != 4)
                return false;

            // Validate each segment
            foreach (string segment in ipSegments)
            {
                // Check if the segment is a valid integer
                if (!int.TryParse(segment, out int num))
                    return false;

                // Check if the number is within the range of 0 to 255
                if (num < 0 || num > 255)
                    return false;
            }

            return true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mySecond == 20)
            {
                timer1.Stop();
                Unblock_end();
            }
            else
            {
                mySecond++;
                buttonUnblockIP.Text = (20 - mySecond).ToString();
            }
        }
    }
}