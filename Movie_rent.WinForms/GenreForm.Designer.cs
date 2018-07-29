namespace Movie_rent.WinForms
{
    partial class GenreForm
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
            this.btn_GenreCancel = new System.Windows.Forms.Button();
            this.textBox_GenreName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_GenreOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GenreCancel
            // 
            this.btn_GenreCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_GenreCancel.Location = new System.Drawing.Point(7, 232);
            this.btn_GenreCancel.Name = "btn_GenreCancel";
            this.btn_GenreCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_GenreCancel.TabIndex = 7;
            this.btn_GenreCancel.Text = "Cancel";
            this.btn_GenreCancel.UseVisualStyleBackColor = true;
            // 
            // textBox_GenreName
            // 
            this.textBox_GenreName.Location = new System.Drawing.Point(297, 60);
            this.textBox_GenreName.Name = "textBox_GenreName";
            this.textBox_GenreName.Size = new System.Drawing.Size(100, 20);
            this.textBox_GenreName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_GenreCancel);
            this.groupBox1.Controls.Add(this.btn_GenreOk);
            this.groupBox1.Controls.Add(this.textBox_GenreName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            // 
            // btn_GenreOk
            // 
            this.btn_GenreOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_GenreOk.Location = new System.Drawing.Point(322, 232);
            this.btn_GenreOk.Name = "btn_GenreOk";
            this.btn_GenreOk.Size = new System.Drawing.Size(75, 23);
            this.btn_GenreOk.TabIndex = 6;
            this.btn_GenreOk.Text = "OK";
            this.btn_GenreOk.UseVisualStyleBackColor = true;
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "GenreForm";
            this.Text = "GenreForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GenreCancel;
        protected internal System.Windows.Forms.TextBox textBox_GenreName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GenreOk;
    }
}