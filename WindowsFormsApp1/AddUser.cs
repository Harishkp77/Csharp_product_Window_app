using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();

        private void AddUser_Load(object sender, EventArgs e)
        {
            textBox3.Text = "USER";

        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x= dbcon.adduser(textBox1.Text,textBox2.Text,textBox3.Text);
            MessageBox.Show(x + " user added sucessfully");
            Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
