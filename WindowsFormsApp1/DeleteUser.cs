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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }
        databaseconnect dbcon = new databaseconnect();
        public void refresh()
        {
            DataTable dt = new DataTable();
            dt = dbcon.viewfulltableuser();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "userid";
        }


        private void DeleteUser_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = dbcon.deleteuserbyid(comboBox1.Text);
            MessageBox.Show(x + " User deleted sucessfully");
            refresh();


        }
    }
}
