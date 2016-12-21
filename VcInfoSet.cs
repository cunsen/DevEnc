using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThkDevEnc
{
    public partial class VcInfoSet : Form
    {
        ThkEnvCfgs envCfgs = new ThkEnvCfgs();

        public VcInfoSet()
        {
            InitializeComponent();

            envCfgs.LoadConfig();
            ThkVCDirSet vcconfig = envCfgs.GetVCConfig();
            if (vcconfig != null)
            {
                ThkVCDirItem[] vcitem = vcconfig.EnvConfigItems;
                if (vcitem != null)
                {
                    int nselidx = -1;
                    foreach (ThkVCDirItem vci in vcitem)
                    {
                        int idx = cbEncConfig.Items.Add(vci.StrVCVer);
                        if (vcconfig.CurVCItem == vci.StrVCVer)
                            nselidx = idx;
                    }
                    int idx1 = cbEncConfig.Items.Add(vcconfig.VcDefault.StrVCVer);
                    if (vcconfig.CurVCItem == vcconfig.VcDefault.StrVCVer)
                        nselidx = idx1;

                    if (nselidx == -1)
                        nselidx = 0;
                    cbEncConfig.SelectedIndex = nselidx;
                    cbEncConfig_SelectedIndexChanged(null, null);                   
                }
            }

        }

        private void cbEncConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSDKDir.Text = "";
            tbVCDir.Text = "";
            int nsel = cbEncConfig.SelectedIndex;
            if (nsel == -1) return;
            ThkVCDirSet vccfg = envCfgs.GetVCConfig();
            if (vccfg == null) return;
            ThkVCDirItem[] vcitems = vccfg.EnvConfigItems;
            ThkVCDirItem curItem = new ThkVCDirItem();
            if (nsel >= vcitems.Length)
                curItem = vccfg.VcDefault;
            else
                curItem = vcitems[nsel];

            tbVCDir.Text = curItem.StrVCDir;
            tbSDKDir.Text = curItem.StrSDKDir;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (tbVCDir.Text == "")
                return;
            MessageBox.Show("暂时关闭设置功能");
            {
              // Environment.SetEnvironmentVariable("VCInstallDir", tbVCDir.Text, EnvironmentVariableTarget.Process);
            }
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string strvs = Environment.GetEnvironmentVariable(tbEncVar.Text);
            if(strvs == null)
                strvs="没有定义";
            tbEncVal.Text = strvs;
        }
    }
}