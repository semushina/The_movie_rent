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
    public partial class ClientForm : Form
    {
        client client;
        public ClientForm(client client)
        {
            this.client = client;
            InitializeComponent();

            if (client.id == null) return;
            textBox_ClientFname.Text = client.fname;
            textBox_ClientLname.Text = client.lname;
            textBox_ClientTel.Text = client.tel_number;
        }

        private bool ClientValidate()
        {
            if (string.IsNullOrEmpty(textBox_ClientFname.Text))
            {
                MessageBox.Show("First Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(textBox_ClientLname.Text))
            {
                MessageBox.Show("Last Name is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(textBox_ClientTel.Text))
            {
                MessageBox.Show("Tel. is Empty!", "Warning", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btn_ClientOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = ClientValidate() ? DialogResult.OK : DialogResult.None;
        }

        public client getClient()
        {
            client.fname = textBox_ClientFname.Text;
            client.lname = textBox_ClientLname.Text;
            client.tel_number = textBox_ClientTel.Text;
            return client;
        }

        public client getClientById()
        {
            return client;
        }
    }
}
