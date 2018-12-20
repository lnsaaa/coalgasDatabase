namespace coalgasOS
{
    partial class FormDelStaff
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
            this.buttonDelStaffDel = new System.Windows.Forms.Button();
            this.buttonDelStaffUpdata = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // buttonDelStaffDel
            // 
            this.buttonDelStaffDel.Location = new System.Drawing.Point(541, 11);
            this.buttonDelStaffDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelStaffDel.Name = "buttonDelStaffDel";
            this.buttonDelStaffDel.Size = new System.Drawing.Size(75, 25);
            this.buttonDelStaffDel.TabIndex = 5;
            this.buttonDelStaffDel.Text = "确认删除";
            this.buttonDelStaffDel.UseVisualStyleBackColor = true;
            this.buttonDelStaffDel.Click += new System.EventHandler(this.buttonDelStaffDel_Click);
            // 
            // buttonDelStaffUpdata
            // 
            this.buttonDelStaffUpdata.Location = new System.Drawing.Point(620, 11);
            this.buttonDelStaffUpdata.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelStaffUpdata.Name = "buttonDelStaffUpdata";
            this.buttonDelStaffUpdata.Size = new System.Drawing.Size(75, 25);
            this.buttonDelStaffUpdata.TabIndex = 6;
            this.buttonDelStaffUpdata.Text = "保存修改";
            this.buttonDelStaffUpdata.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "双击单元格输入新值即可修改,修改后自动保存,编号不能修改。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "提示：选择要删除的行,点击确定删除即可删除,支持同时删除多行。";
            // 
            // FormDelStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 348);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelStaffUpdata);
            this.Controls.Add(this.buttonDelStaffDel);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDelStaff";
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.FormDelStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDelStaffDel;
        private System.Windows.Forms.Button buttonDelStaffUpdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}