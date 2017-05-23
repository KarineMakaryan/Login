using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "Adv" && this.textBox2.Text == "Adv" && checkBox1.Checked)
            {
                MessageBox.Show("Your Username and Password are correct.");
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Wrong input try again!");

            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }
    }
}
