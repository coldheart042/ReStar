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
    }
}
