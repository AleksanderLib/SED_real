using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SED_real
{
    public partial class UpdateIncDoc : Form
    {
        int id_;
        public UpdateIncDoc(int id)
        {
            InitializeComponent();
            id_= id;
        }

        private void disable()
        {
            txt_DocNum.Enabled = false;
            txt_name.Enabled = false;
            txt_Subject.Enabled = false;
            cb_addressee.Enabled = false;
            cb_CameFrom.Enabled = false;
            cb_Counterparty.Enabled = false;
            cb_DeliveryMethod.Enabled = false;
            cb_DocKind.Enabled = false;
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
            cb_DocKind.DataSource = queryDocNum.ToList();
            cb_DocKind.ValueMember = "ID";
            cb_DocKind.DisplayMember = "Name_DocumentKind";
        }
        private bool state = false;
        private void bt_UpdateDoc_Click(object sender, EventArgs e)
        {
            

            Incoming_Document Check = QueryCheck();
            if (Check == null)
            {
                if (string.IsNullOrEmpty(txt_name.Text) ||
                string.IsNullOrEmpty(txt_DocNum.Text) ||
                string.IsNullOrEmpty(cb_addressee.Text) ||
                string.IsNullOrEmpty(cb_CameFrom.Text) ||
                string.IsNullOrEmpty(cb_Counterparty.Text) ||
                string.IsNullOrEmpty(cb_DeliveryMethod.Text) ||
                string.IsNullOrEmpty(cb_DocKind.Text))
                {
                    MessageBox.Show("Заполниет обязательные поля *");
                }
                else
                {
                    DataSedDataContext data = UpCheckData();
                    data.SubmitChanges();
                    MessageBox.Show("Обновление прошло успешно");
                    state = true;
                    disable();
                }
            }
            else
            {
                string ChName, ChSubject, ChDocNum;
                int ChDocKind, ChAddress, ChCameFrom, ChCounter, ChDeliveryMethod;
                CheckMethod(Check, out ChName, out ChSubject, out ChDocNum, out ChDocKind, out ChAddress, out ChCameFrom, out ChCounter, out ChDeliveryMethod);
                if (txt_DocNum.Text == ChDocNum &&
                        txt_name.Text == ChName &&
                        txt_Subject.Text == ChSubject &&
                        (int)cb_DocKind.SelectedValue == ChDocKind &&
                        (int)cb_CameFrom.SelectedValue == ChCameFrom &&
                        (int)cb_addressee.SelectedValue == ChAddress &&
                        (int)cb_Counterparty.SelectedValue == ChCounter &&
                        (int)cb_DeliveryMethod.SelectedValue == ChDeliveryMethod)
                {
                    MessageBox.Show("Данные не были изменены");
                }
            }

        }

        private DataSedDataContext UpCheckData()
        {
            DataSedDataContext data = new DataSedDataContext();
            Incoming_Document IncomDoc = data.Incoming_Document.FirstOrDefault(s => s.Id.Equals(id_));
            IncomDoc.Name = txt_name.Text;
            IncomDoc.Subject = txt_Subject.Text;
            IncomDoc.DocumentNumber = txt_DocNum.Text;
            IncomDoc.DocumentKind = (int)cb_DocKind.SelectedValue;
            IncomDoc.Addressee = (int)cb_addressee.SelectedValue;
            IncomDoc.CameFrom = (int)cb_CameFrom.SelectedValue;
            IncomDoc.Counterparty = (int)cb_Counterparty.SelectedValue;
            IncomDoc.DeliveryMethod = (int)cb_DeliveryMethod.SelectedValue;
            return data;
        }

        private Incoming_Document QueryCheck()
        {
            DataSedDataContext context = new DataSedDataContext();
            var Check = context.Incoming_Document.Where(n => n.Name == txt_name.Text &&
                                                       n.DocumentNumber == txt_DocNum.Text &&
                                                       n.Subject == txt_Subject.Text &&
                                                       n.DocumentKind == (int)cb_DocKind.SelectedValue &&
                                                       n.Addressee == (int)cb_addressee.SelectedValue &&
                                                       n.Counterparty == (int)cb_Counterparty.SelectedValue &&
                                                       n.CameFrom == (int)cb_CameFrom.SelectedValue &&
                                                       n.DeliveryMethod == (int)cb_DeliveryMethod.SelectedValue).FirstOrDefault();
            return Check;
        }

        private static void CheckMethod(Incoming_Document Check, out string ChName, out string ChSubject, out string ChDocNum, out int ChDocKind, out int ChAddress, out int ChCameFrom, out int ChCounter, out int ChDeliveryMethod)
        {
            ChName = Check.Name;
            ChSubject = Check.Subject;
            ChDocNum = Check.DocumentNumber;
            ChDocKind = Check.DocumentKind;
            ChAddress = Check.Addressee;
            ChCameFrom = Check.CameFrom;
            ChCounter = Check.Counterparty;
            ChDeliveryMethod = Check.DeliveryMethod;
        }

        private void UpdateIncDoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                var frm = new Income_Documents();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы не сохранили данные.Хотите продолжить работу ", "Предупреждение!!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    var frm = new Income_Documents();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.Show();
                    this.Close();
                }
            }
        }
    }
}
