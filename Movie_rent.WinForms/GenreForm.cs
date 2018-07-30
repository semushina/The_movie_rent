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
    public partial class GenreForm : Form
    {
        genre genre;
        public GenreForm(genre genre)
        {
            this.genre = genre;
            InitializeComponent();

            if (genre.id == null) return;
            textBox_GenreName.Text = genre.name;
        }

        public bool GenreValidate()
        {
            if (string.IsNullOrEmpty(textBox_GenreName.Text))
            {
                MessageBox.Show("Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btn_GenreOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = GenreValidate() ? DialogResult.OK : DialogResult.None;
        }

        public genre getGenre()
        {
            genre.name = textBox_GenreName.Text;
            return genre;
        }
    }
}
