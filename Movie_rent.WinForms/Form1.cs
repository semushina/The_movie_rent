using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie_rent.Db;
using System.Data.Entity;

namespace Movie_rent.WinForms
{
    public partial class Form1 : Form
    {
        MovieRentContext db;
        private DbInterface _model;

        public static Form1 Current { get; set; }

        public DbInterface getModel()
        {
            return _model;
        }

        public Form1()
        {
            InitializeComponent();
            Current = this;
            db = new MovieRentContext();
            _model = new DbInterface(db);

            db.clients.Load();
            dataGrid_Clients.DataSource = db.clients.Local.ToBindingList();
            dataGrid_Clients.Sort(this.dataGrid_Clients.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
            db.directors.Load();
            dataGrid_Directors.DataSource = db.directors.Local.ToBindingList();
            db.actors.Load();
            dataGrid_Actors.DataSource = db.actors.Local.ToBindingList();
            dataGrid_Actors.Sort(this.dataGrid_Actors.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
            db.genres.Load();
            dataGrid_Genres.DataSource = db.genres.Local.ToBindingList();
            db.staffs.Load();
            dataGrid_Staffs.DataSource = db.staffs.Local.ToBindingList();
            db.films.Load();
            dataGrid_Films.DataSource = db.films.Local.ToBindingList();
            dataGrid_Films.CellFormatting += gridFormatFilmsAvailable;
            dataGrid_Films.CellFormatting += gridFormatFilmsWishlist;
            dataGrid_Films.CellFormatting += gridFormatFilmsActors;
            dataGrid_Films.CellEndEdit += grid_CellEndEdit;


            Refresh();
        }

        void gridFormatFilmsAvailable(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (!grid.Columns[e.ColumnIndex].Name.Equals("available_films")) return;

            var value = e.Value as available_films;
            if (value == null) return;
            e.Value = value.dvd + " dvd's, " + value.bluray + " bluray's";
        }

        void gridFormatFilmsWishlist(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (!grid.Columns[e.ColumnIndex].Name.Equals("clients")) return;

            var value = e.Value as ICollection<client>;
            if (value == null) return;
            e.Value = "" + value.Count();
        }

        void gridFormatFilmsActors(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (!grid.Columns[e.ColumnIndex].Name.Equals("actors")) return;

            var value = e.Value as ICollection<actor>;
            if (value == null) return;
            e.Value = string.Join(", ", value);
        }


        void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            grid.Invalidate();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        override public void Refresh()
        {
            dataGrid_Clients.Refresh();
            dataGrid_Directors.Refresh();
            dataGrid_Actors.Refresh();
            dataGrid_Genres.Refresh();
            dataGrid_Staffs.Refresh();
            dataGrid_Films.Refresh();
        }

        private void btn_AddClient_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.id = 0;
            ClientForm form = new ClientForm(client);
            var result = form.ShowDialog();
            if (result != DialogResult.OK) return;            

            _model.AddClient(form.getClient());
            Refresh();
        }       

        private void btn_EditClient_Click(object sender, EventArgs e)
        {
            if (dataGrid_Clients.SelectedRows.Count < 1) return;
            
            int index = dataGrid_Clients.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Clients[0, index].Value.ToString(), out id);
            if (!converted) return;

            client client = db.clients.Find(id);
            ClientForm form = new ClientForm(client);

            var result = form.ShowDialog();
            if (result == DialogResult.Cancel) return;

            _model.EditClient(id);
            Refresh();
                     
        }

        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGrid_Clients.SelectedRows.Count < 1) return;

