namespace coalgasOS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewIntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewCoalgasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelCoalgasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelIntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelCoalgasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.费用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelClientPayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelSupplierPayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExecTopClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExecTopStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetUpdatePwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSwitchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetOutOsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTopDayNum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDataTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUserAA = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.SelToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.统计ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(584, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewIntoToolStripMenuItem,
            this.NewOutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.NewCoalgasToolStripMenuItem,
            this.NewClientToolStripMenuItem,
            this.NewStaffToolStripMenuItem,
            this.NewSupplierToolStripMenuItem});
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.NewToolStripMenuItem.Text = "新建(&A)";
            // 
            // NewIntoToolStripMenuItem
            // 
            this.NewIntoToolStripMenuItem.Name = "NewIntoToolStripMenuItem";
            this.NewIntoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewIntoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.NewIntoToolStripMenuItem.Text = "进货单";
            this.NewIntoToolStripMenuItem.Click += new System.EventHandler(this.NewIntoToolStripMenuItem_Click);
            // 
            // NewOutToolStripMenuItem
            // 
            this.NewOutToolStripMenuItem.Name = "NewOutToolStripMenuItem";
            this.NewOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.NewOutToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.NewOutToolStripMenuItem.Text = "售货单";
            this.NewOutToolStripMenuItem.Click += new System.EventHandler(this.NewOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // NewCoalgasToolStripMenuItem
            // 
            this.NewCoalgasToolStripMenuItem.Name = "NewCoalgasToolStripMenuItem";
            this.NewCoalgasToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.NewCoalgasToolStripMenuItem.Text = "商品(煤气)";
            this.NewCoalgasToolStripMenuItem.Click += new System.EventHandler(this.NewCoalgasToolStripMenuItem_Click);
            // 
            // NewClientToolStripMenuItem
            // 
            this.NewClientToolStripMenuItem.Name = "NewClientToolStripMenuItem";
            this.NewClientToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.NewClientToolStripMenuItem.Text = "客户";
            this.NewClientToolStripMenuItem.Click += new System.EventHandler(this.NewClientToolStripMenuItem_Click);
            // 
            // NewStaffToolStripMenuItem
            // 
            this.NewStaffToolStripMenuItem.Name = "NewStaffToolStripMenuItem";
            this.NewStaffToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.NewStaffToolStripMenuItem.Text = "员工";
            this.NewStaffToolStripMenuItem.Click += new System.EventHandler(this.NewStaffToolStripMenuItem_Click);
            // 
            // NewSupplierToolStripMenuItem
            // 
            this.NewSupplierToolStripMenuItem.Name = "NewSupplierToolStripMenuItem";
            this.NewSupplierToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.NewSupplierToolStripMenuItem.Text = "供应商";
            this.NewSupplierToolStripMenuItem.Click += new System.EventHandler(this.NewSupplierToolStripMenuItem_Click_1);
            // 
            // SelToolStripMenuItem
            // 
            this.SelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelCoalgasToolStripMenuItem1,
            this.SelClientToolStripMenuItem1,
            this.SelStaffToolStripMenuItem,
            this.SelSupplierToolStripMenuItem,
            this.toolStripMenuItem2,
            this.SelIntoToolStripMenuItem,
            this.SelOutToolStripMenuItem});
            this.SelToolStripMenuItem.Name = "SelToolStripMenuItem";
            this.SelToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.SelToolStripMenuItem.Text = "查询(&S)";
            // 
            // SelCoalgasToolStripMenuItem1
            // 
            this.SelCoalgasToolStripMenuItem1.Name = "SelCoalgasToolStripMenuItem1";
            this.SelCoalgasToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.SelCoalgasToolStripMenuItem1.Text = "商品(煤气)";
            this.SelCoalgasToolStripMenuItem1.Click += new System.EventHandler(this.SelCoalgasToolStripMenuItem1_Click);
            // 
            // SelClientToolStripMenuItem1
            // 
            this.SelClientToolStripMenuItem1.Name = "SelClientToolStripMenuItem1";
            this.SelClientToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.SelClientToolStripMenuItem1.Text = "客户";
            this.SelClientToolStripMenuItem1.Click += new System.EventHandler(this.SelClientToolStripMenuItem1_Click);
            // 
            // SelStaffToolStripMenuItem
            // 
            this.SelStaffToolStripMenuItem.Name = "SelStaffToolStripMenuItem";
            this.SelStaffToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.SelStaffToolStripMenuItem.Text = "员工";
            this.SelStaffToolStripMenuItem.Click += new System.EventHandler(this.SelStaffToolStripMenuItem_Click);
            // 
            // SelSupplierToolStripMenuItem
            // 
            this.SelSupplierToolStripMenuItem.Name = "SelSupplierToolStripMenuItem";
            this.SelSupplierToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.SelSupplierToolStripMenuItem.Text = "供应商";
            this.SelSupplierToolStripMenuItem.Click += new System.EventHandler(this.SelSupplierToolStripMenuItem_Click);
            // 
            // SelIntoToolStripMenuItem
            // 
            this.SelIntoToolStripMenuItem.Name = "SelIntoToolStripMenuItem";
            this.SelIntoToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.SelIntoToolStripMenuItem.Text = "进货情况";
            this.SelIntoToolStripMenuItem.Click += new System.EventHandler(this.SelIntoToolStripMenuItem_Click);
            // 
            // SelOutToolStripMenuItem
            // 
            this.SelOutToolStripMenuItem.Name = "SelOutToolStripMenuItem";
            this.SelOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SelOutToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.SelOutToolStripMenuItem.Text = "售货情况";
            this.SelOutToolStripMenuItem.Click += new System.EventHandler(this.SelOutToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelCoalgasToolStripMenuItem,
            this.DelClientToolStripMenuItem,
            this.DelSupplierToolStripMenuItem,
            this.DelStaffToolStripMenuItem,
            this.toolStripMenuItem3,
            this.费用ToolStripMenuItem});
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.DelToolStripMenuItem.Text = "管理(&D)";
            // 
            // DelCoalgasToolStripMenuItem
            // 
            this.DelCoalgasToolStripMenuItem.Name = "DelCoalgasToolStripMenuItem";
            this.DelCoalgasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.DelCoalgasToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.DelCoalgasToolStripMenuItem.Text = "商品(煤气)";
            this.DelCoalgasToolStripMenuItem.Click += new System.EventHandler(this.DelCoalgasToolStripMenuItem_Click);
            // 
            // DelClientToolStripMenuItem
            // 
            this.DelClientToolStripMenuItem.Name = "DelClientToolStripMenuItem";
            this.DelClientToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.DelClientToolStripMenuItem.Text = "客户";
            this.DelClientToolStripMenuItem.Click += new System.EventHandler(this.DelClientToolStripMenuItem_Click);
            // 
            // DelStaffToolStripMenuItem
            // 
            this.DelStaffToolStripMenuItem.Name = "DelStaffToolStripMenuItem";
            this.DelStaffToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.DelStaffToolStripMenuItem.Text = "员工";
            this.DelStaffToolStripMenuItem.Click += new System.EventHandler(this.DelStaffToolStripMenuItem_Click);
            // 
            // DelSupplierToolStripMenuItem
            // 
            this.DelSupplierToolStripMenuItem.Name = "DelSupplierToolStripMenuItem";
            this.DelSupplierToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.DelSupplierToolStripMenuItem.Text = "供应商";
            this.DelSupplierToolStripMenuItem.Click += new System.EventHandler(this.DelSupplierToolStripMenuItem_Click);
            // 
            // 费用ToolStripMenuItem
            // 
            this.费用ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelClientPayToolStripMenuItem,
            this.DelSupplierPayToolStripMenuItem});
            this.费用ToolStripMenuItem.Name = "费用ToolStripMenuItem";
            this.费用ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.费用ToolStripMenuItem.Text = "费用";
            // 
            // DelClientPayToolStripMenuItem
            // 
            this.DelClientPayToolStripMenuItem.Name = "DelClientPayToolStripMenuItem";
            this.DelClientPayToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.DelClientPayToolStripMenuItem.Text = "客户费用结算";
            this.DelClientPayToolStripMenuItem.Click += new System.EventHandler(this.DelClientPayToolStripMenuItem_Click);
            // 
            // DelSupplierPayToolStripMenuItem
            // 
            this.DelSupplierPayToolStripMenuItem.Name = "DelSupplierPayToolStripMenuItem";
            this.DelSupplierPayToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.DelSupplierPayToolStripMenuItem.Text = "供应商费用结算";
            this.DelSupplierPayToolStripMenuItem.Click += new System.EventHandler(this.DelSupplierPayToolStripMenuItem_Click);
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExecTopClientToolStripMenuItem,
            this.ExecTopStaffToolStripMenuItem});
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.统计ToolStripMenuItem.Text = "统计(&F)";
            // 
            // ExecTopClientToolStripMenuItem
            // 
            this.ExecTopClientToolStripMenuItem.Name = "ExecTopClientToolStripMenuItem";
            this.ExecTopClientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.ExecTopClientToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ExecTopClientToolStripMenuItem.Text = "员工业绩榜";
            this.ExecTopClientToolStripMenuItem.Click += new System.EventHandler(this.ExecTopStaffToolStripMenuItem_Click);
            // 
            // ExecTopStaffToolStripMenuItem
            // 
            this.ExecTopStaffToolStripMenuItem.Name = "ExecTopStaffToolStripMenuItem";
            this.ExecTopStaffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.ExecTopStaffToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ExecTopStaffToolStripMenuItem.Text = "客户用气榜";
            this.ExecTopStaffToolStripMenuItem.Click += new System.EventHandler(this.ExecTopClientToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetUpdatePwToolStripMenuItem,
            this.SetSwitchUserToolStripMenuItem,
            this.SetOutOsToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.设置ToolStripMenuItem.Text = "设置(&G)";
            // 
            // SetUpdatePwToolStripMenuItem
            // 
            this.SetUpdatePwToolStripMenuItem.Name = "SetUpdatePwToolStripMenuItem";
            this.SetUpdatePwToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.SetUpdatePwToolStripMenuItem.Text = "修改密码";
            this.SetUpdatePwToolStripMenuItem.Click += new System.EventHandler(this.SetUpdatePwToolStripMenuItem_Click);
            // 
            // SetSwitchUserToolStripMenuItem
            // 
            this.SetSwitchUserToolStripMenuItem.Name = "SetSwitchUserToolStripMenuItem";
            this.SetSwitchUserToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.SetSwitchUserToolStripMenuItem.Text = "切换账号";
            this.SetSwitchUserToolStripMenuItem.Click += new System.EventHandler(this.SetSwitchUserToolStripMenuItem_Click);
            // 
            // SetOutOsToolStripMenuItem
            // 
            this.SetOutOsToolStripMenuItem.Name = "SetOutOsToolStripMenuItem";
            this.SetOutOsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.SetOutOsToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.SetOutOsToolStripMenuItem.Text = "退出系统";
            this.SetOutOsToolStripMenuItem.Click += new System.EventHandler(this.SetOutOsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.aboutToolStripMenuItem.Text = "关于(&H)";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTopDayNum
            // 
            this.labelTopDayNum.BackColor = System.Drawing.Color.Transparent;
            this.labelTopDayNum.Font = new System.Drawing.Font("Segoe Marker", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopDayNum.Location = new System.Drawing.Point(6, 25);
            this.labelTopDayNum.Name = "labelTopDayNum";
            this.labelTopDayNum.Size = new System.Drawing.Size(181, 66);
            this.labelTopDayNum.TabIndex = 3;
            this.labelTopDayNum.Text = "6";
            this.labelTopDayNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelTopDayNum);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(210, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "今日销量";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDataTime,
            this.toolStripStatusLabelUserName,
            this.toolStripStatusLabelUserAA});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 24);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDataTime
            // 
            this.toolStripStatusLabelDataTime.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabelDataTime.Name = "toolStripStatusLabelDataTime";
            this.toolStripStatusLabelDataTime.Size = new System.Drawing.Size(143, 19);
            this.toolStripStatusLabelDataTime.Text = "2017/12/12 00:00:00";
            // 
            // toolStripStatusLabelUserName
            // 
            this.toolStripStatusLabelUserName.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabelUserName.Name = "toolStripStatusLabelUserName";
            this.toolStripStatusLabelUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabelUserName.Size = new System.Drawing.Size(332, 19);
            this.toolStripStatusLabelUserName.Spring = true;
            this.toolStripStatusLabelUserName.Text = "xxx,欢迎您";
            // 
            // toolStripStatusLabelUserAA
            // 
            this.toolStripStatusLabelUserAA.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabelUserAA.Name = "toolStripStatusLabelUserAA";
            this.toolStripStatusLabelUserAA.Size = new System.Drawing.Size(94, 19);
            this.toolStripStatusLabelUserAA.Text = "当前权限: 读写";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(211, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 375);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "煤气公司送气管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewIntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewCoalgasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelCoalgasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SelClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SelStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelIntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelCoalgasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExecTopStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExecTopClientToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 费用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelClientPayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelSupplierPayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label labelTopDayNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDataTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserAA;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetUpdatePwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetSwitchUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetOutOsToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

    }
}

