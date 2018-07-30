namespace Movie_rent.WinForms
{
    partial class DirectorForm
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
            this.btn_DirectorCancel = new System.Windows.Forms.Button();
            this.btn_DirectorOk = new System.Windows.Forms.Button();
            this.textBox_DirectorLname = new System.Windows.Forms.TextBox();
            this.textBox_DirectorFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DirectorCancel);
            this.groupBox1.Controls.Add(this.btn_DirectorOk);
            this.groupBox1.Controls.Add(this.textBox_DirectorLname);
            this.groupBox1.Controls.Add(this.textBox_DirectorFname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Director";
            // 
            // btn_DirectorCancel
            // 
            this.btn_DirectorCancel.Location = new System.Drawing.Point(7, 234);
            this.btn_DirectorCancel.Name = "btn_DirectorCancel";
            this.btn_DirectorCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_DirectorCancel.TabIndex = 15;
            this.btn_DirectorCancel.Text = "Cancel";
            this.btn_DirectorCancel.UseVisualStyleBackColor = true;
            // 
            // btn_DirectorOk
            // 
            this.btn_DirectorOk.Location = new System.Drawing.Point(322, 234);
            this.btn_DirectorOk.Name = "btn_DirectorOk";
            this.btn_DirectorOk.Size = new System.Drawing.Size(75, 23);
            this.btn_DirectorOk.TabIndex = 14;
            this.btn_DirectorOk.Text = "OK";
            this.btn_DirectorOk.UseVisualStyleBackColor = true;
            this.btn_DirectorOk.Click += new System.EventHandler(this.btn_DirectorOk_Click);
            // 
            // textBox_DirectorLname
            // 
            this.textBox_DirectorLname.Location = new System.Drawing.Point(297, 95);
            this.textBox_DirectorLname.Name = "textBox_DirectorLname";
            this.textBox_DirectorLname.Size = new System.Drawing.Size(100, 20);
            this.textBox_DirectorLname.TabIndex = 11;
            // 
            // textBox_DirectorFname
            // 
            this.textBox_DirectorFname.Location = new System.Drawing.Point(297, 62);
            this.textBox_DirectorFname.Name = "textBox_DirectorFname";
            this.textBox_DirectorFname.Size = new System.Drawing.Size(100, 20);
            this.textBox_DirectorFname.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "DirectorForm";
            this.Text = "Director Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DirectorCancel;
        private System.Windows.Forms.Button btn_DirectorOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DirectorLname;
        private System.Windows.Forms.TextBox textBox_DirectorFname;
    }
}