            int index = dataGrid_Clients.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Clients[0, index].Value.ToString(), out id);
            if (!converted) return;

            _model.DeleteClient(id);
            Refresh();
        }

        private void btn_AddDirector_Click(object sender, EventArgs e)
        {
            director director = new director();
            director.id = 0;
            DirectorForm form = new DirectorForm(director);

            var result = form.ShowDialog();
            if (result != DialogResult.OK) return;

            _model.AddDirector(form.getDirector());
            Refresh();
        }

        private void btn_EditDirector_Click(object sender, EventArgs e)
        {
            if (dataGrid_Directors.SelectedRows.Count < 1) return;

            int index = dataGrid_Directors.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Directors[0, index].Value.ToString(), out id);
            if (!converted) return;

            

            _model.EditDirector(id);
            Refresh();
        }

        private void btn_DeleteDirector_Click(object sender, EventArgs e)
        {
            if (dataGrid_Directors.SelectedRows.Count < 1) return;

            int index = dataGrid_Directors.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Directors[0, index].Value.ToString(), out id);
            if (!converted) return;

            _model.DeleteDirector(id);
            Refresh();
        }

        private void btn_AddActor_Click(object sender, EventArgs e)
        {
            actor actor = new actor();
            ActorForm form = new ActorForm(actor);

            var result = form.ShowDialog();
            if (result == DialogResult.Cancel) return;
            _model.AddActor(form.getActor());
            Refresh();
        }

        private void btn_DeleteActor_Click(object sender, EventArgs e)
        {
            if (dataGrid_Actors.SelectedRows.Count < 1) return;

            int index = dataGrid_Actors.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Actors[0, index].Value.ToString(), out id);
            if (!converted) return;

            _model.DeleteActor(id);
            Refresh();
        }

        private void btn_EditActor_Click(object sender, EventArgs e)
        {
            if (dataGrid_Actors.SelectedRows.Count < 1) return;

            int index = dataGrid_Actors.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Actors[0, index].Value.ToString(), out id);
            if (!converted) return;

            _model.EditActor(id);
            Refresh();
        }

        private void btn_AddGenre_Click(object sender, EventArgs e)
        {
            genre genre = new genre();
            GenreForm form = new GenreForm(genre);

            var result = form.ShowDialog();

            if (result == DialogResult.Cancel) return;
            _model.AddGenre(form.getGenre());
            Refresh();
        }

        private void btn_EditGenre_Click(object sender, EventArgs e)
        {
            if (dataGrid_Genres.SelectedRows.Count < 1) return;

            int index = dataGrid_Genres.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Genres[0, index].Value.ToString(), out id);
            if (!converted) return;

            _model.EditGenre(id);
            Refresh();
        }

        private void btn_DeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGrid_Genres.SelectedRows.Count < 1) return;

            int index = dataGrid_Genres.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Genres[0, index].Value.ToString(), out id);
            if (!converted) return;

            _model.DeleteGenre(id);
            Refresh();
        }

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            StaffForm form = new StaffForm(staff);

            var result = form.ShowDialog();

            if (result == DialogResult.Cancel) return;
            _model.AddStaff(form.getStaff());
            Refresh();
        }

        private void btn_EditStaff_Click(object sender, EventArgs e)
        {
            if (dataGrid_Staffs.SelectedRows.Count < 1) return;

            int index = dataGrid_Staffs.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Staffs[0, index].Value.ToString(), out id);
            if (!converted) return;

            _model.EditStaff(id);
            Refresh();
        }

        private void btn_DeleteStaff_Click(object sender, EventArgs e)
        {
            if (dataGrid_Staffs.SelectedRows.Count < 1) return;

            int index = dataGrid_Staffs.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Staffs[0, index].Value.ToString(), out id);
            if (!converted) return;

            _model.DeleteStaff(id);
            Refresh();
        }

        private void btn_AddNewFilm_Click(object sender, EventArgs e)
        {
            film film = new film();
            film.id = 0;
            FilmForm form = new FilmForm(film);
            var result = form.ShowDialog();
            if (result != DialogResult.OK) return;

            _model.AddFilm(form.getFilm());
            db.available_films.Load();
            Refresh();
        }

        private void btn_CatalogEdit_Click(object sender, EventArgs e)
        {
            if (dataGrid_Films.SelectedRows.Count < 1) return;

            int index = dataGrid_Films.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGrid_Films[0, index].Value.ToString(), out id);
            if (!converted) return;

           
            
        }
    }

    
}
