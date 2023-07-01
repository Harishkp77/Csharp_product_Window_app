using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class user : Form
    {
        public user(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            textBox8.Text = userID;
        }
        private string userID;


        databaseconnect dbcon = new databaseconnect();

        public void Clear()
        {

            //textBox2.Text = "";
            //textBox1.Text = "";
              textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
            //textBox6.Text = "";
           // textBox7.Text = "";

        }
       // public string LoggedInUsername { get; set; }

        public void refresh()
        {
            DataTable dt = new DataTable();
            dt = dbcon.viewfulltablemodel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "modelid";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dbcon.viewfulltable();
            dataGridView1.DataSource = dt;
        }

        private void user_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            //textBox8.Text = LoggedInUsername;
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (sender as System.Windows.Forms.ComboBox);
                var selecteditem = (cb.SelectedItem as DataRowView);
                textBox1.Text = selecteditem["productname"].ToString();
                textBox7.Text = selecteditem["productid"].ToString();
                textBox2.Text = selecteditem["modelname"].ToString();
                textBox4.Text = selecteditem["specification"].ToString();
                textBox5.Text = selecteditem["unitprice"].ToString();
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString() + "Error");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
       
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text.Length > 0)
            {
                textBox6.Text = (int.Parse(textBox3.Text) * int.Parse(textBox5.Text)).ToString();
            }
            else
            {
                textBox6.Text = "";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = dbcon.recordsales(int.Parse(textBox7.Text), textBox1.Text, int.Parse(comboBox1.Text), textBox2.Text, textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox3.Text),int.Parse(textBox6.Text),textBox8.Text);
            MessageBox.Show(x + "sales record added sucessfully");
            refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
