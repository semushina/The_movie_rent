using Movie_rent.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_rent.WinForms
{
    public partial class FilmForm : Form
    {
        film film;

        private class ActorsProperties : PropertiesAddDel
        {
            private ICollection<actor> actors;

            public ActorsProperties(ICollection<actor> actors) : base()
            {
                this.actors = actors;
                groupBox1.Text = "Actors";

                listBox2.Items.Clear();
                foreach (actor a in actors)
                {
                    listBox2.Items.Add(a);
                }
            }


            protected override void btn_Search_Click(object sender, EventArgs e)
            {
                var actors_res = Form1.Current.getModel().SearchActors(textBox_Search.Text);
                listBox1.Items.Clear();
                foreach (actor a in actors_res) {
                    listBox1.Items.Add(a);
                }
            }

            protected override void btn_Add_Click(object sender, EventArgs e)
            {
                if (listBox1.SelectedItem == null) return;
                actors.Add(listBox1.SelectedItem as actor);

                listBox2.Items.Clear();
                foreach (actor a in actors)
                {
                    listBox2.Items.Add(a);
                }
            }
        }

        ActorsProperties actorsPropertiesForm;

        public FilmForm(film film)
        {
            this.film = film;
            actorsPropertiesForm = new ActorsProperties(film.actors);
            InitializeComponent();

            if (film.id == 0) return;
            textBox_FilmName.Text = film.name;
            numericUpDown_FilmYear.Value = film.year;
            numericUpDown_FilmDuraction.Value = film.duration;

        }

        private void btn_FilmAddActors_Click(object sender, EventArgs e)
        {
            actorsPropertiesForm.ShowDialog();
        }

        private bool FilmChecks()
        {
            if (string.IsNullOrEmpty(textBox_FilmName.Text))
            {
                MessageBox.Show("Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btn_FilmOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = FilmChecks() ? DialogResult.OK : DialogResult.None;
        }

        public film getFilm()
        {
            film.name = textBox_FilmName.Text;
            film.year = (int)numericUpDown_FilmYear.Value;
            film.duration = (int)numericUpDown_FilmDuraction.Value;
            return film;
        }
        
    }
}
