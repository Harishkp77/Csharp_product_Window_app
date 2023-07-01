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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
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

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = dbcon.deleteproductbyid(int.Parse(comboBox1.Text));
            MessageBox.Show(x + "Product deleted sucessfully");
            refresh();
        }
    }
}
