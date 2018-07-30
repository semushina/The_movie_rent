namespace Movie_rent.WinForms
{
    partial class ActorForm
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
            this.btn_ActorCancel = new System.Windows.Forms.Button();
            this.btn_ActorOk = new System.Windows.Forms.Button();
            this.textBox_ActorLname = new System.Windows.Forms.TextBox();
            this.textBox_ActorFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ActorCancel
            // 
            this.btn_ActorCancel.Location = new System.Drawing.Point(7, 232);
            this.btn_ActorCancel.Name = "btn_ActorCancel";
            this.btn_ActorCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_ActorCancel.TabIndex = 7;
            this.btn_ActorCancel.Text = "Cancel";
            this.btn_ActorCancel.UseVisualStyleBackColor = true;
            // 
            // btn_ActorOk
            // 
            this.btn_ActorOk.Location = new System.Drawing.Point(322, 232);
            this.btn_ActorOk.Name = "btn_ActorOk";
            this.btn_ActorOk.Size = new System.Drawing.Size(75, 23);
            this.btn_ActorOk.TabIndex = 6;
            this.btn_ActorOk.Text = "OK";
            this.btn_ActorOk.UseVisualStyleBackColor = true;
            this.btn_ActorOk.Click += new System.EventHandler(this.btn_ActorOk_Click);
            // 
            // textBox_ActorLname
            // 
            this.textBox_ActorLname.Location = new System.Drawing.Point(297, 93);
            this.textBox_ActorLname.Name = "textBox_ActorLname";
            this.textBox_ActorLname.Size = new System.Drawing.Size(100, 20);
            this.textBox_ActorLname.TabIndex = 3;
            // 
            // textBox_ActorFname
            // 
            this.textBox_ActorFname.Location = new System.Drawing.Point(297, 60);
            this.textBox_ActorFname.Name = "textBox_ActorFname";
            this.textBox_ActorFname.Size = new System.Drawing.Size(100, 20);
            this.textBox_ActorFname.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ActorCancel);
            this.groupBox1.Controls.Add(this.btn_ActorOk);
            this.groupBox1.Controls.Add(this.textBox_ActorLname);
            this.groupBox1.Controls.Add(this.textBox_ActorFname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actor";
            // 
            // ActorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "ActorForm";
            this.Text = "Actor Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ActorCancel;
        private System.Windows.Forms.Button btn_ActorOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ActorLname;
        private System.Windows.Forms.TextBox textBox_ActorFname;
    }
}