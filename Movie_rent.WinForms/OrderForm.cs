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
    public partial class OrderForm : Form
    {
        order order;

        private class AddClientForm : PropertiesAddDel
        {
            private order order;

            public AddClientForm(order order) : base()
            {
                this.order = order;
                groupBox1.Text = "Client";
                label1.Text = "Selected Client";

                listBox2.Items.Clear();
                if(order.id != 0 && order.client.id != 0 ) listBox2.Items.Add(order.client);
                
            }

            protected override void btn_Search_Click(object sender, EventArgs e)
            {
                var clients_res = Form1.Current.getModel().SearchClients(textBox_Search.Text);
                listBox1.Items.Clear();
                foreach (client c in clients_res)
                {
                    listBox1.Items.Add(c);
                }
            }

            protected override void btn_Add_Click(object sender, EventArgs e)
            {
                if (listBox1.SelectedItem == null) return;
                if (listBox2.Items.Count > 0) return;

                order.client = listBox1.SelectedItem as client;
                listBox2.Items.Clear();
                listBox2.Items.Add(order.client);
                
            }
        }

        private class AddFilmForm : PropertiesAddDel
        {
            private order order;

            public AddFilmForm(order order) : base()
            {
                this.order = order;
                groupBox1.Text = "Film";
                label1.Text = "SelectedFilm";

                listBox2.Items.Clear();
                if (order.id != 0 && order.film.id != 0) listBox2.Items.Add(order.film);

            }

            protected override void btn_Search_Click(object sender, EventArgs e)
            {
                var films_res = Form1.Current.getModel().SearchFilms(textBox_Search.Text);
                listBox1.Items.Clear();
                foreach (film f in films_res)
                {
                    listBox1.Items.Add(f);
                }

            }

            protected override void btn_Add_Click(object sender, EventArgs e)
            {
                if (listBox1.SelectedItem == null) return;
                if (listBox2.Items.Count > 0) return;

                order.film = listBox1.SelectedItem as film;
                listBox2.Items.Clear();
                listBox2.Items.Add(order.film);

            }
        }

        AddClientForm client_form;
        AddFilmForm film_form;

        public OrderForm(order order)
        {
            this.order = order;
            InitializeComponent();
            client_form = new AddClientForm(order);
            film_form = new AddFilmForm(order);

            dateTimePicker1.Value = order.issue_date;
            dateTimePicker2.Value = order.return_date;
            numericUpDown_OrderCost.Value = order.cost;
        }

        

        private void btn_OrderClient_Click(object sender, EventArgs e)
        {
            client_form.ShowDialog();
            textBox_OrderClient.Text = order.client.ToString();
        }

        private void btn_OrderFilm_Click(object sender, EventArgs e)
        {
            film_form.ShowDialog();
            textBox_OrderFilm.Text = order.film.name;
        }

        public order getOrder()
        {
            order.issue_date = dateTimePicker1.Value;
            order.return_date = dateTimePicker2.Value;
            order.cost = (int)numericUpDown_OrderCost.Value;
            return order;
        }

        private void btn_OrderOk_Click(object sender, EventArgs e)
        {
            //checks
        }
    }
}
