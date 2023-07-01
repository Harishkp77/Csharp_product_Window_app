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
    public partial class DeleteModel : Form
    {
        public DeleteModel()
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

        private void DeleteModel_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = dbcon.deletemodelbyid(int.Parse(comboBox1.Text));
            MessageBox.Show(x + "Model deleted sucessfully");
            refresh();
        }
    }
}
