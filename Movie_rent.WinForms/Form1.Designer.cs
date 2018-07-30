namespace Movie_rent.WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DeleteClient = new System.Windows.Forms.Button();
            this.btn_EditClient = new System.Windows.Forms.Button();
            this.btn_AddClient = new System.Windows.Forms.Button();
            this.dataGrid_Clients = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_CatalogEdit = new System.Windows.Forms.Button();
            this.btn_AddNewFilm = new System.Windows.Forms.Button();
            this.dataGrid_Films = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_DeleteDirector = new System.Windows.Forms.Button();
            this.btn_EditDirector = new System.Windows.Forms.Button();
            this.btn_AddDirector = new System.Windows.Forms.Button();
            this.dataGrid_Directors = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_DeleteActor = new System.Windows.Forms.Button();
            this.btn_EditActor = new System.Windows.Forms.Button();
            this.btn_AddActor = new System.Windows.Forms.Button();
            this.dataGrid_Actors = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_DeleteGenre = new System.Windows.Forms.Button();
            this.btn_EditGenre = new System.Windows.Forms.Button();
            this.btn_AddGenre = new System.Windows.Forms.Button();
            this.dataGrid_Genres = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btn_DeleteStaff = new System.Windows.Forms.Button();
            this.btn_EditStaff = new System.Windows.Forms.Button();
            this.btn_AddStaff = new System.Windows.Forms.Button();
            this.dataGrid_Staffs = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGrid_Orders = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clients)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Films)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Directors)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Actors)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Genres)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Staffs)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_DeleteClient);
            this.tabPage2.Controls.Add(this.btn_EditClient);
            this.tabPage2.Controls.Add(this.btn_AddClient);
            this.tabPage2.Controls.Add(this.dataGrid_Clients);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteClient
            // 
            this.btn_DeleteClient.Location = new System.Drawing.Point(300, 305);
            this.btn_DeleteClient.Name = "btn_DeleteClient";
            this.btn_DeleteClient.Size = new System.Drawing.Size(129, 58);
            this.btn_DeleteClient.TabIndex = 3;
            this.btn_DeleteClient.Text = "Delete";
            this.btn_DeleteClient.UseVisualStyleBackColor = true;
            this.btn_DeleteClient.Click += new System.EventHandler(this.btn_DeleteClient_Click);
            // 
            // btn_EditClient
            // 
            this.btn_EditClient.Location = new System.Drawing.Point(300, 246);
            this.btn_EditClient.Name = "btn_EditClient";
            this.btn_EditClient.Size = new System.Drawing.Size(129, 58);
            this.btn_EditClient.TabIndex = 2;
            this.btn_EditClient.Text = "Edit";
            this.btn_EditClient.UseVisualStyleBackColor = true;
            this.btn_EditClient.Click += new System.EventHandler(this.btn_EditClient_Click);
            // 
            // btn_AddClient
            // 
            this.btn_AddClient.Location = new System.Drawing.Point(435, 246);
            this.btn_AddClient.Name = "btn_AddClient";
            this.btn_AddClient.Size = new System.Drawing.Size(129, 117);
            this.btn_AddClient.TabIndex = 1;
            this.btn_AddClient.Text = "Add";
            this.btn_AddClient.UseVisualStyleBackColor = true;
            this.btn_AddClient.Click += new System.EventHandler(this.btn_AddClient_Click);
            // 
            // dataGrid_Clients
            // 
            this.dataGrid_Clients.AllowUserToAddRows = false;
            this.dataGrid_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Clients.Location = new System.Drawing.Point(7, 7);
            this.dataGrid_Clients.Name = "dataGrid_Clients";
            this.dataGrid_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Clients.Size = new System.Drawing.Size(557, 233);
            this.dataGrid_Clients.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_CatalogEdit);
            this.tabPage3.Controls.Add(this.btn_AddNewFilm);
            this.tabPage3.Controls.Add(this.dataGrid_Films);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(570, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Catalog";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_CatalogEdit
            // 
            this.btn_CatalogEdit.Location = new System.Drawing.Point(303, 308);
            this.btn_CatalogEdit.Name = "btn_CatalogEdit";
            this.btn_CatalogEdit.Size = new System.Drawing.Size(129, 58);
            this.btn_CatalogEdit.TabIndex = 3;
            this.btn_CatalogEdit.Text = "Edit";
            this.btn_CatalogEdit.UseVisualStyleBackColor = true;
            this.btn_CatalogEdit.Click += new System.EventHandler(this.btn_CatalogEdit_Click);
            // 
            // btn_AddNewFilm
            // 
            this.btn_AddNewFilm.Location = new System.Drawing.Point(438, 249);
            this.btn_AddNewFilm.Name = "btn_AddNewFilm";
            this.btn_AddNewFilm.Size = new System.Drawing.Size(129, 117);
            this.btn_AddNewFilm.TabIndex = 2;
            this.btn_AddNewFilm.Text = "Add new film";
            this.btn_AddNewFilm.UseVisualStyleBackColor = true;
            this.btn_AddNewFilm.Click += new System.EventHandler(this.btn_AddNewFilm_Click);
            // 
            // dataGrid_Films
            // 
            this.dataGrid_Films.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Films.Location = new System.Drawing.Point(4, 4);
            this.dataGrid_Films.Name = "dataGrid_Films";
            this.dataGrid_Films.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Films.Size = new System.Drawing.Size(563, 239);
            this.dataGrid_Films.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_DeleteDirector);
            this.tabPage4.Controls.Add(this.btn_EditDirector);
            this.tabPage4.Controls.Add(this.btn_AddDirector);
            this.tabPage4.Controls.Add(this.dataGrid_Directors);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(570, 369);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Director";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteDirector
            // 
            this.btn_DeleteDirector.Location = new System.Drawing.Point(303, 248);
            this.btn_DeleteDirector.Name = "btn_DeleteDirector";
            this.btn_DeleteDirector.Size = new System.Drawing.Size(129, 54);
            this.btn_DeleteDirector.TabIndex = 3;
            this.btn_DeleteDirector.Text = "Delete";
            this.btn_DeleteDirector.UseVisualStyleBackColor = true;
            this.btn_DeleteDirector.Click += new System.EventHandler(this.btn_DeleteDirector_Click);
            // 
            // btn_EditDirector
            // 
            this.btn_EditDirector.Location = new System.Drawing.Point(303, 307);
            this.btn_EditDirector.Name = "btn_EditDirector";
            this.btn_EditDirector.Size = new System.Drawing.Size(129, 58);
            this.btn_EditDirector.TabIndex = 2;
            this.btn_EditDirector.Text = "Edit";
            this.btn_EditDirector.UseVisualStyleBackColor = true;
            this.btn_EditDirector.Click += new System.EventHandler(this.btn_EditDirector_Click);
            // 
            // btn_AddDirector
            // 
            this.btn_AddDirector.Location = new System.Drawing.Point(438, 248);
            this.btn_AddDirector.Name = "btn_AddDirector";
            this.btn_AddDirector.Size = new System.Drawing.Size(129, 117);
            this.btn_AddDirector.TabIndex = 1;
            this.btn_AddDirector.Text = "Add";
            this.btn_AddDirector.UseVisualStyleBackColor = true;
            this.btn_AddDirector.Click += new System.EventHandler(this.btn_AddDirector_Click);
            // 
            // dataGrid_Directors
            // 
            this.dataGrid_Directors.AllowUserToDeleteRows = false;
            this.dataGrid_Directors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Directors.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Directors.Name = "dataGrid_Directors";
            this.dataGrid_Directors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Directors.Size = new System.Drawing.Size(564, 239);
            this.dataGrid_Directors.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_DeleteActor);
            this.tabPage5.Controls.Add(this.btn_EditActor);
            this.tabPage5.Controls.Add(this.btn_AddActor);
            this.tabPage5.Controls.Add(this.dataGrid_Actors);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(570, 369);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Actor";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Visible = false;
            // 
            // btn_DeleteActor
            // 
            this.btn_DeleteActor.Location = new System.Drawing.Point(303, 248);
            this.btn_DeleteActor.Name = "btn_DeleteActor";
            this.btn_DeleteActor.Size = new System.Drawing.Size(129, 54);
            this.btn_DeleteActor.TabIndex = 7;
            this.btn_DeleteActor.Text = "Delete";
            this.btn_DeleteActor.UseVisualStyleBackColor = true;
            this.btn_DeleteActor.Click += new System.EventHandler(this.btn_DeleteActor_Click);
            // 
            // btn_EditActor
            // 
            this.btn_EditActor.Location = new System.Drawing.Point(303, 307);
            this.btn_EditActor.Name = "btn_EditActor";
            this.btn_EditActor.Size = new System.Drawing.Size(129, 58);
            this.btn_EditActor.TabIndex = 6;
            this.btn_EditActor.Text = "Edit";
            this.btn_EditActor.UseVisualStyleBackColor = true;
            this.btn_EditActor.Click += new System.EventHandler(this.btn_EditActor_Click);
            // 
            // btn_AddActor
            // 
            this.btn_AddActor.Location = new System.Drawing.Point(438, 248);
            this.btn_AddActor.Name = "btn_AddActor";
            this.btn_AddActor.Size = new System.Drawing.Size(129, 117);
            this.btn_AddActor.TabIndex = 5;
            this.btn_AddActor.Text = "Add";
            this.btn_AddActor.UseVisualStyleBackColor = true;
            this.btn_AddActor.Click += new System.EventHandler(this.btn_AddActor_Click);
            // 
            // dataGrid_Actors
            // 
            this.dataGrid_Actors.AllowUserToDeleteRows = false;
            this.dataGrid_Actors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Actors.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Actors.Name = "dataGrid_Actors";
            this.dataGrid_Actors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Actors.Size = new System.Drawing.Size(564, 239);
            this.dataGrid_Actors.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_DeleteGenre);
            this.tabPage6.Controls.Add(this.btn_EditGenre);
            this.tabPage6.Controls.Add(this.btn_AddGenre);
            this.tabPage6.Controls.Add(this.dataGrid_Genres);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(570, 369);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Genre";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteGenre
            // 
            this.btn_DeleteGenre.Location = new System.Drawing.Point(303, 248);
            this.btn_DeleteGenre.Name = "btn_DeleteGenre";
            this.btn_DeleteGenre.Size = new System.Drawing.Size(129, 54);
            this.btn_DeleteGenre.TabIndex = 11;
            this.btn_DeleteGenre.Text = "Delete";
            this.btn_DeleteGenre.UseVisualStyleBackColor = true;
            this.btn_DeleteGenre.Click += new System.EventHandler(this.btn_DeleteGenre_Click);
            // 
            // btn_EditGenre
            // 
            this.btn_EditGenre.Location = new System.Drawing.Point(303, 307);
            this.btn_EditGenre.Name = "btn_EditGenre";
            this.btn_EditGenre.Size = new System.Drawing.Size(129, 58);
            this.btn_EditGenre.TabIndex = 10;
            this.btn_EditGenre.Text = "Edit";
            this.btn_EditGenre.UseVisualStyleBackColor = true;
            this.btn_EditGenre.Click += new System.EventHandler(this.btn_EditGenre_Click);
            // 
            // btn_AddGenre
            // 
            this.btn_AddGenre.Location = new System.Drawing.Point(438, 248);
            this.btn_AddGenre.Name = "btn_AddGenre";
            this.btn_AddGenre.Size = new System.Drawing.Size(129, 117);
            this.btn_AddGenre.TabIndex = 9;
            this.btn_AddGenre.Text = "Add";
            this.btn_AddGenre.UseVisualStyleBackColor = true;
            this.btn_AddGenre.Click += new System.EventHandler(this.btn_AddGenre_Click);
            // 
            // dataGrid_Genres
            // 
            this.dataGrid_Genres.AllowUserToDeleteRows = false;
            this.dataGrid_Genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Genres.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Genres.Name = "dataGrid_Genres";
            this.dataGrid_Genres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Genres.Size = new System.Drawing.Size(564, 239);
            this.dataGrid_Genres.TabIndex = 8;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btn_DeleteStaff);
            this.tabPage7.Controls.Add(this.btn_EditStaff);
            this.tabPage7.Controls.Add(this.btn_AddStaff);
            this.tabPage7.Controls.Add(this.dataGrid_Staffs);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(570, 369);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Staff";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteStaff
            // 
            this.btn_DeleteStaff.Location = new System.Drawing.Point(303, 248);
            this.btn_DeleteStaff.Name = "btn_DeleteStaff";
            this.btn_DeleteStaff.Size = new System.Drawing.Size(129, 54);
            this.btn_DeleteStaff.TabIndex = 15;
            this.btn_DeleteStaff.Text = "Delete";
            this.btn_DeleteStaff.UseVisualStyleBackColor = true;
            this.btn_DeleteStaff.Click += new System.EventHandler(this.btn_DeleteStaff_Click);
            // 
            // btn_EditStaff
            // 
            this.btn_EditStaff.Location = new System.Drawing.Point(303, 307);
            this.btn_EditStaff.Name = "btn_EditStaff";
            this.btn_EditStaff.Size = new System.Drawing.Size(129, 58);
            this.btn_EditStaff.TabIndex = 14;
            this.btn_EditStaff.Text = "Edit";
            this.btn_EditStaff.UseVisualStyleBackColor = true;
            this.btn_EditStaff.Click += new System.EventHandler(this.btn_EditStaff_Click);
            // 
            // btn_AddStaff
            // 
            this.btn_AddStaff.Location = new System.Drawing.Point(438, 248);
            this.btn_AddStaff.Name = "btn_AddStaff";
            this.btn_AddStaff.Size = new System.Drawing.Size(129, 117);
            this.btn_AddStaff.TabIndex = 13;
            this.btn_AddStaff.Text = "Add";
            this.btn_AddStaff.UseVisualStyleBackColor = true;
            this.btn_AddStaff.Click += new System.EventHandler(this.btn_AddStaff_Click);
            // 
            // dataGrid_Staffs
            // 
            this.dataGrid_Staffs.AllowUserToDeleteRows = false;
            this.dataGrid_Staffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Staffs.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Staffs.Name = "dataGrid_Staffs";
            this.dataGrid_Staffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Staffs.Size = new System.Drawing.Size(564, 239);
            this.dataGrid_Staffs.TabIndex = 12;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataGrid_Orders);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(570, 369);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Order";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Orders
            // 
            this.dataGrid_Orders.AllowUserToDeleteRows = false;
            this.dataGrid_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Orders.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_Orders.Name = "dataGrid_Orders";
            this.dataGrid_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Orders.Size = new System.Drawing.Size(564, 239);
            this.dataGrid_Orders.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clients)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Films)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Directors)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Actors)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Genres)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Staffs)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_DeleteClient;
        private System.Windows.Forms.Button btn_EditClient;
        private System.Windows.Forms.Button btn_AddClient;
        private System.Windows.Forms.DataGridView dataGrid_Clients;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_DeleteDirector;
        private System.Windows.Forms.Button btn_EditDirector;
        private System.Windows.Forms.Button btn_AddDirector;
        private System.Windows.Forms.DataGridView dataGrid_Directors;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_DeleteActor;
        private System.Windows.Forms.Button btn_EditActor;
        private System.Windows.Forms.Button btn_AddActor;
        private System.Windows.Forms.DataGridView dataGrid_Actors;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_DeleteGenre;
        private System.Windows.Forms.Button btn_EditGenre;
        private System.Windows.Forms.Button btn_AddGenre;
        private System.Windows.Forms.DataGridView dataGrid_Genres;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btn_DeleteStaff;
        private System.Windows.Forms.Button btn_EditStaff;
        private System.Windows.Forms.Button btn_AddStaff;
        private System.Windows.Forms.DataGridView dataGrid_Staffs;
        private System.Windows.Forms.DataGridView dataGrid_Films;
        private System.Windows.Forms.Button btn_AddNewFilm;
        private System.Windows.Forms.Button btn_CatalogEdit;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dataGrid_Orders;
    }
}

