using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           
        }

        databaseconnect dbcon = new databaseconnect();
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a =dbcon.addproduct(int.Parse(textBox1.Text),textBox2.Text,textBox3.Text);
            MessageBox.Show(a + "added product sucessfully");
            Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
