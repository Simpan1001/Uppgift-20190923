using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        ArrayList namnLista = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Add Customer";
            button2.Text = "Show Customers";
            button3.Text = "Search name";

            namnLista.Add(new Customer() { firstName = "Thor", lastName = "Odinsson", email = "thor.odinsson@vallhalla.com", phoneNumber = "237-740 50 23", favorite = true });
            namnLista.Add(new Customer() { firstName = "Bruce", lastName = "Banner", email = "bruce.banner@smash.com", phoneNumber = "123-456 78 90", favorite = true });
            namnLista.Add(new Customer() { firstName = "Spongebob", lastName = "Squarepants", email = "spongebob.squarepants@spongemail.wc", phoneNumber = "", favorite = false });

            foreach (Customer e in namnLista)
            {
                e.wholeName = (e.firstName + " " + e.lastName);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Addera texten i textrutorna till listan
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Customer c = new Customer() { firstName = textBox1.Text, lastName = textBox2.Text };
                c.wholeName = (c.firstName + " " + c.lastName);
                namnLista.Add(c);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Skriver ut alla kunder i listan
            listBox1.Items.Clear();

            foreach (Customer a in namnLista)
            {
                listBox1.Items.Add(a.wholeName);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 0;
            foreach (Customer b in namnLista)
            {
                if (textBox3.Text == b.wholeName)
                {
                    textBox3.Clear();
                    listBox1.Items.Add(b.wholeName);
                    listBox1.Items.Add(b.email);
                    listBox1.Items.Add(b.phoneNumber);
                    listBox1.Items.Add("Favorite: " + b.favorite);
                    i++;
                }
            }
            if (i == 0)
            {
                listBox1.Items.Add("That name does not exist in the current context, lol XD");
            }
        }

    }
}
