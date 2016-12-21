namespace LP_SC
{
    partial class FileCopyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.buttonUP_Test = new System.Windows.Forms.Button();
            this.textFile_Test = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelDir1 = new System.Windows.Forms.Button();
            this.checkBoxDir1 = new System.Windows.Forms.CheckBox();
            this.textDir1 = new System.Windows.Forms.TextBox();
            this.btnSelDir2 = new System.Windows.Forms.Button();
            this.checkBoxDir2 = new System.Windows.Forms.CheckBox();
            this.btnUpText = new System.Windows.Forms.Button();
            this.textDir2 = new System.Windows.Forms.TextBox();
            this.btnDirSet1 = new System.Windows.Forms.Button();
            this.btnDirSet2 = new System.Windows.Forms.Button();
            this.btnUpConfig = new System.Windows.Forms.Button();
            this.btnUpOther = new System.Windows.Forms.Button();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.btnOpenBinDir = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnTextInfoSet = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_UptInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 18);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonUP
            // 
            this.buttonUP.Location = new System.Drawing.Point(240, 92);
            this.buttonUP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(56, 28);
            this.buttonUP.TabIndex = 1;
            this.buttonUP.Text = "上传";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(66, 94);
            this.textFile.Margin = new System.Windows.Forms.Padding(2);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(162, 21);
            this.textFile.TabIndex = 3;
            // 
            // buttonUP_Test
            // 
            this.buttonUP_Test.Location = new System.Drawing.Point(569, 97);
            this.buttonUP_Test.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUP_Test.Name = "buttonUP_Test";
            this.buttonUP_Test.Size = new System.Drawing.Size(56, 28);
            this.buttonUP_Test.TabIndex = 1;
            this.buttonUP_Test.Text = "上传";
            this.buttonUP_Test.UseVisualStyleBackColor = true;
            this.buttonUP_Test.Click += new System.EventHandler(this.buttonUP_Test_Click);
            // 
            // textFile_Test
            // 
            this.textFile_Test.Location = new System.Drawing.Point(395, 99);
            this.textFile_Test.Margin = new System.Windows.Forms.Padding(2);
            this.textFile_Test.Name = "textFile_Test";
            this.textFile_Test.Size = new System.Drawing.Size(162, 21);
            this.textFile_Test.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件名";
            // 
            // btnSelDir1
            // 
            this.btnSelDir1.Location = new System.Drawing.Point(563, 27);
            this.btnSelDir1.Name = "btnSelDir1";
            this.btnSelDir1.Size = new System.Drawing.Size(67, 21);
            this.btnSelDir1.TabIndex = 8;
            this.btnSelDir1.Text = "选择目录";
            this.btnSelDir1.UseVisualStyleBackColor = true;
            this.btnSelDir1.Click += new System.EventHandler(this.btnSelDir1_Click);
            // 
            // checkBoxDir1
            // 
            this.checkBoxDir1.AutoSize = true;
            this.checkBoxDir1.Location = new System.Drawing.Point(11, 30);
            this.checkBoxDir1.Name = "checkBoxDir1";
            this.checkBoxDir1.Size = new System.Drawing.Size(54, 16);
            this.checkBoxDir1.TabIndex = 9;
            this.checkBoxDir1.Text = "目录1";
            this.checkBoxDir1.UseVisualStyleBackColor = true;
            // 
            // textDir1
            // 
            this.textDir1.Location = new System.Drawing.Point(72, 27);
            this.textDir1.Name = "textDir1";
            this.textDir1.Size = new System.Drawing.Size(485, 21);
            this.textDir1.TabIndex = 10;
            // 
            // btnSelDir2
            // 
            this.btnSelDir2.Location = new System.Drawing.Point(563, 57);
            this.btnSelDir2.Name = "btnSelDir2";
            this.btnSelDir2.Size = new System.Drawing.Size(67, 23);
            this.btnSelDir2.TabIndex = 11;
            this.btnSelDir2.Text = "选择目录";
            this.btnSelDir2.UseVisualStyleBackColor = true;
            this.btnSelDir2.Click += new System.EventHandler(this.btnSelDir2_Click);
            // 
            // checkBoxDir2
            // 
            this.checkBoxDir2.AutoSize = true;
            this.checkBoxDir2.Location = new System.Drawing.Point(10, 59);
            this.checkBoxDir2.Name = "checkBoxDir2";
            this.checkBoxDir2.Size = new System.Drawing.Size(54, 16);
            this.checkBoxDir2.TabIndex = 12;
            this.checkBoxDir2.Text = "目录2";
            this.checkBoxDir2.UseVisualStyleBackColor = true;
            // 
            // btnUpText
            // 
            this.btnUpText.Location = new System.Drawing.Point(252, 132);
            this.btnUpText.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpText.Name = "btnUpText";
            this.btnUpText.Size = new System.Drawing.Size(106, 31);
            this.btnUpText.TabIndex = 7;
            this.btnUpText.Text = "上传Text";
            this.btnUpText.UseVisualStyleBackColor = true;
            this.btnUpText.Click += new System.EventHandler(this.btnUpText_Click);
            // 
            // textDir2
            // 
            this.textDir2.Location = new System.Drawing.Point(71, 57);
            this.textDir2.Name = "textDir2";
            this.textDir2.Size = new System.Drawing.Size(486, 21);
            this.textDir2.TabIndex = 13;
            // 
            // btnDirSet1
            // 
            this.btnDirSet1.Location = new System.Drawing.Point(637, 27);
            this.btnDirSet1.Name = "btnDirSet1";
            this.btnDirSet1.Size = new System.Drawing.Size(41, 23);
            this.btnDirSet1.TabIndex = 14;
            this.btnDirSet1.Text = "设置";
            this.btnDirSet1.UseVisualStyleBackColor = true;
            this.btnDirSet1.Click += new System.EventHandler(this.btnDirSet1_Click);
            // 
            // btnDirSet2
            // 
            this.btnDirSet2.Location = new System.Drawing.Point(636, 56);
            this.btnDirSet2.Name = "btnDirSet2";
            this.btnDirSet2.Size = new System.Drawing.Size(41, 23);
            this.btnDirSet2.TabIndex = 14;
            this.btnDirSet2.Text = "设置";
            this.btnDirSet2.UseVisualStyleBackColor = true;
            this.btnDirSet2.Click += new System.EventHandler(this.btnDirSet2_Click);
            // 
            // btnUpConfig
            // 
            this.btnUpConfig.Location = new System.Drawing.Point(408, 132);
            this.btnUpConfig.Name = "btnUpConfig";
            this.btnUpConfig.Size = new System.Drawing.Size(114, 30);
            this.btnUpConfig.TabIndex = 15;
            this.btnUpConfig.Text = "上传配置文件";
            this.btnUpConfig.UseVisualStyleBackColor = true;
            // 
            // btnUpOther
            // 
            this.btnUpOther.Location = new System.Drawing.Point(563, 132);
            this.btnUpOther.Name = "btnUpOther";
            this.btnUpOther.Size = new System.Drawing.Size(102, 30);
            this.btnUpOther.TabIndex = 16;
            this.btnUpOther.Text = "上传其他文件";
            this.btnUpOther.UseVisualStyleBackColor = true;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(574, 83);
            this.btnOpenDir.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(106, 31);
            this.btnOpenDir.TabIndex = 5;
            this.btnOpenDir.Text = "打开服务器目录";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // btnOpenBinDir
            // 
            this.btnOpenBinDir.Location = new System.Drawing.Point(573, 48);
            this.btnOpenBinDir.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenBinDir.Name = "btnOpenBinDir";
            this.btnOpenBinDir.Size = new System.Drawing.Size(106, 31);
            this.btnOpenBinDir.TabIndex = 6;
            this.btnOpenBinDir.Text = "打开bin目录";
            this.btnOpenBinDir.UseVisualStyleBackColor = true;
            this.btnOpenBinDir.Click += new System.EventHandler(this.btnOpenBinDir_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(2, 4);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 100, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(569, 372);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnTextInfoSet
            // 
            this.btnTextInfoSet.Location = new System.Drawing.Point(574, 12);
            this.btnTextInfoSet.Name = "btnTextInfoSet";
            this.btnTextInfoSet.Size = new System.Drawing.Size(106, 31);
            this.btnTextInfoSet.TabIndex = 4;
            this.btnTextInfoSet.Text = "文件上传设置";
            this.btnTextInfoSet.UseVisualStyleBackColor = true;
            this.btnTextInfoSet.Click += new System.EventHandler(this.btnTextInfoSet_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 100, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_UptInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnTextInfoSet);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenBinDir);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenDir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnUpOther);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpConfig);
            this.splitContainer1.Panel2.Controls.Add(this.btnDirSet2);
            this.splitContainer1.Panel2.Controls.Add(this.btnDirSet1);
            this.splitContainer1.Panel2.Controls.Add(this.textDir2);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpText);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxDir2);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelDir2);
            this.splitContainer1.Panel2.Controls.Add(this.textDir1);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxDir1);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelDir1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textFile_Test);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUP_Test);
            this.splitContainer1.Panel2.Controls.Add(this.textFile);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUP);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(695, 758);
            this.splitContainer1.SplitterDistance = 575;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // textBox_UptInfo
            // 
            this.textBox_UptInfo.Location = new System.Drawing.Point(2, 406);
            this.textBox_UptInfo.Multiline = true;
            this.textBox_UptInfo.Name = "textBox_UptInfo";
            this.textBox_UptInfo.Size = new System.Drawing.Size(569, 166);
            this.textBox_UptInfo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "更新内容";
            // 
            // FileCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(695, 758);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FileCopyForm";
            this.Text = "文件上传";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Button buttonUP_Test;
        private System.Windows.Forms.TextBox textFile_Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelDir1;
        private System.Windows.Forms.CheckBox checkBoxDir1;
        private System.Windows.Forms.TextBox textDir1;
        private System.Windows.Forms.Button btnSelDir2;
        private System.Windows.Forms.CheckBox checkBoxDir2;
        private System.Windows.Forms.Button btnUpText;
        private System.Windows.Forms.TextBox textDir2;
        private System.Windows.Forms.Button btnDirSet1;
        private System.Windows.Forms.Button btnDirSet2;
        private System.Windows.Forms.Button btnUpConfig;
        private System.Windows.Forms.Button btnUpOther;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Button btnOpenBinDir;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnTextInfoSet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_UptInfo;
        private System.Windows.Forms.Label label3;

    }
}