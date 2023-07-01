using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        public void refresh()
        {
            DataTable dt = new DataTable();
            dt = dbcon.viewfulltable();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "productid";
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            refresh();
         
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
           

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                var cb = (sender as System.Windows.Forms.ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["productname"].ToString();
                textBox2.Text = selecteditem["productdescription"].ToString();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString() + "Error");
            }
            
                
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = dbcon.editproduct(int.Parse(comboBox1.Text), textBox1.Text,textBox2.Text);
            MessageBox.Show(x + "update product sucessfully");
            refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
