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
    public partial class DirectorForm : Form
    {
        director director;
        public DirectorForm(director director)
        {
            this.director = director;
            InitializeComponent();
            if (director.id == 0) return;
            textBox_DirectorFname.Text = director.fname;
            textBox_DirectorLname.Text = director.lname;
        }

        public bool directorValidate()
        {
            if (string.IsNullOrEmpty(textBox_DirectorFname.Text))
            {
                MessageBox.Show("First Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(textBox_DirectorLname.Text))
            {
                MessageBox.Show("First Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btn_DirectorOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = directorValidate() ? DialogResult.OK : DialogResult.None;
        }

        public director getDirector()
        {
            director.fname = textBox_DirectorFname.Text;
            director.lname = textBox_DirectorLname.Text;
            return director;
        }
    }
}
