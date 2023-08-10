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
    public partial class UpdateBase : Form
    {
        private int id_;
        public UpdateBase(int id)
        {
            InitializeComponent();
            id_= id;
        }


       private bool state = false;
        private void bt_SaveUp_Click(object sender, EventArgs e)
        {
            
            DataSedDataContext context = new DataSedDataContext();
            var Check = context.Base_document.Where(n => n.Name == txt_NameUP.Text &&
                                                       n.DocumentNumber == txt_DocNumUP.Text &&
                                                       n.Subject == txt_SubjectUp.Text &&
                                                       n.DocumentKind == (int)cb_DocKind.SelectedValue).FirstOrDefault();
            if (Check == null)
            {
                if (string.IsNullOrEmpty(txt_NameUP.Text) ||
                  string.IsNullOrEmpty(txt_SubjectUp.Text) ||
                  string.IsNullOrEmpty(txt_DocNumUP.Text))
                {
                    MessageBox.Show("Поля пустые, обновление не возможно");
                }
                else
                {
                    DataSedDataContext data = UpdateData();
                    data.SubmitChanges();
                    MessageBox.Show("Обновление прошло успешно");
                    state = true;
                    Disable();
                }
            }
            else
            {
                string checkName, checkDocNumber, checkSubject;
                int checkDocKind;
                ChekUpdate(Check, out checkName, out checkDocNumber, out checkSubject, out checkDocKind);
                if (txt_NameUP.Text == checkName &&
                    txt_SubjectUp.Text == checkSubject &&
                    txt_DocNumUP.Text == checkDocNumber &&
                    (int)cb_DocKind.SelectedValue == checkDocKind)
                {
                    MessageBox.Show("Данные не были изменены");
                }
            }
        }

        private static void ChekUpdate(Base_document Check, out string checkName, out string checkDocNumber, out string checkSubject, out int checkDocKind)
        {
            checkName = Check.Name;
            checkDocNumber = Check.DocumentNumber;
            checkSubject = Check.Subject;
            checkDocKind = Check.DocumentKind;
        }

        private void Disable()
        {
            txt_NameUP.Enabled = false;
            txt_SubjectUp.Enabled = false;
            txt_DocNumUP.Enabled = false;
            cb_DocKind.Enabled = false;
        }

        private DataSedDataContext UpdateData()
        {
            DataSedDataContext data = new DataSedDataContext();
            Base_document base_Document = data.Base_document.FirstOrDefault(bd => bd.Id.Equals(id_));
            base_Document.Name = txt_NameUP.Text;
            base_Document.Subject = txt_SubjectUp.Text;
            base_Document.DocumentNumber = txt_DocNumUP.Text;
            base_Document.DocumentKind = (int)cb_DocKind.SelectedValue;
            return data;
        }

        private void bt_backUp_Click_1(object sender, EventArgs e)
        {
            if (state == true)
            {
                var frm = new BaseForm();
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
                    var frm = new BaseForm();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.Show();
                    this.Close();
                }
            }
            
        }

        private void UpdateBase_Load(object sender, EventArgs e)
        {
            DataSedDataContext data = new DataSedDataContext();
            var queryDocNum = data.DocumentKind.Select(c => new { c.ID, c.Name_DocumentKind });
            cb_DocKind.DataSource = queryDocNum.ToList();
            cb_DocKind.ValueMember = "ID";
            cb_DocKind.DisplayMember = "Name_DocumentKind";
        }
    }
}
