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
    public partial class ActorForm : Form
    {
        actor actor;
        public ActorForm(actor actor)
        {
            this.actor = actor;
            InitializeComponent();
            if (actor.id == 0) return;
            textBox_ActorFname.Text = actor.fname;
            textBox_ActorLname.Text = actor.lname;
        }

        private bool ActorValidate()
        {
            if (string.IsNullOrEmpty(textBox_ActorFname.Text))
            {
                MessageBox.Show("First Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(textBox_ActorLname.Text))
            {
                MessageBox.Show("Last Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btn_ActorOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = ActorValidate() ? DialogResult.OK : DialogResult.None;
        }

        public actor getActor()
        {
            actor.fname = textBox_ActorFname.Text;
            actor.lname = textBox_ActorLname.Text;
            return actor;
        }
    }
}
