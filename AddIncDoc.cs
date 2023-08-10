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
    public partial class AddIncDoc : Form
    {
        public AddIncDoc()
        {
            InitializeComponent();

        }
        private void LoadData()
        {
            DataSedDataContext data = new DataSedDataContext();
            var query = data.Addressee.Select(c => new { c.ID, c.FIO_Addressee });
            cb_addressee.DataSource = query.ToList();
            cb_addressee.ValueMember = "ID";
            cb_addressee.DisplayMember = "FIO_Addressee";
            var queryCounter = data.Counterparty.Select(c => new { c.ID, c.Name_Counterparty });
            cb_Counterparty.DataSource = queryCounter.ToList();
            cb_Counterparty.ValueMember = "ID";
            cb_Counterparty.DisplayMember = "Name_Counterparty";
            var queryDilivery = data.DeliveryMethod.Select(c => new { c.ID, c.Name_DeliveryMethod });
            cb_DeliveryMethod.DataSource = queryDilivery.ToList();
            cb_DeliveryMethod.ValueMember = "ID";
            cb_DeliveryMethod.DisplayMember = "Name_DeliveryMethod";
            var queryComeFrom = data.CameFrom.Select(c => new { c.ID, c.Name_CameFrom });
            cb_CameFrom.DataSource = queryComeFrom.ToList();
            cb_CameFrom.ValueMember = "ID";
            cb_CameFrom.DisplayMember = "Name_CameFrom";
            var queryDocNum = data.DocumentKind.Select(c => new { c.ID, c.Name_DocumentKind });
            cb_DocNum.DataSource = queryDocNum.ToList();
            cb_DocNum.ValueMember = "ID";
            cb_DocNum.DisplayMember = "Name_DocumentKind";
        }
        private void Clear()
        {
            txt_DocNum.Text = "";
            txt_name.Text = "";
            txt_Subject.Text = "";
            cb_CameFrom.SelectedIndex = 0;
            cb_addressee.SelectedIndex = 0;
            cb_Counterparty.SelectedIndex = 0;
            cb_DeliveryMethod.SelectedIndex = 0;
            cb_DocNum.SelectedIndex = 0;
        }
        private void AddIncDoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_CreateInDoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) ||
                string.IsNullOrEmpty(txt_DocNum.Text) ||
                string.IsNullOrEmpty(cb_addressee.Text) ||
                string.IsNullOrEmpty(cb_CameFrom.Text) ||
                string.IsNullOrEmpty(cb_Counterparty.Text) ||
                string.IsNullOrEmpty(cb_DeliveryMethod.Text) ||
                string.IsNullOrEmpty(cb_DocNum.Text))
            {
                MessageBox.Show("Заполниет обязательные поля *");
            }
            else {
                DataSedDataContext ds = new DataSedDataContext();
                Incoming_Document newindoc = new Incoming_Document();
                newindoc.Name = txt_name.Text;
                newindoc.Subject = txt_Subject.Text;
                newindoc.DocumentNumber = txt_DocNum.Text;
                newindoc.Addressee = (int)cb_addressee.SelectedValue;
                newindoc.CameFrom = (int)cb_CameFrom.SelectedValue;
                newindoc.Counterparty = (int)cb_Counterparty.SelectedValue;
                newindoc.DeliveryMethod = (int)cb_DeliveryMethod.SelectedValue;
                newindoc.DocumentKind = (int)cb_DocNum.SelectedValue;
                newindoc.CreatedDate = DateTime.Now;

                ds.Incoming_Document.InsertOnSubmit(newindoc);
                ds.SubmitChanges();

                MessageBox.Show("Документ создан");
                Clear();
            }

        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            var frm = new Income_Documents();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Close();
        }
    }
}
