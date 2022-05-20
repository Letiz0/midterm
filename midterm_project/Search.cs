using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace midterm_project
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        } 


        private void Search_Load(object sender, EventArgs e)
        {
            Filter.GetListIn();
            Filter.GetListOut();
            Filter.GetListOpidOut();
            Filter.GetListOpidIn();
            Filter.GetResuldId();

            Sql.Connect();
            string sql = "select email as 信箱, ";
        }
        

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            GlobalVar.formMain.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
