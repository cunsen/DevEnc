using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EnvDTE80;
using System.Xml;

namespace LP_SC
{
    /// <文件拷贝>
    /// 文件拷贝
    /// </文件拷贝>
    public partial class FileCopyForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
        string SolutionPath;
        string SolutionName;
        string ServerPath;
        string XmlPath = "D:\\develop\\VsSetup\\FileCopy.xml";

        public FileCopyForm(DTE2 obj)
        {
            _applicationObject = obj;
            EnvDTE.Solution sln = _applicationObject.Solution;
            DirectoryInfo info = new DirectoryInfo(sln.FullName);
            SolutionPath = sln.FullName;
            SolutionName = info.Name;
            InitializeComponent();

            textFile.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textFile_Test.Text = "测试";
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(XmlPath);
                XmlNode xn = xmldoc.SelectSingleNode("VS");
                string userName = ((XmlElement)xn).GetAttribute("user");
                if (userName != null)
                {
                    textFile.Text = textFile.Text + "-" + userName;
                    textFile_Test.Text = "测试-" + userName; ;
                }
                xn = xn.SelectSingleNode(SolutionName);
                if (xn != null)
                {
                    XmlNode nodeServer = xn.SelectSingleNode("ThkServer");
                    if (nodeServer != null)
                    {
                        XmlElement Elem = (XmlElement)nodeServer;
                        ServerPath = Elem.GetAttribute("path");
                        //SetLbText(ServerPath);
                        textDir1.Text = ServerPath;
                        if (ServerPath.Length > 2)
                        {
                            checkBoxDir1.Checked = true;
                        }
                        ServerPath = Elem.GetAttribute("path2");
                        //SetLbText(ServerPath);
                        textDir2.Text = ServerPath;
                        if (ServerPath.Length > 2)
                        {
                            checkBoxDir2.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ept)
            {
                MessageBox.Show(ept.Message);
            }

            string UptInfoTextPath = null;
             if (checkBoxDir1.Checked)
            {
                string text = textDir1.Text;
                UptInfoTextPath = (text + "\\" + textFile.Text + "\\uptinfo.txt");
            }
            if (checkBoxDir2.Checked)
            {
                string text = textDir2.Text;
                UptInfoTextPath = (text + "\\" + textFile.Text + "\\uptinfo.txt");
            }
            if(UptInfoTextPath != null)
            {
                try
                {
                    StreamReader reader = new StreamReader(UptInfoTextPath);
                    textBox_UptInfo.Text = reader.ReadToEnd();
                    reader.Close();
                }
                catch (Exception )
                {

                }
            }
            ResetTree();
        }

        void ResetGrid()
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void treeViewAfterCheck(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    foreach (TreeNode child in e.Node.Nodes)
                    {
                        child.Checked = e.Node.Checked;
                    }
                }
            }

        }
        private void Up(string text)
        {
            try
            {
                foreach (TreeNode node in treeView1.Nodes)
                {
                    foreach (TreeNode dllnode in node.Nodes)
                    {
                        if (dllnode.Checked)
                        {
                            if (!Directory.Exists(text + "\\" + node.Text))
                            {
                                Directory.CreateDirectory(text + "\\" + node.Text);
                            }
                            if (File.Exists(text + "\\" + node.Text + "\\" + dllnode.Text))
                            {
                                File.Delete(text + "\\" + node.Text + "\\" + dllnode.Text);
                            }
                            File.Copy(dllnode.ToolTipText, text + "\\" + node.Text + "\\" + dllnode.Text);
                        }
                    }
                }
                string textUptInfo = textBox_UptInfo.Text;
                try
                {
                    StreamWriter wrt = File.CreateText(text + "\\" + "uptinfo.txt");
                    wrt.Write(textBox_UptInfo.Text);
                    wrt.Close();
                }
                catch (Exception ecp)
                {
                    MessageBox.Show("上传uptinfo.txt失败：" + ecp.Message);
                }

                MessageBox.Show("上传成功");
            }
            catch (Exception ecp)
            {
                MessageBox.Show(ecp.Message);
            }

        }
        private void buttonUP_Click(object sender, EventArgs e)
        {
            if (checkBoxDir1.Checked)
            {
                string text = textDir1.Text;
                Up(text + "\\" + textFile.Text);
            }
            if (checkBoxDir2.Checked)
            {
                string text = textDir2.Text;
                Up(text + "\\" + textFile.Text);
            }
        }
        private void buttonUP_Test_Click(object sender, EventArgs e)
        {
            if (checkBoxDir1.Checked)
            {
                string text = textDir1.Text;
                Up(text + "\\" + textFile_Test.Text);
            }
            if (checkBoxDir2.Checked)
            {
                string text = textDir2.Text;
                Up(text + "\\" + textFile_Test.Text);
            }
        }
        TreeNode AddDll(TreeNode node, string p)
        {
            try
            {
                bool bFind = false;
                string[] files = Directory.GetFiles(p + "\\bin\\" + node.Text, "*.dll");
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    TreeNode fileNode = new TreeNode(fi.Name);
                    fileNode.ToolTipText = file;
                    node.Nodes.Add(fileNode);
                    bFind = true;
                }

                string[] exefiles = Directory.GetFiles(p + "\\bin\\" + node.Text, "*.exe");
                foreach (string file in exefiles)
                {
                    FileInfo fi = new FileInfo(file);
                    TreeNode fileNode = new TreeNode(fi.Name);
                    fileNode.ToolTipText = file;
                    node.Nodes.Add(fileNode);
                    bFind = true;
                }
                node.Expand();
                if (!bFind)
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            return node;
        }
        public void ResetTree()
        {
            EnvDTE.Solution sln = _applicationObject.Solution;
            DirectoryInfo info = Directory.GetParent(sln.FullName);
            treeView1.Nodes.Clear();
            TreeNode nodeTmp = AddDll(new TreeNode("ThkRelLibWF5x64"), info.FullName);
            if (nodeTmp != null)
                treeView1.Nodes.Add(nodeTmp);
            nodeTmp = AddDll(new TreeNode("ThkRelLibWF5"), info.FullName);
            if (nodeTmp != null)
                treeView1.Nodes.Add(nodeTmp);
            nodeTmp = AddDll(new TreeNode("RelLibCR2"), info.FullName);
            if (nodeTmp != null)
                treeView1.Nodes.Add(nodeTmp);
            nodeTmp = AddDll(new TreeNode("RelLibCR2x64"), info.FullName);
            if (nodeTmp != null)
                treeView1.Nodes.Add(nodeTmp);
            nodeTmp = AddDll(new TreeNode("Release"), info.FullName);
            if (nodeTmp != null)
                treeView1.Nodes.Add(nodeTmp);
            nodeTmp = AddDll(new TreeNode("Releasex64"), info.FullName);
            if (nodeTmp != null)
                treeView1.Nodes.Add(nodeTmp);
            nodeTmp = AddDll(new TreeNode("ThkRelLibWF4x64"), info.FullName);
            if (nodeTmp != null)
                treeView1.Nodes.Add(nodeTmp);
            nodeTmp = AddDll(new TreeNode("ThkRelLibWF4"), info.FullName);
            if (nodeTmp != null)
                treeView1.Nodes.Add(nodeTmp);
        }
        private DTE2 _applicationObject;

