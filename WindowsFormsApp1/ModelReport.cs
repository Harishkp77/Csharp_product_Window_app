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
    public partial class ModelReport : Form
    {
        public ModelReport()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();

        private void ModelReport_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dbcon.modelreport();
            dataGridView1.DataSource = dt;
        }
    }
}
