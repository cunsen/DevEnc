namespace ThkDevEnc
{
    partial class VcInfoSet
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbEncConfig = new System.Windows.Forms.ComboBox();
            this.tbVCDir = new System.Windows.Forms.TextBox();
            this.tbSDKDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.变量名 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEncVar = new System.Windows.Forms.TextBox();
            this.tbEncVal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(317, 15);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "设置";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "当前编译环境";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(400, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbEncConfig
            // 
            this.cbEncConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncConfig.FormattingEnabled = true;
            this.cbEncConfig.Location = new System.Drawing.Point(108, 15);
            this.cbEncConfig.Name = "cbEncConfig";
            this.cbEncConfig.Size = new System.Drawing.Size(112, 20);
            this.cbEncConfig.TabIndex = 7;
            this.cbEncConfig.SelectedIndexChanged += new System.EventHandler(this.cbEncConfig_SelectedIndexChanged);
            // 
            // tbVCDir
            // 
            this.tbVCDir.Location = new System.Drawing.Point(108, 63);
            this.tbVCDir.Name = "tbVCDir";
            this.tbVCDir.Size = new System.Drawing.Size(392, 21);
            this.tbVCDir.TabIndex = 17;
            // 
            // tbSDKDir
            // 
            this.tbSDKDir.Location = new System.Drawing.Point(108, 90);
            this.tbSDKDir.Name = "tbSDKDir";
            this.tbSDKDir.Size = new System.Drawing.Size(392, 21);
            this.tbSDKDir.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "VC目录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "SDK目录";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(370, 17);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "显示";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // 变量名
            // 
            this.变量名.AutoSize = true;
            this.变量名.Location = new System.Drawing.Point(15, 28);
            this.变量名.Name = "变量名";
            this.变量名.Size = new System.Drawing.Size(41, 12);
            this.变量名.TabIndex = 6;
            this.变量名.Text = "变量名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "变量值";
            // 
            // tbEncVar
            // 
            this.tbEncVar.Location = new System.Drawing.Point(72, 20);
            this.tbEncVar.Name = "tbEncVar";
            this.tbEncVar.Size = new System.Drawing.Size(168, 21);
            this.tbEncVar.TabIndex = 17;
            // 
            // tbEncVal
            // 
            this.tbEncVal.Location = new System.Drawing.Point(72, 49);
            this.tbEncVal.Multiline = true;
            this.tbEncVal.Name = "tbEncVal";
            this.tbEncVal.Size = new System.Drawing.Size(373, 146);
            this.tbEncVal.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.变量名);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.tbEncVar);
            this.groupBox1.Controls.Add(this.tbEncVal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(36, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 212);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "环境变量显示";
            // 
            // VcInfoSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSDKDir);
            this.Controls.Add(this.tbVCDir);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbEncConfig);
            this.Name = "VcInfoSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编译环境指定";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbEncConfig;
        private System.Windows.Forms.TextBox tbVCDir;
        private System.Windows.Forms.TextBox tbSDKDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label 变量名;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEncVar;
        private System.Windows.Forms.TextBox tbEncVal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}