namespace coalgasOS
{
    partial class FormDelClientPay
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOkPay = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "提示：选择要结账的行,点击确定结账即可结账,支持同时结账多行。";
            // 
            // buttonOkPay
            // 
            this.buttonOkPay.Location = new System.Drawing.Point(620, 11);
            this.buttonOkPay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOkPay.Name = "buttonOkPay";
            this.buttonOkPay.Size = new System.Drawing.Size(75, 25);
            this.buttonOkPay.TabIndex = 13;
            this.buttonOkPay.Text = "确定结账";
            this.buttonOkPay.UseVisualStyleBackColor = true;
            this.buttonOkPay.Click += new System.EventHandler(this.buttonOkPay_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(10, 51);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(688, 282);
            this.dataGridView.TabIndex = 12;
            // 
            // FormDelClientPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 348);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOkPay);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDelClientPay";
            this.Text = "客户费用结算";
            this.Load += new System.EventHandler(this.FormDelClientPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOkPay;
        private System.Windows.Forms.DataGridView dataGridView;

    }
}