        private void buttonSelPath_Click(int i)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (DialogResult.OK == dlg.ShowDialog())
            {
                ServerPath = dlg.SelectedPath;
                System.Windows.Forms.TextBox textbox;
                string pathAttr;
                if (i == 0)
                {
                    textbox = textDir1;
                    pathAttr = "path";
                }
                else
                {
                    textbox = textDir2;
                    pathAttr = "path2";
                }
                textbox.Text = ServerPath;

                PathSet(pathAttr, textbox.Text);
            }
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textDir1.Text;
                if (text == "")
                {
                    text = textDir2.Text;
                }
                if (!Directory.Exists(text))
                {
                    MessageBox.Show("不存在目录" + text);
                    return;
                }
                System.Diagnostics.Process.Start(text);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnOpenBinDir_Click(object sender, EventArgs e)
        {
            EnvDTE.Solution sln = _applicationObject.Solution;
            DirectoryInfo info = Directory.GetParent(sln.FullName);
            try
            {
                string text = info.FullName;
                System.Diagnostics.Process.Start(text + "\\bin");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnUpText_Click(object sender, EventArgs e)
        {

        }

        private void btnSelDir1_Click(object sender, EventArgs e)
        {
            buttonSelPath_Click(0);
        }

        private void btnSelDir2_Click(object sender, EventArgs e)
        {
            buttonSelPath_Click(1);
        }

        private void PathSet(string pathAttr, string strpath)
        {
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                try
                {
                    xmldoc.Load(XmlPath);
                }
                catch
                {

                }
                XmlNode xn_vs = xmldoc.SelectSingleNode("VS");
                if (xn_vs == null)
                {
                    XmlElement xe = xmldoc.CreateElement("VS");
                    xn_vs = xmldoc.AppendChild(xe);
                }
                XmlNode xn_sln = xn_vs.SelectSingleNode(SolutionName);
                if (xn_sln == null)
                {
                    XmlElement xe = xmldoc.CreateElement(SolutionName);
                    xn_sln = xn_vs.AppendChild(xe);
                }


                XmlNode nodeServer = xn_sln.SelectSingleNode("ThkServer");
                if (nodeServer == null)
                {
                    XmlElement xe = xmldoc.CreateElement("ThkServer");
                    xe.SetAttribute(pathAttr, strpath);
                    nodeServer = xn_sln.AppendChild(xe);
                }
                else
                {
                    XmlElement Elem = (XmlElement)nodeServer;
                    Elem.SetAttribute(pathAttr, strpath);
                }
                xmldoc.Save(XmlPath);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnDirSet2_Click(object sender, EventArgs e)
        {
            PathSet("path2", textDir2.Text);
        }

        private void btnDirSet1_Click(object sender, EventArgs e)
        {
            PathSet("path", textDir2.Text);
        }

        private void btnTextInfoSet_Click(object sender, EventArgs e)
        {

        }
    }
}
