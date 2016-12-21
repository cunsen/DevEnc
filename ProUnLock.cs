using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ThkDevEnc
{
    public partial class ProUnLock : Form
    {
        public ThkEnvCfgs m_envcfgs;

        public ProUnLock()
        {
            InitializeComponent();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                cbProeDir.Text = fbd.SelectedPath;
                ThkProeDirCfgs proecfgs = m_envcfgs.GetProeDirs();
                if (proecfgs.AddProeDirs(fbd.SelectedPath))
                    m_envcfgs.SaveConfig();
            }
        }

        private void btnBrowFile_Click(object sender, EventArgs e)
        {
            ThkProeDirCfgs proecfgs = m_envcfgs.GetProeDirs();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = proecfgs.LastToolkitDir;
            openFileDialog.Filter = "可执行文件(*.exe;*,dll)|*.exe;*.dll|所有文件|*.*||";
            // openFileDialog.Filter = "可执行文件|*.exe|快捷方式|*.lnk|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo ff = new FileInfo(openFileDialog.FileName);
                txtFile.Text = openFileDialog.FileName;
                proecfgs.LastToolkitDir = ff.DirectoryName;
                m_envcfgs.SaveConfig();
            }
        }
    }
}
