namespace coalgasOS
{
    partial class FormNewClient
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
            this.textBoxNewClientID = new System.Windows.Forms.TextBox();
            this.textBoxNewClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewClientPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewClientAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewClientNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOkNewClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户ID*";
            // 
            // textBoxNewClientID
            // 
            this.textBoxNewClientID.Location = new System.Drawing.Point(22, 34);
            this.textBoxNewClientID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewClientID.Name = "textBoxNewClientID";
            this.textBoxNewClientID.Size = new System.Drawing.Size(164, 21);
            this.textBoxNewClientID.TabIndex = 1;
            // 
            // textBoxNewClientName
            // 
            this.textBoxNewClientName.Location = new System.Drawing.Point(22, 94);
            this.textBoxNewClientName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewClientName.Name = "textBoxNewClientName";
            this.textBoxNewClientName.Size = new System.Drawing.Size(164, 21);
            this.textBoxNewClientName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户名字*";
            // 
            // textBoxNewClientPhone
            // 
            this.textBoxNewClientPhone.Location = new System.Drawing.Point(22, 156);
            this.textBoxNewClientPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewClientPhone.Name = "textBoxNewClientPhone";
            this.textBoxNewClientPhone.Size = new System.Drawing.Size(164, 21);
            this.textBoxNewClientPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "客户电话*";
            // 
            // textBoxNewClientAdd
            // 
            this.textBoxNewClientAdd.Location = new System.Drawing.Point(22, 222);
            this.textBoxNewClientAdd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewClientAdd.Name = "textBoxNewClientAdd";
            this.textBoxNewClientAdd.Size = new System.Drawing.Size(164, 21);
            this.textBoxNewClientAdd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "客户地址*";
            // 
            // textBoxNewClientNote
            // 
            this.textBoxNewClientNote.Location = new System.Drawing.Point(22, 287);
            this.textBoxNewClientNote.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewClientNote.Name = "textBoxNewClientNote";
            this.textBoxNewClientNote.Size = new System.Drawing.Size(164, 21);
            this.textBoxNewClientNote.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "客户备注";
            // 
            // buttonOkNewClient
            // 
            this.buttonOkNewClient.Location = new System.Drawing.Point(65, 353);
            this.buttonOkNewClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOkNewClient.Name = "buttonOkNewClient";
            this.buttonOkNewClient.Size = new System.Drawing.Size(75, 25);
            this.buttonOkNewClient.TabIndex = 10;
            this.buttonOkNewClient.Text = "确定添加";
            this.buttonOkNewClient.UseVisualStyleBackColor = true;
            this.buttonOkNewClient.Click += new System.EventHandler(this.buttonOkNewClient_Click);
            // 
            // FormNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 399);
            this.Controls.Add(this.buttonOkNewClient);
            this.Controls.Add(this.textBoxNewClientNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNewClientAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNewClientPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewClientID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNewClient";
            this.Text = "新建客户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewClientID;
        private System.Windows.Forms.TextBox textBoxNewClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewClientPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewClientAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewClientNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOkNewClient;
    }
}