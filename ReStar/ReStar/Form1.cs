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
            foreach (TreeNode n in trvMachines.Nodes){
                if (n.Checked)
                {
                    restart(o, numTimer.Value, n.Text, true, 0, 0, "");
                }
            }
        }

        private void restart( String type, Decimal timeout, String machineName, Boolean planned, int majorReason, int minorReason, String comments )
        {
            String time = "";
            String isPlanned;
            String allComments = "";
            if (timeout > 0){
                time = "/t " + timeout.ToString() + " ";
            }
            if (planned)
            {
                isPlanned = "/d /p:";
            }
            else
            {
                isPlanned = "/d /u:";
            }
            if (comments != "")
            {
                allComments = "/c " + "'" + comments + "'";
            }
            System.Diagnostics.Process.Start("shutdown " + type + time +/* "/m \\" + machineName + " " +*/ isPlanned + majorReason + ":" + minorReason + allComments );
        }

        private void rdoRestart_CheckedChanged(object sender, EventArgs e)
        {
           if (rdoRestart.Checked){
               o = "/r ";
           }
        }

        private void rdoShutDown_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoShutDown.Checked){
                o = "/s ";
            }
        }

        private void rdoAbort_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAbort.Checked){
                o = "/a ";
            }
        }
    }
}
