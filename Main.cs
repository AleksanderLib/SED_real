using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SED_real
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bt_BaseDoc_Click(object sender, EventArgs e)
        {
            var frm = new BaseForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void bt_IncDoc_Click(object sender, EventArgs e)
        {
            var frm = new Income_Documents();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
