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
    public partial class Income_Documents : Form
    {
        public Income_Documents()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            DataSedDataContext data = new DataSedDataContext();
            var queryDilivery = data.DeliveryMethod.Select(c => new { c.ID, c.Name_DeliveryMethod });
            cb_FilterDeliv.DataSource = queryDilivery.ToList();
            cb_FilterDeliv.ValueMember = "ID";
            cb_FilterDeliv.DisplayMember = "Name_DeliveryMethod";
            var queryCounter = data.Counterparty.Select(c => new { c.ID, c.Name_Counterparty });
            cb_Counterparty.DataSource = queryCounter.ToList();
            cb_Counterparty.ValueMember = "ID";
            cb_Counterparty.DisplayMember = "Name_Counterparty";
        }

        private void UpdateDataIncomeDoc()
        {
            DataSedDataContext data = new DataSedDataContext();
            var query = from InDoc in data.Incoming_Document
                        join Dk in data.DocumentKind on InDoc.DocumentKind equals Dk.ID
                        join A in data.Addressee on InDoc.Addressee equals A.ID
                        join Cp in data.Counterparty on InDoc.Counterparty equals Cp.ID
                        join Dm in data.DeliveryMethod on InDoc.DeliveryMethod equals Dm.ID
                        join Cf in data.CameFrom on InDoc.CameFrom equals Cf.ID
                        select new
                        {
                            InDoc.Id,
                            InDoc.Name,
                            Discriminator = Dk.GUID ,
                            Dk.Name_DocumentKind,
                            InDoc.Subject,
                            InDoc.CreatedDate,
                            InDoc.DocumentNumber,
                            A.FIO_Addressee,
                            Cp.Name_Counterparty,
                            Dm.Name_DeliveryMethod,
                            Cf.Name_CameFrom
                        };
            dataIncomeDocum.DataSource = query;
        }
        private void Income_Documents_Load(object sender, EventArgs e)
        {
            UpdateDataIncomeDoc();
        }

        private void bt_CreateInDoc_Click(object sender, EventArgs e)
        {
            AddIncDoc frm = new AddIncDoc();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frm.Show();
        }

        private void bt_Lastweek_Click(object sender, EventArgs e)
        {
            DataSedDataContext data = new DataSedDataContext();
            var date = DateTime.Now.AddDays(-7);
            var query = from InDoc in data.Incoming_Document
                        join Dk in data.DocumentKind on InDoc.DocumentKind equals Dk.ID
                        join A in data.Addressee on InDoc.Addressee equals A.ID
                        join Cp in data.Counterparty on InDoc.Counterparty equals Cp.ID
                        join Dm in data.DeliveryMethod on InDoc.DeliveryMethod equals Dm.ID
                        join Cf in data.CameFrom on InDoc.CameFrom equals Cf.ID
                        where InDoc.CreatedDate >= date
                        select new
                        {
                            InDoc.Id,
                            InDoc.Name,
                            Discriminator = Dk.GUID,
                            Dk.Name_DocumentKind,
                            InDoc.Subject,
                            InDoc.CreatedDate,
                            InDoc.DocumentNumber,
                            A.FIO_Addressee,
                            Cp.Name_Counterparty,
                            Dm.Name_DeliveryMethod,
                            Cf.Name_CameFrom
                        };
            dataIncomeDocum.DataSource = query;
        }

        private void Last_Mounth_Click(object sender, EventArgs e)
        {
            DataSedDataContext data = new DataSedDataContext();
            var date = DateTime.Now.AddDays(-30);
            var query = from InDoc in data.Incoming_Document
                        join Dk in data.DocumentKind on InDoc.DocumentKind equals Dk.ID
                        join A in data.Addressee on InDoc.Addressee equals A.ID
                        join Cp in data.Counterparty on InDoc.Counterparty equals Cp.ID
                        join Dm in data.DeliveryMethod on InDoc.DeliveryMethod equals Dm.ID
                        join Cf in data.CameFrom on InDoc.CameFrom equals Cf.ID
                        where InDoc.CreatedDate >= date
                        select new
                        {
                            InDoc.Id,
                            InDoc.Name,
                            Discriminator = Dk.GUID,
                            Dk.Name_DocumentKind,
                            InDoc.Subject,
                            InDoc.CreatedDate,
                            InDoc.DocumentNumber,
                            A.FIO_Addressee,
                            Cp.Name_Counterparty,
                            Dm.Name_DeliveryMethod,
                            Cf.Name_CameFrom
                        };
            dataIncomeDocum.DataSource = query;
        }

        private void Last_3Mounth_Click(object sender, EventArgs e)
        {
            DataSedDataContext data = new DataSedDataContext();
            var date = DateTime.Now.AddDays(-90);
            var query = from InDoc in data.Incoming_Document
                        join Dk in data.DocumentKind on InDoc.DocumentKind equals Dk.ID
                        join A in data.Addressee on InDoc.Addressee equals A.ID
                        join Cp in data.Counterparty on InDoc.Counterparty equals Cp.ID
                        join Dm in data.DeliveryMethod on InDoc.DeliveryMethod equals Dm.ID
                        join Cf in data.CameFrom on InDoc.CameFrom equals Cf.ID
                        where InDoc.CreatedDate >= date
                        select new
                        {
                            InDoc.Id,
                            InDoc.Name,
                            Discriminator = Dk.GUID,
                            Dk.Name_DocumentKind,
                            InDoc.Subject,
                            InDoc.CreatedDate,
                            InDoc.DocumentNumber,
                            A.FIO_Addressee,
                            Cp.Name_Counterparty,
                            Dm.Name_DeliveryMethod,
                            Cf.Name_CameFrom
                        };
            dataIncomeDocum.DataSource = query;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DateTime StartDate = DateStart.Value;
            DateTime EndDate = DateEnd.Value;
            DataSedDataContext data = new DataSedDataContext();
            var query = (from InDoc in data.Incoming_Document
                        join Dk in data.DocumentKind on InDoc.DocumentKind equals Dk.ID
                        join A in data.Addressee on InDoc.Addressee equals A.ID
                        join Cp in data.Counterparty on InDoc.Counterparty equals Cp.ID
                        join Dm in data.DeliveryMethod on InDoc.DeliveryMethod equals Dm.ID
                        join Cf in data.CameFrom on InDoc.CameFrom equals Cf.ID
                        where InDoc.CreatedDate >= StartDate && InDoc.CreatedDate <= EndDate
                        select new
                        {
                            InDoc.Id,
                            InDoc.Name,
                            Discriminator = Dk.GUID,
                            Dk.Name_DocumentKind,
                            InDoc.Subject,
                            InDoc.CreatedDate,
                            InDoc.DocumentNumber,
                            A.FIO_Addressee,
                            Cp.Name_Counterparty,
                            Dm.Name_DeliveryMethod,
                            Cf.Name_CameFrom
                        }).ToList();
            
            if (query.Count > 0)
            {
                dataIncomeDocum.DataSource = query;
            }
            else
            {
                MessageBox.Show("Данных нет по заданным параметрам");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            UpdateDataIncomeDoc();
        }

        private void bt_DelivFilter_Click(object sender, EventArgs e)
        {
            int methodDeliv = (int)cb_FilterDeliv.SelectedValue;
            DataSedDataContext data = new DataSedDataContext();
            var query = (from InDoc in data.Incoming_Document
                        join Dk in data.DocumentKind on InDoc.DocumentKind equals Dk.ID
                        join A in data.Addressee on InDoc.Addressee equals A.ID
                        join Cp in data.Counterparty on InDoc.Counterparty equals Cp.ID
                        join Dm in data.DeliveryMethod on InDoc.DeliveryMethod equals Dm.ID
                        join Cf in data.CameFrom on InDoc.CameFrom equals Cf.ID
                        where Dm.ID == methodDeliv
                        select new
                        {
                            InDoc.Id,
                            InDoc.Name,
                            Discriminator = Dk.GUID,
                            Dk.Name_DocumentKind,
                            InDoc.Subject,
                            InDoc.CreatedDate,
                            InDoc.DocumentNumber,
                            A.FIO_Addressee,
                            Cp.Name_Counterparty,
                            Dm.Name_DeliveryMethod,
                            Cf.Name_CameFrom
                        }).ToList();
            if (query.Count > 0)
            {
                dataIncomeDocum.DataSource = query;
            }
            else
            {
                MessageBox.Show("Данных нет по заданным параметрам");
            }
            
        }

        private void bt_Counterparty_Click(object sender, EventArgs e)
        {
            int CounterPar = (int)cb_Counterparty.SelectedValue;
            DataSedDataContext data = new DataSedDataContext();
            var query = (from InDoc in data.Incoming_Document
                        join Dk in data.DocumentKind on InDoc.DocumentKind equals Dk.ID
                        join A in data.Addressee on InDoc.Addressee equals A.ID
                        join Cp in data.Counterparty on InDoc.Counterparty equals Cp.ID
                        join Dm in data.DeliveryMethod on InDoc.DeliveryMethod equals Dm.ID
                        join Cf in data.CameFrom on InDoc.CameFrom equals Cf.ID
                        where Cp.ID == CounterPar
                        select new
                        {
                            InDoc.Id,
                            InDoc.Name,
                            Discriminator = Dk.GUID,
                            Dk.Name_DocumentKind,
                            InDoc.Subject,
                            InDoc.CreatedDate,
                            InDoc.DocumentNumber,
                            A.FIO_Addressee,
                            Cp.Name_Counterparty,
                            Dm.Name_DeliveryMethod,
                            Cf.Name_CameFrom
                        }).ToList();
            if (query.Count > 0)
            {
                dataIncomeDocum.DataSource = query;
            }
            else
            {
                MessageBox.Show("Данных нет по заданным параметрам");
            }
            
        }

        private void UpdateInDoc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataIncomeDocum.CurrentRow.Cells[0].Value);
            UpdateIncDoc upfrm = new UpdateIncDoc(id);
            upfrm.txt_name.Text = dataIncomeDocum.CurrentRow.Cells[1].Value.ToString();
            upfrm.txt_Subject.Text = dataIncomeDocum.CurrentRow.Cells[4].Value.ToString();
            upfrm.txt_DocNum.Text = dataIncomeDocum.CurrentRow.Cells[6].Value.ToString();
            upfrm.cb_DocKind.SelectedValue = dataIncomeDocum.CurrentRow.Cells[3].Value;
            upfrm.cb_addressee.SelectedValue = dataIncomeDocum.CurrentRow.Cells[7].Value;
            upfrm.cb_Counterparty.SelectedValue = dataIncomeDocum.CurrentRow.Cells[8].Value;
            upfrm.cb_DeliveryMethod.SelectedValue = dataIncomeDocum.CurrentRow.Cells[9].Value;
            upfrm.cb_CameFrom.SelectedValue = dataIncomeDocum.CurrentRow.Cells[10].Value;
            upfrm.Location = this.Location;
            upfrm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            upfrm.ShowDialog();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            var frm = new Main();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Close();
        }
    }
}
