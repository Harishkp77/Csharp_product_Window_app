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
    public partial class AddModel : Form
    {
        public AddModel()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();
        public void refresh()
        {
            DataTable dt = new DataTable();
            dt = dbcon.viewfulltable();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "productid";
        }
        public void Clear()
        {
       
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddModel_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = dbcon.addmodel(int.Parse(comboBox1.Text), textBox1.Text,int.Parse(textBox3.Text),textBox2.Text,textBox4.Text,int.Parse(textBox5.Text),int.Parse(textBox6.Text));
            MessageBox.Show(x + "Model added sucessfully");
            refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as System.Windows.Forms.ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["productname"].ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString() + "Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
