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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();

        private void ViewUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dbcon.viewfulltableuser();
            dataGridView1.DataSource = dt;
        }
    }
}
