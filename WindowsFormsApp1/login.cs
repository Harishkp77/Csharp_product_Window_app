using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();
        private void button1_Click(object sender, EventArgs e)
        {
            int x = dbcon.logintype(textBox1.Text, textBox2.Text, comboBox1.Text);
            string userID = textBox1.Text;
            if (x == 1)
            {
                if (comboBox1.Text == "ADMIN")

                {
                   admin admin = new admin();   
                   admin.Show();
                }
                else if (comboBox1.Text == "admin")
                {
                    MessageBox.Show("Invalid UID/PWD.....");
                   
                }
                else
                {
                    user user =  new user(userID);
                    user.Show();
                    
                }

            }
            else
            {
               
                MessageBox.Show("Invalid UID/PWD.....");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            textBox2.Text = "";

            textBox1.Text = "";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox1.Text = "max 20 character";
            textBox2.Text = "max 20 character";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Clear();
        }
    }
}
