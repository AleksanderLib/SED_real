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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SED_real
{
    public partial class AddBaseDoc : Form
    {
        
        public AddBaseDoc()
        {
            InitializeComponent();
        }
        private void bt_Create_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_Name.Text) || 
                string.IsNullOrEmpty(txt_DocNumber.Text) || 
                string.IsNullOrEmpty(cb_DocKind.Text))
            {
                MessageBox.Show("Заполните обязательные поля *");
            }
            else
            {
                DataSedDataContext ds = new DataSedDataContext();
                Base_document newbase = new Base_document();
                newbase.Name = txt_Name.Text;
                newbase.Subject = txt_subject.Text;
                newbase.DocumentNumber = txt_DocNumber.Text;
                newbase.DocumentKind = (int)cb_DocKind.SelectedValue;
                newbase.CreatedDate = DateTime.Now;
                ds.Base_document.InsertOnSubmit(newbase);
                ds.SubmitChanges();

                MessageBox.Show("Документ создан");
            }

        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            var frm = new BaseForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Close();
        }

        private void AddBaseDoc_Load(object sender, EventArgs e)
        {
            DataSedDataContext data = new DataSedDataContext();
            var queryDocNum = data.DocumentKind.Select(c => new { c.ID, c.Name_DocumentKind });
            cb_DocKind.DataSource = queryDocNum.ToList();
            cb_DocKind.ValueMember = "ID";
            cb_DocKind.DisplayMember = "Name_DocumentKind";
        }
    }
}
