namespace Movie_rent.WinForms
{
    partial class OrderForm
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
            this.btn_OrderCancel = new System.Windows.Forms.Button();
            this.btn_OrderOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_OrderCost = new System.Windows.Forms.NumericUpDown();
            this.btn_OrderClient = new System.Windows.Forms.Button();
            this.textBox_OrderClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_OrderFilm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_OrderFilm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OrderCost)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OrderCancel
            // 
            this.btn_OrderCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_OrderCancel.Location = new System.Drawing.Point(7, 232);
            this.btn_OrderCancel.Name = "btn_OrderCancel";
            this.btn_OrderCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_OrderCancel.TabIndex = 7;
            this.btn_OrderCancel.Text = "Cancel";
            this.btn_OrderCancel.UseVisualStyleBackColor = true;
            // 
            // btn_OrderOk
            // 
            this.btn_OrderOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OrderOk.Location = new System.Drawing.Point(322, 232);
            this.btn_OrderOk.Name = "btn_OrderOk";
            this.btn_OrderOk.Size = new System.Drawing.Size(75, 23);
            this.btn_OrderOk.TabIndex = 6;
            this.btn_OrderOk.Text = "OK";
            this.btn_OrderOk.UseVisualStyleBackColor = true;
            this.btn_OrderOk.Click += new System.EventHandler(this.btn_OrderOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_OrderCost);
            this.groupBox1.Controls.Add(this.btn_OrderClient);
            this.groupBox1.Controls.Add(this.textBox_OrderClient);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_OrderFilm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_OrderCancel);
            this.groupBox1.Controls.Add(this.btn_OrderOk);
            this.groupBox1.Controls.Add(this.textBox_OrderFilm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // numericUpDown_OrderCost
            // 
            this.numericUpDown_OrderCost.Location = new System.Drawing.Point(255, 165);
            this.numericUpDown_OrderCost.Name = "numericUpDown_OrderCost";
            this.numericUpDown_OrderCost.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_OrderCost.TabIndex = 22;
            this.numericUpDown_OrderCost.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btn_OrderClient
            // 
            this.btn_OrderClient.Location = new System.Drawing.Point(371, 24);
            this.btn_OrderClient.Name = "btn_OrderClient";
            this.btn_OrderClient.Size = new System.Drawing.Size(26, 23);
            this.btn_OrderClient.TabIndex = 21;
            this.btn_OrderClient.Text = "...";
            this.btn_OrderClient.UseVisualStyleBackColor = true;
            this.btn_OrderClient.Click += new System.EventHandler(this.btn_OrderClient_Click);
            // 
            // textBox_OrderClient
            // 
            this.textBox_OrderClient.Location = new System.Drawing.Point(255, 26);
            this.textBox_OrderClient.Name = "textBox_OrderClient";
            this.textBox_OrderClient.ReadOnly = true;
            this.textBox_OrderClient.Size = new System.Drawing.Size(100, 20);
            this.textBox_OrderClient.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Client";
            // 
            // btn_OrderFilm
            // 
            this.btn_OrderFilm.Location = new System.Drawing.Point(371, 58);
            this.btn_OrderFilm.Name = "btn_OrderFilm";
            this.btn_OrderFilm.Size = new System.Drawing.Size(26, 23);
            this.btn_OrderFilm.TabIndex = 18;
            this.btn_OrderFilm.Text = "...";
            this.btn_OrderFilm.UseVisualStyleBackColor = true;
            this.btn_OrderFilm.Click += new System.EventHandler(this.btn_OrderFilm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cost";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(255, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Return Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data";
            // 
            // textBox_OrderFilm
            // 
            this.textBox_OrderFilm.Location = new System.Drawing.Point(255, 60);
            this.textBox_OrderFilm.Name = "textBox_OrderFilm";
            this.textBox_OrderFilm.ReadOnly = true;
            this.textBox_OrderFilm.Size = new System.Drawing.Size(100, 20);
            this.textBox_OrderFilm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OrderCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OrderCancel;
        private System.Windows.Forms.Button btn_OrderOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_OrderFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OrderClient;
        private System.Windows.Forms.TextBox textBox_OrderClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_OrderFilm;
        private System.Windows.Forms.NumericUpDown numericUpDown_OrderCost;
    }
}