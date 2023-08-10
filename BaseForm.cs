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

namespace SED_real
{
    public partial class BaseForm : Form
    {
        public void UpdateDataDrid()
        {
            DataSedDataContext data = new DataSedDataContext();
            var query = from Bd in data.Base_document
                        join Dk in data.DocumentKind on Bd.DocumentKind equals Dk.ID
                        select new
                        {
                            Bd.Id,
                            Bd.Name,
                            Dk.Name_DocumentKind,
                            Dk.GUID,
                            Bd.Subject,
                            Bd.CreatedDate,
                            Bd.DocumentNumber
                        };
            dataBaseDoc.DataSource = query;
        }
        public BaseForm()
        {
            InitializeComponent();
        }
         

        private void BaseForm_Load(object sender, EventArgs e)
        {
            UpdateDataDrid();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            AddBaseDoc frm = new AddBaseDoc();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            frm.Show();
            
            UpdateDataDrid();
        }
        
        


        private void bt_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataBaseDoc.CurrentRow.Cells[0].Value);
            UpdateBase upfrm = new UpdateBase(id);
            upfrm.txt_NameUP.Text = dataBaseDoc.CurrentRow.Cells[1].Value.ToString();
            upfrm.txt_SubjectUp.Text = dataBaseDoc.CurrentRow.Cells[4].Value.ToString();
            upfrm.txt_DocNumUP.Text = dataBaseDoc.CurrentRow.Cells[6].Value.ToString();
            upfrm.Location = this.Location;
            upfrm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            upfrm.ShowDialog();

            UpdateDataDrid();
        }

        private void LastWeek_Click(object sender, EventArgs e)
        {
            DataSedDataContext data = new DataSedDataContext();
            var date = DateTime.Now.AddDays(-7);
            var query = (from Bd in data.Base_document
                        join Dk in data.DocumentKind on Bd.DocumentKind equals Dk.ID
                        where Bd.CreatedDate >= date
                        select new
                        {
                            Bd.Id,
                            Bd.Name,
                            Dk.Name_DocumentKind,
                            Dk.GUID,
                            Bd.Subject,
                            Bd.CreatedDate,
                            Bd.DocumentNumber
                        });
            dataBaseDoc.DataSource = query;
        }

        private void bt_30day_Click(object sender, EventArgs e)
        {
            DataSedDataContext data = new DataSedDataContext();
            var date = DateTime.Now.AddDays(-30);
            var query = (from Bd in data.Base_document
                         join Dk in data.DocumentKind on Bd.DocumentKind equals Dk.ID
                         where Bd.CreatedDate >= date
                         select new
                         {
                             Bd.Id,
                             Bd.Name,
                             Dk.Name_DocumentKind,
                             Dk.GUID,
                             Bd.Subject,
                             Bd.CreatedDate,
                             Bd.DocumentNumber
                         });
            dataBaseDoc.DataSource = query;
        }

        private void bt_90day_Click(object sender, EventArgs e)
        {
            DataSedDataContext data = new DataSedDataContext();
            var date = DateTime.Now.AddDays(-90);
            var query = (from Bd in data.Base_document
                         join Dk in data.DocumentKind on Bd.DocumentKind equals Dk.ID
                         where Bd.CreatedDate >= date
                         select new
                         {
                             Bd.Id,
                             Bd.Name,
                             Dk.Name_DocumentKind,
                             Dk.GUID,
                             Bd.Subject,
                             Bd.CreatedDate,
                             Bd.DocumentNumber
                         });
            dataBaseDoc.DataSource = query;
        }

        private void Search_Click(object sender, EventArgs e)
        {

            DateTime startDate = dateStart.Value;
            DateTime endDate = dateEnd.Value;
            DataSedDataContext data = new DataSedDataContext();
            var query = (from Bd in data.Base_document
                         join Dk in data.DocumentKind on Bd.DocumentKind equals Dk.ID
                         where Bd.CreatedDate >= startDate
                         && Bd.CreatedDate <= endDate
                         orderby Bd.CreatedDate
                         select new
                            {
                                Bd.Id,
                                Bd.Name,
                                Dk.Name_DocumentKind,
                                Dk.GUID,
                                Bd.Subject,
                                Bd.CreatedDate,
                                Bd.DocumentNumber
                            }).ToList();
            
            if (query.Count>0)
            {
                dataBaseDoc.DataSource = query;
            }
            else
            {
                MessageBox.Show("Данных нет по заданным параметрам");
            }
            
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            UpdateDataDrid();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            var frm = new Main();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }
    }
}
