namespace ThkDevEnc
{
    partial class UpFileSet
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Text");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Config（配置文件）");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("其他");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModfy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, -3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "Text";
            treeNode2.Name = "节点1";
            treeNode2.Text = "Config（配置文件）";
            treeNode3.Name = "节点2";
            treeNode3.Text = "其他";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(283, 381);
            this.treeView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModfy
            // 
            this.btnModfy.Location = new System.Drawing.Point(142, 394);
            this.btnModfy.Name = "btnModfy";
            this.btnModfy.Size = new System.Drawing.Size(75, 23);
            this.btnModfy.TabIndex = 2;
            this.btnModfy.Text = "修改";
            this.btnModfy.UseVisualStyleBackColor = true;
            this.btnModfy.Click += new System.EventHandler(this.btnModfy_Click);
            // 
            // UpFileSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 430);
            this.Controls.Add(this.btnModfy);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.treeView1);
            this.Name = "UpFileSet";
            this.Text = "UpFileSet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModfy;
    }
}