namespace ThkDevEnc
{
    partial class ProUnLock
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbProeDir = new System.Windows.Forms.ComboBox();
            this.btnBrowDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowFile = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pro/E Install Dir";
            // 
            // cbProeDir
            // 
            this.cbProeDir.FormattingEnabled = true;
            this.cbProeDir.Location = new System.Drawing.Point(125, 19);
            this.cbProeDir.Name = "cbProeDir";
            this.cbProeDir.Size = new System.Drawing.Size(410, 20);
            this.cbProeDir.TabIndex = 1;
            // 
            // btnBrowDir
            // 
            this.btnBrowDir.Location = new System.Drawing.Point(542, 17);
            this.btnBrowDir.Name = "btnBrowDir";
            this.btnBrowDir.Size = new System.Drawing.Size(48, 23);
            this.btnBrowDir.TabIndex = 2;
            this.btnBrowDir.Text = "Brow";
            this.btnBrowDir.UseVisualStyleBackColor = true;
            this.btnBrowDir.Click += new System.EventHandler(this.btnBrowDir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "UnLock File Info";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(125, 55);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(410, 21);
            this.txtFile.TabIndex = 3;
            // 
            // btnBrowFile
            // 
            this.btnBrowFile.Location = new System.Drawing.Point(542, 53);
            this.btnBrowFile.Name = "btnBrowFile";
            this.btnBrowFile.Size = new System.Drawing.Size(48, 23);
            this.btnBrowFile.TabIndex = 2;
            this.btnBrowFile.Text = "Brow";
            this.btnBrowFile.UseVisualStyleBackColor = true;
            this.btnBrowFile.Click += new System.EventHandler(this.btnBrowFile_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(250, 284);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(117, 23);
            this.btnUnlock.TabIndex = 4;
            this.btnUnlock.Text = "Unlock Now";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "UnLock Res Info";
            // 
            // txtResInfo
            // 
            this.txtResInfo.Location = new System.Drawing.Point(125, 96);
            this.txtResInfo.Multiline = true;
            this.txtResInfo.Name = "txtResInfo";
            this.txtResInfo.ReadOnly = true;
            this.txtResInfo.Size = new System.Drawing.Size(410, 167);
            this.txtResInfo.TabIndex = 3;
            // 
            // ProUnLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 319);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.txtResInfo);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnBrowFile);
            this.Controls.Add(this.btnBrowDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProeDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProUnLock";
            this.Text = "Unlock Pro/Toolkit Dll/Apps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProeDir;
        private System.Windows.Forms.Button btnBrowDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowFile;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResInfo;
    }
}