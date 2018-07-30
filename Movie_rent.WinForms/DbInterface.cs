using Movie_rent.Db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_rent.WinForms
{
    public class DbInterface
    {
        public MovieRentContext db;

        public DbInterface(MovieRentContext db)
        {
            this.db = db;
        }

        public void AddClient(client client)
        {            
            if (client == null) return;
            db.clients.Add(client);
            db.SaveChanges();
        }

        public void EditClient(client client)
        {
            if (client == null) return;
            db.Entry(client).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteClient(client client)
        {
            if (client == null) return;
            db.clients.Remove(client);
            db.SaveChanges();
        }

        public void AddDirector(director director)
        {            
            if (director == null) return;
            db.directors.Add(director);
            db.SaveChanges();
        }

        public void EditDirector(int _id)
        {
            //DirectorForm form = new DirectorForm();

            //int id = _id;
            //director director = db.directors.Find(id);
            //form.textBox_DirectorFname.Text = director.fname;
            //form.textBox_DirectorLname.Text = director.lname;
            

            //var result = form.ShowDialog();
            //if (result == DialogResult.Cancel) return;

            //director.fname = form.textBox_DirectorFname.Text;
            //director.lname = form.textBox_DirectorLname.Text;
            
            //db.SaveChanges();
        }

        public void DeleteDirector(int id)
        {
            director director = db.directors.Find(id);
            db.directors.Attach(director);
            db.directors.Remove(director);
            db.SaveChanges();
        }

        public void AddActor(actor actor)
        {
            if (actor == null) return;
            db.actors.Add(actor);
            db.SaveChanges();
        }

        public void DeleteActor(int id)
        {
            actor actor = db.actors.Find(id);
            db.actors.Attach(actor);
            db.actors.Remove(actor);
            db.SaveChanges();
        }

        public void EditActor(int _id)
        {
            //ActorForm form = new ActorForm();

            //int id = _id;
            //actor actor = db.actors.Find(id);
            //form.textBox_ActorFname.Text = actor.fname;
            //form.textBox_ActorLname.Text = actor.lname;


            //var result = form.ShowDialog();
            //if (result == DialogResult.Cancel) return;

            //actor.fname = form.textBox_ActorFname.Text;
            //actor.lname = form.textBox_ActorLname.Text;

            //db.SaveChanges();
        }

        public void AddGenre(genre genre)
        {
            if (genre == null) return;
            db.genres.Add(genre);
            db.SaveChanges();
        }

        public void EditGenre(int _id)
        {
            //GenreForm form = new GenreForm();

            //int id = _id;
            //genre genre = db.genres.Find(id);
            //form.textBox_GenreName.Text = genre.name;

            //var result = form.ShowDialog();
            //if (result == DialogResult.Cancel) return;

            //genre.name = form.textBox_GenreName.Text;

            //db.SaveChanges();
        }

        public void DeleteGenre(int id)
        {
            genre genre = db.genres.Find(id);
            db.genres.Attach(genre);
            db.genres.Remove(genre);
            db.SaveChanges();
        }

        public void AddStaff(staff staff)
        {            
            if (staff == null) return;
            db.staffs.Add(staff);
            db.SaveChanges();
        }

        public void EditStaff(int _id)
        {
            //StaffForm form = new StaffForm();

            //int id = _id;
            //staff staff = db.staffs.Find(id);
            //form.textBox_StaffFname.Text = staff.fname;
            //form.textBox_StaffLname.Text = staff.lname;
            //form.numericUpDown_Staff.Value = staff.type;
            //form.textBox_StaffLogin.Text = staff.login;
            //form.textBox_StaffLogin.Text = staff.password;

            //var result = form.ShowDialog();
            //if (result == DialogResult.Cancel) return;

            //staff.fname = form.textBox_StaffFname.Text;
            //staff.lname = form.textBox_StaffLname.Text;
            //staff.type = (int)form.numericUpDown_Staff.Value;
            //staff.login = form.textBox_StaffLogin.Text;
            //staff.password = form.textBox_StaffPassword.Text;

            //db.SaveChanges();
        }

        public void DeleteStaff(int _id)
        {
            staff staff = db.staffs.Find(_id);
            db.staffs.Attach(staff);
            db.staffs.Remove(staff);
            db.SaveChanges();
        }

        public void AddFilm(film film)
        {
            if (film == null) return;
            db.films.Add(film);
            db.SaveChanges();
        }

        public List<actor> SearchActors(string str)
        {
           return db.actors.Where(b => b.fname.StartsWith(str) || b.lname.StartsWith(str)).ToList();
        }

        public List<client> SearchClients(string str)
        {
            return db.clients.Where(b => b.fname.StartsWith(str) || b.lname.StartsWith(str)).ToList();
        }

        public List<film> SearchFilms(string str)
        {
            return db.films.Where(b => b.name.StartsWith(str)).ToList();
        }

        public void EditFilm(int id, film film)
        {
            if (film == null) return;
            db.films.Find(id);
            db.films.Add(film);
            db.SaveChanges();
        }

        public void AddOrder(order order)
        {
            if (order == null) return;
            db.orders.Add(order);
            db.SaveChanges();
        }
    }
}
