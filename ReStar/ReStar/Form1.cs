using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReStar
{
    public partial class frmMain : Form
    {

        ArrayList nodes = new ArrayList();
        int pos = 0;
        string o = "/r ";

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdMain.ShowDialog();
            
        }

        private void ofdMain_FileOk(object sender, CancelEventArgs e)
        {
            Stream s = null;           
            try
            {
                if ((s = ofdMain.OpenFile()) != null)
                {
                    using (s)
                    {
                        StreamReader sr = new StreamReader(s);
                        while ( sr.Peek() > -1 )
                        {
                            nodes.Add(sr.ReadLine());
                        }
                    }
                }
                foreach(String node in nodes)
                {
                    TreeNode n = new TreeNode(node);
                    trvMachines.Nodes.Add(n);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            tmrAdd.Start();
        }

        private void tmrAdd_Tick(object sender, EventArgs e)
        {
            if (pos < nodes.Count)
            {
                String temp = nodes[pos].ToString();
                MachineNode m = new MachineNode(temp);
                flowLayoutPanel1.Controls.Add(m);
                pos++;
            }
        }

        private void dumpSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trvMachines.Nodes.Clear();
            flowLayoutPanel1.Controls.Clear();
            nodes.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String type = "/r ";
            String timeout = "/t " + numTimer.Value.ToString() + " ";
            String comments = "/c " + "'" + txtComments.Text + "' ";
            String majorCode;
            switch (cmbMajor.SelectedIndex)
            {
                case 0:
                    majorCode = "0";
                    break;
                case 1:
                    majorCode = "1";
                    break;
                case 2:
                    majorCode = "2";
                    break;
                case 3:
                    majorCode = "4";
                    break;
                case 4:
                    majorCode = "5";
                    break;
                case 5:
                    majorCode = "6";
                    break;
                default:
                    majorCode = "0";
                    break;
            }

            String minorCode;
            switch (cmbMinor.SelectedIndex)
            {
                case 0:
                    minorCode = "0";
                    break;
                case 1:
                    minorCode = "1";
                    break;
                case 2:
                    minorCode = "2";
                    break;
                case 3:
                    minorCode = "3";
                    break;
                case 4:
                    minorCode = "4";
                    break;
                case 5:
                    minorCode = "5";
                    break;
                case 6:
                    minorCode = "6";
                    break;
                case 7:
                    minorCode = "11";
                    break;
                case 8:
                    minorCode = "12";
                    break;
                case 9:
                    minorCode = "15";
                    break;
                case 10:
                    minorCode = "16";
                    break;
                case 11:
                    minorCode = "17";
                    break;
                case 12:
                    minorCode = "18";
                    break;
                default:
                    minorCode = "0";
                    break;
            }

            String isPlanned = "P:";
            if (rdoPlanned.Checked && isPlanned != "/d P:")
            {
                isPlanned = "/d P:";
            }
            if (rdoUnplanned.Checked && isPlanned != "/d u:")
            {
                isPlanned = "/d u:";
            }
            foreach (TreeNode n in trvMachines.Nodes){
                String machine = "/m \\\\" + n.Text + " ";
                if (n.Checked)
                {
                    restart( type, machine, timeout, isPlanned, majorCode, minorCode, comments );
                }
            }
        }

        private void restart( String type, String machineName, String timeout, String isPlanned, String majorCode, String minorCode, String comments )
        {

            System.Diagnostics.Process.Start("shutdown", type + machineName + timeout + isPlanned + majorCode + ":" + minorCode + comments );
        }

        private void rdoRestart_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rdoShutDown_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdoAbort_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
