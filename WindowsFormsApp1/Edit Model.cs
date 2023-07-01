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
    public partial class Edit_Model : Form
    {
        public Edit_Model()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();
        public void refresh()
        {
            DataTable dt = new DataTable();
            dt = dbcon.viewfulltablemodel();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "modelid";
        }
        public void Clear()
        {

            textBox2.Text = "";
           
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
           
        }



        private void Edit_Model_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
                textBox6.Text = selecteditem["stockonhand"].ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            int x = dbcon.editmodel(int.Parse(comboBox1.Text), textBox2.Text,  textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            MessageBox.Show(x + "Model updated sucessfully");
            refresh();
        }

        private void Edit_Model_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
