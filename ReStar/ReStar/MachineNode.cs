using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ReStar
{
    public partial class MachineNode : UserControl
    {
        // Global Variables (all private):
        private String MachineName; // Required to instantiate
        private int Timeout = 1500; // Default value of 1.5 seconds
        private int status = 0;     // Will be determined upon initialization 
        private Ping checkOnline = new Ping();

        // Constructors and event handlers:
        public MachineNode(String name, int timeout)    // Instantiates the MachineNode with name and timeout
        {            
            InitializeComponent();
            setName(name);
            Timeout = timeout;
        }

        public MachineNode(String name)    // Instantiates the MachineNode with only a name
        {           
            InitializeComponent();
            setName(name);
        }

        private void MachineNode_Load(object sender, EventArgs e)
        {
            PingReply response = checkOnline.Send(MachineName, Timeout);
            if (response.Status == IPStatus.Success) {
                this.BackColor = Color.Yellow;
                status = 1;
            }
        }

        private void tmrPingTimer_Tick(object sender, EventArgs e)
        {
            // When the timer elapses, ping the Machine
            PingReply response = checkOnline.Send(MachineName, Timeout);
            switch (response.Status){
                case IPStatus.TimedOut:
                    if (status == 1) {  // If the machine was on & unchanged
                        nodeOff();
                        status = 2;
                    }
                    else if (status == 3) 
                    { // If the machine was on & changed (error)
                        noderr();
                        status = 4;
                    }
                    break;
                case IPStatus.Success:
                    if (status == 2)
                    { // If off & unchanged
                        nodeon();
                        status = 3;
                    }
                    else if (status == 4)
                    { // If off & changed (recovery from error)
                        nodeon();
                    }
                    break;
                default:
                    // Any errors return a black node and stop the ping timer to save resources.
                    noderr();
                    tmrPingTimer.Stop();
                    break;
            }
        }
        // DRY Methods:

        private void setName(String name) {
            MachineName = name;
            MachineLabel.Text = name;
        }

        private void nodeOff()
        {
            this.BackColor = Color.Red;
            MachineLabel.ForeColor = Color.Yellow;
        }

        private void nodeon()
        {
            this.BackColor = Color.Green;
            MachineLabel.ForeColor = Color.Black;
        }

        private void noderr()
        {
            this.BackColor = Color.Black;
            MachineLabel.ForeColor = Color.LightGray;
        }
    }
}
