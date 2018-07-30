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
            this.textBox_GenreName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OrderCancel
            // 
            this.btn_OrderCancel.Location = new System.Drawing.Point(7, 232);
            this.btn_OrderCancel.Name = "btn_OrderCancel";
            this.btn_OrderCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_OrderCancel.TabIndex = 7;
            this.btn_OrderCancel.Text = "Cancel";
            this.btn_OrderCancel.UseVisualStyleBackColor = true;
            // 
            // btn_OrderOk
            // 
            this.btn_OrderOk.Location = new System.Drawing.Point(322, 232);
            this.btn_OrderOk.Name = "btn_OrderOk";
            this.btn_OrderOk.Size = new System.Drawing.Size(75, 23);
            this.btn_OrderOk.TabIndex = 6;
            this.btn_OrderOk.Text = "OK";
            this.btn_OrderOk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_OrderCancel);
            this.groupBox1.Controls.Add(this.btn_OrderOk);
            this.groupBox1.Controls.Add(this.textBox_GenreName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
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
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OrderCancel;
        private System.Windows.Forms.Button btn_OrderOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_GenreName;
        private System.Windows.Forms.Label label1;
    }
}