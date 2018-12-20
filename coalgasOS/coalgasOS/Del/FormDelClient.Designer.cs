namespace coalgasOS
{
    partial class FormDelClient
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelClientDel = new System.Windows.Forms.Button();
            this.buttonDelClientUpdata = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 57);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(688, 282);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // buttonDelClientDel
            // 
            this.buttonDelClientDel.Location = new System.Drawing.Point(541, 11);
            this.buttonDelClientDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelClientDel.Name = "buttonDelClientDel";
            this.buttonDelClientDel.Size = new System.Drawing.Size(75, 25);
            this.buttonDelClientDel.TabIndex = 2;
            this.buttonDelClientDel.Text = "确定删除";
            this.buttonDelClientDel.UseVisualStyleBackColor = true;
            this.buttonDelClientDel.Click += new System.EventHandler(this.buttonDelClientDel_Click);
            // 
            // buttonDelClientUpdata
            // 
            this.buttonDelClientUpdata.Location = new System.Drawing.Point(620, 11);
            this.buttonDelClientUpdata.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelClientUpdata.Name = "buttonDelClientUpdata";
            this.buttonDelClientUpdata.Size = new System.Drawing.Size(75, 25);
            this.buttonDelClientUpdata.TabIndex = 3;
            this.buttonDelClientUpdata.Text = "保存修改";
            this.buttonDelClientUpdata.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(11, 16);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 12);
            this.linkLabel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "提示：选择要删除的行,点击确定删除即可删除,支持同时删除多行。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "双击单元格输入新值即可修改,修改后自动保存,编号不能修改。";
            // 
            // FormDelClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 348);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonDelClientUpdata);
            this.Controls.Add(this.buttonDelClientDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDelClient";
            this.Text = "客户管理";
            this.Load += new System.EventHandler(this.FormDelClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelClientDel;
        private System.Windows.Forms.Button buttonDelClientUpdata;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}