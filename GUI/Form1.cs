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

            //Pre-Generated objects in the list
            namnLista.Add(new Customer() { firstName = "Thor", lastName = "Odinsson", email = "thor.odinsson@vallhalla.com", phoneNumber = "237-740 50 23", favorite = true });
            namnLista.Add(new Customer() { firstName = "Bruce", lastName = "Banner", email = "bruce.banner@smash.com", phoneNumber = "123-456 78 90", favorite = true });
            namnLista.Add(new Customer() { firstName = "Spongebob", lastName = "Squarepants", email = "spongebob.squarepants@spongemail.wc", phoneNumber = "345-038 82 24", favorite = false });



            //Puts together all First and last names into a whole name
            foreach (Customer e in namnLista)
            {
                e.wholeName = (e.firstName + " " + e.lastName);
            }
        }

        //This method adds names and properties to the list \/
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Please add a full description.");
            }
            else
            {
                Customer c = new Customer() { firstName = textBox1.Text, lastName = textBox2.Text, email = textBox4.Text, phoneNumber = textBox5.Text, favorite = checkBox1.Checked };
                c.wholeName = (c.firstName + " " + c.lastName);
                listBox1.Items.Clear();
                namnLista.Add(c);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                checkBox1.Checked = false;
                listBox1.Items.Add("Customer added");
            }
        }
        //This method adds names and properties to the list /\

        //This method displays all the names in the list onto the listBox \/
        private void Button2_Click(object sender, EventArgs e)
        {
            //Skriver ut alla kunder i listan
            listBox1.Items.Clear();

            foreach (Customer a in namnLista)
            {
                listBox1.Items.Add(a.wholeName);
            }
        }
        //This method displays all the names in the list onto the listBox /\

        //This method compares the inputed name to all the names in the list. If its a match, then print the info about the name \/
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
                listBox1.Items.Add("That name does not exist in the list.");
                listBox1.Items.Add("Try another name.");
            }
        }
        //This method compares the inputed name to all the names in the list. If its a match, then print the info about the name /\

        //This method clears all textspaces and prints out some instructions for the GUI-user\/
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            listBox1.Items.Clear();
            checkBox1.Checked = false;

            listBox1.Items.Add("1.You can search for a customer in the upper box.");
            listBox1.Items.Add("");
            listBox1.Items.Add("2.You can add a new customer by entering the");
            listBox1.Items.Add("customers description in the boxes above and press ");
            listBox1.Items.Add("'Add Customer'.");
            listBox1.Items.Add("");
            listBox1.Items.Add("3.You can see all customers listed by pressing");
            listBox1.Items.Add("'Show Customers'");
        }
        //This method clears all textspaces and prints out some instructions for the GUI-user\/
    }
}
