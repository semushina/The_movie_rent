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
    public partial class StaffForm : Form
    {
        staff staff;
        public StaffForm(staff staff)
        {
            this.staff = staff;
            InitializeComponent();
            if (staff.id == 0) return;
            textBox_StaffFname.Text = staff.fname;
            textBox_StaffLname.Text = staff.lname;
            numericUpDown_Staff.Value = staff.type;
            textBox_StaffLogin.Text = staff.login;
            textBox_StaffPassword.Text = staff.password;
        }

        private bool StaffValidate()
        {
            if (string.IsNullOrEmpty(textBox_StaffFname.Text))
            {
                MessageBox.Show("First Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            else if(string.IsNullOrEmpty(textBox_StaffLname.Text))
            {
                MessageBox.Show("Last Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(textBox_StaffLogin.Text))
            {
                MessageBox.Show("Login is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(textBox_StaffPassword.Text))
            {
                MessageBox.Show("Password is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btn_StaffOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = StaffValidate() ? DialogResult.OK : DialogResult.None;
        }

        internal staff getStaff()
        {
            staff.fname = textBox_StaffFname.Text;
            staff.lname = textBox_StaffLname.Text;
            staff.type = (int)numericUpDown_Staff.Value;
            staff.login = textBox_StaffLogin.Text;
            staff.password = textBox_StaffPassword.Text;
            return staff;
        }
    }
}
