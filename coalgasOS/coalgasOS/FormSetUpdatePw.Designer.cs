namespace coalgasOS
{
    partial class FormSetUpdatePw
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
            this.buttonOkSetUpdatePw = new System.Windows.Forms.Button();
            this.textBoxSetUpdatePw3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSetUpdatePw2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSetUpdatePw1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOkSetUpdatePw
            // 
            this.buttonOkSetUpdatePw.Location = new System.Drawing.Point(62, 249);
            this.buttonOkSetUpdatePw.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOkSetUpdatePw.Name = "buttonOkSetUpdatePw";
            this.buttonOkSetUpdatePw.Size = new System.Drawing.Size(69, 33);
            this.buttonOkSetUpdatePw.TabIndex = 17;
            this.buttonOkSetUpdatePw.Text = "确定添加";
            this.buttonOkSetUpdatePw.UseVisualStyleBackColor = true;
            this.buttonOkSetUpdatePw.Click += new System.EventHandler(this.buttonOkSetUpdatePw_Click);
            // 
            // textBoxSetUpdatePw3
            // 
            this.textBoxSetUpdatePw3.Location = new System.Drawing.Point(25, 177);
            this.textBoxSetUpdatePw3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSetUpdatePw3.Name = "textBoxSetUpdatePw3";
            this.textBoxSetUpdatePw3.PasswordChar = '*';
            this.textBoxSetUpdatePw3.Size = new System.Drawing.Size(164, 21);
            this.textBoxSetUpdatePw3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "确认密码*";
            // 
            // textBoxSetUpdatePw2
            // 
            this.textBoxSetUpdatePw2.Location = new System.Drawing.Point(25, 112);
            this.textBoxSetUpdatePw2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSetUpdatePw2.Name = "textBoxSetUpdatePw2";
            this.textBoxSetUpdatePw2.PasswordChar = '*';
            this.textBoxSetUpdatePw2.Size = new System.Drawing.Size(164, 21);
            this.textBoxSetUpdatePw2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "新密码(6-20位)*";
            // 
            // textBoxSetUpdatePw1
            // 
            this.textBoxSetUpdatePw1.Location = new System.Drawing.Point(25, 46);
            this.textBoxSetUpdatePw1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSetUpdatePw1.Name = "textBoxSetUpdatePw1";
            this.textBoxSetUpdatePw1.PasswordChar = '*';
            this.textBoxSetUpdatePw1.Size = new System.Drawing.Size(164, 21);
            this.textBoxSetUpdatePw1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "旧密码*";
            // 
            // FormSetUpdatePw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 303);
            this.Controls.Add(this.buttonOkSetUpdatePw);
            this.Controls.Add(this.textBoxSetUpdatePw3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSetUpdatePw2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSetUpdatePw1);
            this.Controls.Add(this.label3);
            this.Name = "FormSetUpdatePw";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOkSetUpdatePw;
        private System.Windows.Forms.TextBox textBoxSetUpdatePw3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSetUpdatePw2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSetUpdatePw1;
        private System.Windows.Forms.Label label3;

    }
}