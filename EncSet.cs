using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThkDevEnc
{
    public partial class EncSet : Form
    {
        ThkEnvCfgs envCfgs = new ThkEnvCfgs();
        public EncSet()
        {
            InitializeComponent();

            cbPlatform.SelectedText = "全部";

            envCfgs.LoadConfig();
            ThkEnvConfig[] envcfgitems = envCfgs.GetAllConfig();
            ThkEnvConfig envcfgcur = envCfgs.GetCurEnvConfig();

            int nselidx = -1;
            foreach (ThkEnvConfig enc in envcfgitems)
            {
                int idx = cbEncConfig.Items.Add(enc.ConfigName);
                if (enc.ConfigName == envcfgcur.ConfigName)
                    nselidx = idx;                
            }
            if (envcfgitems.Length > 0)
            {
                if (nselidx == -1)
                    nselidx = 0;
                cbEncConfig.SelectedIndex = nselidx;
                cbEncConfig_SelectedIndexChanged(null, null);
            }
        }

        private void cbEncConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            int nsel = cbEncConfig.SelectedIndex;
            if (nsel == -1) return;
            ThkEnvConfig envcfg = envCfgs.GetEnvConfig(nsel);
            if (envcfg == null) return;
            ThkEnvCfgItem[] envitems = envcfg.EnvConfigItems;
            int nIdx = 1;
            foreach (ThkEnvCfgItem eci in envitems)
            {
                ListViewItem li = lstItems.Items.Add(nIdx.ToString());
                li.SubItems.Add(eci.EnvCfgItem);
                if (eci.EnvCfgFlatform == null || eci.EnvCfgFlatform.Length == 0 || eci.EnvCfgFlatform == "")
                    eci.EnvCfgFlatform = "全部";
                li.SubItems.Add(eci.EnvCfgFlatform);
                li.SubItems.Add(eci.EnvCfgValue);

                nIdx++;
           }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int nsel = cbEncConfig.SelectedIndex;
            if (nsel == -1) return;
            envCfgs.SetCurEnvConfig(nsel);
            envCfgs.SaveConfig();

            ThkEnvConfig enc = envCfgs.GetCurEnvConfig();
            if (enc != null)
            {
                ThkEnvCfgItem[] encitems = enc.EnvConfigItems;
                foreach (ThkEnvCfgItem ci in encitems)
                {
                    if (ci.EnvCfgFlatform == null || ci.EnvCfgFlatform.Length == 0 || ci.EnvCfgFlatform == "全部" || ci.EnvCfgFlatform == "")
                        Environment.SetEnvironmentVariable(ci.EnvCfgItem, ci.EnvCfgValue, EnvironmentVariableTarget.Process);
                }
            }
           DialogResult = DialogResult.OK;
           Close();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCfgItem.Text = "";
            tbCfgValue.Text = "";
            int nidx = cbPlatform.FindString("全部");
            cbPlatform.SelectedIndex = nidx;

            if (lstItems.SelectedItems.Count != 1)
                return;
            ListViewItem li = lstItems.SelectedItems[0];
            tbCfgItem.Text = li.SubItems[1].Text;
            nidx = cbPlatform.FindString(li.SubItems[2].Text);
            cbPlatform.SelectedIndex = nidx;
            tbCfgValue.Text = li.SubItems[3].Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nsel = cbEncConfig.SelectedIndex;
            if (nsel == -1) return;
            ThkEnvConfig envcfg = envCfgs.GetEnvConfig(nsel);
            if (envcfg == null) return;
            envcfg.AddEnvItem(tbCfgItem.Text, tbCfgValue.Text,cbPlatform.SelectedItem.ToString());
            envCfgs.SaveConfig();
            cbEncConfig_SelectedIndexChanged(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int nsel = cbEncConfig.SelectedIndex;
            if (nsel == -1) return;
            if(lstItems.SelectedItems.Count != 1)
                return;
            ThkEnvConfig envcfg = envCfgs.GetEnvConfig(nsel);
            if (envcfg == null) return;
            int nidx = Convert.ToInt32(lstItems.SelectedItems[0].Text) -1;
            envcfg.UpdEnvItem(nidx, tbCfgItem.Text, tbCfgValue.Text, cbPlatform.SelectedItem.ToString());
            envCfgs.SaveConfig();
            cbEncConfig_SelectedIndexChanged(null, null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int nsel = cbEncConfig.SelectedIndex;
            if (nsel == -1) return;
            if (lstItems.SelectedItems.Count != 1)
                return;
            ThkEnvConfig envcfg = envCfgs.GetEnvConfig(nsel);
            if (envcfg == null) return;
            int nidx = Convert.ToInt32(lstItems.SelectedItems[0].Text) - 1;
            envcfg.DelEnvItem(nidx);
            envCfgs.SaveConfig();
            cbEncConfig_SelectedIndexChanged(null, null);
        }
    }
}
