﻿using System;
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
    public partial class DailySalesReport : Form
    {
        public DailySalesReport()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();
        private void DailySalesReport_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = dbcon.dailyreport();
            dataGridView1.DataSource = dt;
        }
    }
}
