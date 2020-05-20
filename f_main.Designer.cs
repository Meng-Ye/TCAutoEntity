namespace AutoTcEntity
{
    partial class f_main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_using = new System.Windows.Forms.TextBox();
            this.tv_LinkInfo = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_baseclass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_namespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_classattr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fieldattr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_autoprimarykey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_primarykey = new System.Windows.Forms.TextBox();
            this.TreeNode_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.生成所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预览生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeNode_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "导入命名空间: ";
            // 
            // txt_using
            // 
            this.txt_using.Location = new System.Drawing.Point(291, 12);
            this.txt_using.Multiline = true;
            this.txt_using.Name = "txt_using";
            this.txt_using.Size = new System.Drawing.Size(248, 102);
            this.txt_using.TabIndex = 2;
            this.txt_using.Text = "using Entity.Base;\r\nusing System;\r\nusing Utility;";
            // 
            // tv_LinkInfo
            // 
            this.tv_LinkInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tv_LinkInfo.ContextMenuStrip = this.TreeNode_ContextMenuStrip;
            this.tv_LinkInfo.Location = new System.Drawing.Point(1, 1);
            this.tv_LinkInfo.Name = "tv_LinkInfo";
            this.tv_LinkInfo.Size = new System.Drawing.Size(179, 747);
            this.tv_LinkInfo.TabIndex = 3;
            this.tv_LinkInfo.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_LinkInfo_NodeMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "继承的父类: ";
            // 
            // txt_baseclass
            // 
            this.txt_baseclass.Location = new System.Drawing.Point(708, 9);
            this.txt_baseclass.Name = "txt_baseclass";
            this.txt_baseclass.Size = new System.Drawing.Size(224, 21);
            this.txt_baseclass.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1045, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "命名空间: ";
            // 
            // txt_namespace
            // 
            this.txt_namespace.Location = new System.Drawing.Point(1151, 12);
            this.txt_namespace.Name = "txt_namespace";
            this.txt_namespace.Size = new System.Drawing.Size(224, 21);
            this.txt_namespace.TabIndex = 17;
            this.txt_namespace.Text = "Entity.City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "自定义实体类特性: ";
            // 
            // txt_classattr
            // 
            this.txt_classattr.Location = new System.Drawing.Point(708, 90);
            this.txt_classattr.Name = "txt_classattr";
            this.txt_classattr.Size = new System.Drawing.Size(224, 21);
            this.txt_classattr.TabIndex = 19;
            this.txt_classattr.Text = "[Serializable,SqlTable(dbEnum.SAS)]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "自定义字段特性: ";
            // 
            // txt_fieldattr
            // 
            this.txt_fieldattr.Location = new System.Drawing.Point(708, 47);
            this.txt_fieldattr.Name = "txt_fieldattr";
            this.txt_fieldattr.Size = new System.Drawing.Size(224, 21);
            this.txt_fieldattr.TabIndex = 19;
            this.txt_fieldattr.Text = "[SqlField]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(997, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "自定义自增主键特性: ";
            // 
            // txt_autoprimarykey
            // 
            this.txt_autoprimarykey.Location = new System.Drawing.Point(1151, 47);
            this.txt_autoprimarykey.Name = "txt_autoprimarykey";
            this.txt_autoprimarykey.Size = new System.Drawing.Size(224, 21);
            this.txt_autoprimarykey.TabIndex = 19;
            this.txt_autoprimarykey.Text = "[SqlField(IsPrimaryKey = true, IsAutoId = true)]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(997, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "自定义非自增主键特性: ";
            // 
            // txt_primarykey
            // 
            this.txt_primarykey.Location = new System.Drawing.Point(1151, 90);
            this.txt_primarykey.Name = "txt_primarykey";
            this.txt_primarykey.Size = new System.Drawing.Size(224, 21);
            this.txt_primarykey.TabIndex = 19;
            this.txt_primarykey.Text = "[SqlField(IsPrimaryKey = true, IsAutoId = false)]";
            // 
            // TreeNode_ContextMenuStrip
            // 
            this.TreeNode_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成所有ToolStripMenuItem,
            this.预览生成ToolStripMenuItem,
            this.加载表ToolStripMenuItem});
            this.TreeNode_ContextMenuStrip.Name = "TreeNode_ContextMenuStrip";
            this.TreeNode_ContextMenuStrip.Size = new System.Drawing.Size(125, 70);
            // 
            // 生成所有ToolStripMenuItem
            // 
            this.生成所有ToolStripMenuItem.Name = "生成所有ToolStripMenuItem";
            this.生成所有ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.生成所有ToolStripMenuItem.Text = "生成所有";
            this.生成所有ToolStripMenuItem.Click += new System.EventHandler(this.生成所有ToolStripMenuItem_Click);
            // 
            // 预览生成ToolStripMenuItem
            // 
            this.预览生成ToolStripMenuItem.Name = "预览生成ToolStripMenuItem";
            this.预览生成ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.预览生成ToolStripMenuItem.Text = "预览生成";
            this.预览生成ToolStripMenuItem.Click += new System.EventHandler(this.预览生成ToolStripMenuItem_Click);
            // 
            // 加载表ToolStripMenuItem
            // 
            this.加载表ToolStripMenuItem.Name = "加载表ToolStripMenuItem";
            this.加载表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.加载表ToolStripMenuItem.Text = "加载表";
            this.加载表ToolStripMenuItem.Click += new System.EventHandler(this.加载表ToolStripMenuItem_Click);
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 749);
            this.Controls.Add(this.txt_primarykey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_autoprimarykey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_fieldattr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_classattr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_namespace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_baseclass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tv_LinkInfo);
            this.Controls.Add(this.txt_using);
            this.Controls.Add(this.label1);
            this.Name = "f_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "同城直播实体类生成器";
            this.Load += new System.EventHandler(this.f_main_Load);
            this.TreeNode_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_using;
        private System.Windows.Forms.TreeView tv_LinkInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_baseclass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_namespace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_classattr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fieldattr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_autoprimarykey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_primarykey;
        private System.Windows.Forms.ContextMenuStrip TreeNode_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 生成所有ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预览生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载表ToolStripMenuItem;
    }
}

