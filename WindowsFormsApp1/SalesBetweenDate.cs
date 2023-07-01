using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SalesBetweenDate : Form
    {
        public SalesBetweenDate()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();
        private void SalesBetweenDate_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dbcon.salesreport();
            dataGridView1.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            DataTable dt = new DataTable();
            dt = dbcon.salesreportbtwn(startDate,endDate);
            dataGridView1.DataSource = dt;

        }
    }
}
