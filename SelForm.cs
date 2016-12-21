using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using EnvDTE90;
using System.Collections;
using System.Diagnostics;

namespace ThkDevEnc
{
    public partial class SelForm : Form
    {
        private bool bCatia = false;

        public bool DebugCatia
        {
            get { return bCatia; }
            set { bCatia = value; }
        }

        public SelForm()
        {
            InitializeComponent();
            Process[] processes = Process.GetProcesses();

            string strproc = "xtop";
            if (bCatia)
                strproc = "cnext";

            for (int i = 0; i < processes.Length; i++ )
            {
                string strname = processes[i].ProcessName;
                strname = strname.ToLower();

                if (strname.Contains(strproc))
                {
                    ListViewItem item = new ListViewItem(processes[i].Id.ToString(),i);
                    item.SubItems.Add(processes[i].ProcessName);
                    item.SubItems.Add(processes[i].MainWindowTitle);
                    listView1.Items.Add(item);
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            m_iSelProc = GetSelProc();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DClickList(object sender, EventArgs e)
        {
            OK_Click(sender, e);
        }

        private int GetSelProc()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return int.Parse(listView1.SelectedItems[0].Text);
            }
            else
            {
                return -1;
            }
        }

        private int m_iSelProc;

        public int PROCESSES
        {
            get
            {
                return m_iSelProc;
            }
        }
    }
}
