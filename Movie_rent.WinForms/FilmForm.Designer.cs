namespace Movie_rent.WinForms
{
    partial class FilmForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.btn_StaffCancel = new System.Windows.Forms.Button();
            this.btn_FilmOk = new System.Windows.Forms.Button();
            this.textBox_FilmName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_FilmAddActors = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_FilmDuraction = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FilmYear = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FilmDuraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FilmYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Duration";
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
            // btn_FilmOk
            // 
            this.btn_FilmOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_FilmOk.Location = new System.Drawing.Point(322, 232);
            this.btn_FilmOk.Name = "btn_FilmOk";
            this.btn_FilmOk.Size = new System.Drawing.Size(75, 23);
            this.btn_FilmOk.TabIndex = 6;
            this.btn_FilmOk.Text = "OK";
            this.btn_FilmOk.UseVisualStyleBackColor = true;
            this.btn_FilmOk.Click += new System.EventHandler(this.btn_FilmOk_Click);
            // 
            // textBox_FilmName
            // 
            this.textBox_FilmName.Location = new System.Drawing.Point(297, 60);
            this.textBox_FilmName.Name = "textBox_FilmName";
            this.textBox_FilmName.Size = new System.Drawing.Size(100, 20);
            this.textBox_FilmName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_FilmAddActors);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_FilmDuraction);
            this.groupBox1.Controls.Add(this.numericUpDown_FilmYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_StaffCancel);
            this.groupBox1.Controls.Add(this.btn_FilmOk);
            this.groupBox1.Controls.Add(this.textBox_FilmName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Film";
            // 
            // btn_FilmAddActors
            // 
            this.btn_FilmAddActors.Location = new System.Drawing.Point(371, 165);
            this.btn_FilmAddActors.Name = "btn_FilmAddActors";
            this.btn_FilmAddActors.Size = new System.Drawing.Size(26, 23);
            this.btn_FilmAddActors.TabIndex = 17;
            this.btn_FilmAddActors.Text = "...";
            this.btn_FilmAddActors.UseVisualStyleBackColor = true;
            this.btn_FilmAddActors.Click += new System.EventHandler(this.btn_FilmAddActors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Actors";
            // 
            // numericUpDown_FilmDuraction
            // 
            this.numericUpDown_FilmDuraction.Location = new System.Drawing.Point(297, 130);
            this.numericUpDown_FilmDuraction.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_FilmDuraction.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_FilmDuraction.Name = "numericUpDown_FilmDuraction";
            this.numericUpDown_FilmDuraction.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_FilmDuraction.TabIndex = 14;
            this.numericUpDown_FilmDuraction.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDown_FilmYear
            // 
            this.numericUpDown_FilmYear.Location = new System.Drawing.Point(297, 94);
            this.numericUpDown_FilmYear.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numericUpDown_FilmYear.Minimum = new decimal(new int[] {
            1895,
            0,
            0,
            0});
            this.numericUpDown_FilmYear.Name = "numericUpDown_FilmYear";
            this.numericUpDown_FilmYear.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_FilmYear.TabIndex = 13;
            this.numericUpDown_FilmYear.Value = new decimal(new int[] {
            1895,
            0,
            0,
            0});
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilmForm";
            this.Text = "Film Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FilmDuraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FilmYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_StaffCancel;
        private System.Windows.Forms.Button btn_FilmOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_FilmAddActors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_FilmYear;
        private System.Windows.Forms.NumericUpDown numericUpDown_FilmDuraction;
        private System.Windows.Forms.TextBox textBox_FilmName;
    }
}