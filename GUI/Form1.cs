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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Addera texten i textrutorna till listan
            
            Customer c = new Customer() {firstName = textBox1.Text, lastName = textBox2.Text};
            c.wholeName = (c.firstName + " " + c.lastName);
            namnLista.Add(c);
            textBox1.Clear();
            textBox2.Clear();
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
    }
}
