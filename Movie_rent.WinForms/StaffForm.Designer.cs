namespace Movie_rent.WinForms
{
    partial class StaffForm
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
            this.textBox_StaffPassword = new System.Windows.Forms.TextBox();
            this.textBox_StaffLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Staff = new System.Windows.Forms.NumericUpDown();
            this.btn_StaffCancel = new System.Windows.Forms.Button();
            this.btn_StaffOk = new System.Windows.Forms.Button();
            this.textBox_StaffLname = new System.Windows.Forms.TextBox();
            this.textBox_StaffFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_StaffPassword);
            this.groupBox1.Controls.Add(this.textBox_StaffLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_Staff);
            this.groupBox1.Controls.Add(this.btn_StaffCancel);
            this.groupBox1.Controls.Add(this.btn_StaffOk);
            this.groupBox1.Controls.Add(this.textBox_StaffLname);
            this.groupBox1.Controls.Add(this.textBox_StaffFname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            // 
            // textBox_StaffPassword
            // 
            this.textBox_StaffPassword.Location = new System.Drawing.Point(297, 186);
            this.textBox_StaffPassword.Name = "textBox_StaffPassword";
            this.textBox_StaffPassword.Size = new System.Drawing.Size(100, 20);
            this.textBox_StaffPassword.TabIndex = 13;
            // 
            // textBox_StaffLogin
            // 
            this.textBox_StaffLogin.Location = new System.Drawing.Point(297, 153);
            this.textBox_StaffLogin.Name = "textBox_StaffLogin";
            this.textBox_StaffLogin.Size = new System.Drawing.Size(100, 20);
            this.textBox_StaffLogin.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type";
            // 
            // numericUpDown_Staff
            // 
            this.numericUpDown_Staff.Location = new System.Drawing.Point(297, 120);
            this.numericUpDown_Staff.Name = "numericUpDown_Staff";
            this.numericUpDown_Staff.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_Staff.TabIndex = 8;
            this.numericUpDown_Staff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_StaffCancel
            // 
            this.btn_StaffCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_StaffCancel.Location = new System.Drawing.Point(7, 232);
            this.btn_StaffCancel.Name = "btn_StaffCancel";
            this.btn_StaffCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_StaffCancel.TabIndex = 7;
            this.btn_StaffCancel.Text = "Cancel";
            this.btn_StaffCancel.UseVisualStyleBackColor = true;
            // 
            // btn_StaffOk
            // 
            this.btn_StaffOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_StaffOk.Location = new System.Drawing.Point(322, 232);
            this.btn_StaffOk.Name = "btn_StaffOk";
            this.btn_StaffOk.Size = new System.Drawing.Size(75, 23);
            this.btn_StaffOk.TabIndex = 6;
            this.btn_StaffOk.Text = "OK";
            this.btn_StaffOk.UseVisualStyleBackColor = true;
            // 
            // textBox_StaffLname
            // 
            this.textBox_StaffLname.Location = new System.Drawing.Point(297, 93);
            this.textBox_StaffLname.Name = "textBox_StaffLname";
            this.textBox_StaffLname.Size = new System.Drawing.Size(100, 20);
            this.textBox_StaffLname.TabIndex = 3;
            // 
            // textBox_StaffFname
            // 
            this.textBox_StaffFname.Location = new System.Drawing.Point(297, 60);
            this.textBox_StaffFname.Name = "textBox_StaffFname";
            this.textBox_StaffFname.Size = new System.Drawing.Size(100, 20);
            this.textBox_StaffFname.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(199, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.TextBox textBox_StaffPassword;
        protected internal System.Windows.Forms.TextBox textBox_StaffLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_StaffCancel;
        private System.Windows.Forms.Button btn_StaffOk;
        protected internal System.Windows.Forms.TextBox textBox_StaffLname;
        protected internal System.Windows.Forms.TextBox textBox_StaffFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.NumericUpDown numericUpDown_Staff;
    }
}