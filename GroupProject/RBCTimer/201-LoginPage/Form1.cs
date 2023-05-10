using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201_LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "Demo" && textPass.Text == "1234")
            {
                // this is where you code in the screen after you login, so i
                // would imagine the homepage. i put the basic code in a comment so
                // hopefully it makes sense what has to be changed to make it
                // fit our app
                /* 
                  new nameOfHomePage().Show();
                  this.Hide();
                */
            } 
            else
            {
                // message appears if username and password is wrong, also clears the form
                MessageBox.Show("The username or password is incorrect, please try again.");
                textUser.Clear();
                textPass.Clear();
                textUser.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textUser.Clear();
            textPass.Clear();
            textUser.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // exit ye olde application
            Application.Exit();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
