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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pRODUCTREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProduct viewp = new ViewProduct();
            viewp.Show();
        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void pRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addp = new AddProduct();
            addp.Show();
        }

        private void eDITPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
          EditProduct editp = new EditProduct();
            editp.Show();
        }

        private void dELETEPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct deletep = new DeleteProduct();
            deletep.Show();
        }

        private void vIEWPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProduct viewp = new ViewProduct();  
            viewp.Show();
        }

        private void aDDMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddModel addm = new AddModel();
            addm.Show();
        }

        private void eDITMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Model editm = new Edit_Model();
            editm.Show();
        }

        private void mODELToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dELETEMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteModel deletem = new DeleteModel();
            deletem.Show();
        }

        private void vIEWMODELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel viewm = new ViewModel();  
            viewm.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();    
            addUser.Show();
        }

        private void eDITUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.Show();
        }

        private void dELETEUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.Show();
        }

        private void vIEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser viewUser = new ViewUser(); 
            viewUser.Show();
        }

        private void dAILYSALESREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailySalesReport dsr = new DailySalesReport();
            dsr.Show();
        }

        private void mODELREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelReport modelReport = new ModelReport();
            modelReport.Show();
        }

        private void rEPORTSBYDATESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesBetweenDate sbd = new SalesBetweenDate();
            sbd.Show();
        }
    }
}
