using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_project
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Hide();
            GlobalVar.form1.Show();
        }
    }
}
