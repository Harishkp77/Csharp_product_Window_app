using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();
        public void Clear()
        {
            //textBox1.Text = "";
            textBox2.Text = "";

        }
        public void refresh()
        {
            DataTable dt = new DataTable();
            dt = dbcon.viewfulltableuser();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "userid";
        }
        

        private void EditUser_Load(object sender, EventArgs e)
        {
            
            refresh();
            textBox3.Text = "USER";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = dbcon.edituser(comboBox1.Text, textBox2.Text, textBox3.Text);
            if(x==0)
            {
                MessageBox.Show("Cannot update Admin usertype");
                refresh();

            }
            else
            {
                MessageBox.Show(x + " user updated sucessfully");
                refresh();

            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                var cb = (sender as System.Windows.Forms.ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox2.Text = selecteditem["password"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString() + "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
