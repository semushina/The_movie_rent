namespace Movie_rent.WinForms
{
    partial class ClientForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ClientCancel = new System.Windows.Forms.Button();
            this.btn_ClientOk = new System.Windows.Forms.Button();
            this.textBox_ClientTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ClientLname = new System.Windows.Forms.TextBox();
            this.textBox_ClientFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ClientCancel);
            this.groupBox1.Controls.Add(this.btn_ClientOk);
            this.groupBox1.Controls.Add(this.textBox_ClientTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_ClientLname);
            this.groupBox1.Controls.Add(this.textBox_ClientFname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // btn_ClientCancel
            // 
            this.btn_ClientCancel.Location = new System.Drawing.Point(7, 232);
            this.btn_ClientCancel.Name = "btn_ClientCancel";
            this.btn_ClientCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_ClientCancel.TabIndex = 7;
            this.btn_ClientCancel.Text = "Cancel";
            this.btn_ClientCancel.UseVisualStyleBackColor = true;
            // 
            // btn_ClientOk
            // 
            this.btn_ClientOk.Location = new System.Drawing.Point(322, 232);
            this.btn_ClientOk.Name = "btn_ClientOk";
            this.btn_ClientOk.Size = new System.Drawing.Size(75, 23);
            this.btn_ClientOk.TabIndex = 6;
            this.btn_ClientOk.Text = "OK";
            this.btn_ClientOk.UseVisualStyleBackColor = true;
            this.btn_ClientOk.Click += new System.EventHandler(this.btn_ClientOk_Click);
            // 
            // textBox_ClientTel
            // 
            this.textBox_ClientTel.Location = new System.Drawing.Point(297, 129);
            this.textBox_ClientTel.Name = "textBox_ClientTel";
            this.textBox_ClientTel.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClientTel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tel.";
            // 
            // textBox_ClientLname
            // 
            this.textBox_ClientLname.Location = new System.Drawing.Point(297, 93);
            this.textBox_ClientLname.Name = "textBox_ClientLname";
            this.textBox_ClientLname.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClientLname.TabIndex = 3;
            // 
            // textBox_ClientFname
            // 
            this.textBox_ClientFname.Location = new System.Drawing.Point(297, 60);
            this.textBox_ClientFname.Name = "textBox_ClientFname";
            this.textBox_ClientFname.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClientFname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ClientCancel;
        private System.Windows.Forms.Button btn_ClientOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ClientTel;
        private System.Windows.Forms.TextBox textBox_ClientLname;
        private System.Windows.Forms.TextBox textBox_ClientFname;
    }
}