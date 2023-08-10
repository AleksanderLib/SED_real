namespace SED_real
{
    partial class Income_Documents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Income_Filter = new System.Windows.Forms.Panel();
            this.bt_Counterparty = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Counterparty = new System.Windows.Forms.ComboBox();
            this.bt_DelivFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_FilterDeliv = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.Last_3Mounth = new System.Windows.Forms.Button();
            this.Last_Mounth = new System.Windows.Forms.Button();
            this.bt_Lastweek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataIncomeDocum = new System.Windows.Forms.DataGridView();
            this.bt_CreateInDoc = new System.Windows.Forms.Button();
            this.UpdateInDoc = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Button();
            this.Income_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIncomeDocum)).BeginInit();
            this.SuspendLayout();
            // 
            // Income_Filter
            // 
            this.Income_Filter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Income_Filter.Controls.Add(this.bt_Counterparty);
            this.Income_Filter.Controls.Add(this.label5);
            this.Income_Filter.Controls.Add(this.cb_Counterparty);
            this.Income_Filter.Controls.Add(this.bt_DelivFilter);
            this.Income_Filter.Controls.Add(this.label4);
            this.Income_Filter.Controls.Add(this.cb_FilterDeliv);
            this.Income_Filter.Controls.Add(this.Cancel);
            this.Income_Filter.Controls.Add(this.Search);
            this.Income_Filter.Controls.Add(this.label3);
            this.Income_Filter.Controls.Add(this.label2);
            this.Income_Filter.Controls.Add(this.DateEnd);
            this.Income_Filter.Controls.Add(this.DateStart);
            this.Income_Filter.Controls.Add(this.Last_3Mounth);
            this.Income_Filter.Controls.Add(this.Last_Mounth);
            this.Income_Filter.Controls.Add(this.bt_Lastweek);
            this.Income_Filter.Controls.Add(this.label1);
            this.Income_Filter.Dock = System.Windows.Forms.DockStyle.Left;
            this.Income_Filter.Location = new System.Drawing.Point(0, 0);
            this.Income_Filter.Name = "Income_Filter";
            this.Income_Filter.Size = new System.Drawing.Size(178, 450);
            this.Income_Filter.TabIndex = 0;
            // 
            // bt_Counterparty
            // 
            this.bt_Counterparty.Location = new System.Drawing.Point(12, 387);
            this.bt_Counterparty.Name = "bt_Counterparty";
            this.bt_Counterparty.Size = new System.Drawing.Size(144, 45);
            this.bt_Counterparty.TabIndex = 13;
            this.bt_Counterparty.Text = "Отсортировать контерагента";
            this.bt_Counterparty.UseVisualStyleBackColor = true;
            this.bt_Counterparty.Click += new System.EventHandler(this.bt_Counterparty_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Контерагент";
            // 
            // cb_Counterparty
            // 
            this.cb_Counterparty.FormattingEnabled = true;
            this.cb_Counterparty.Location = new System.Drawing.Point(24, 360);
            this.cb_Counterparty.Name = "cb_Counterparty";
            this.cb_Counterparty.Size = new System.Drawing.Size(121, 21);
            this.cb_Counterparty.TabIndex = 5;
            // 
            // bt_DelivFilter
            // 
            this.bt_DelivFilter.Location = new System.Drawing.Point(12, 317);
            this.bt_DelivFilter.Name = "bt_DelivFilter";
            this.bt_DelivFilter.Size = new System.Drawing.Size(144, 23);
            this.bt_DelivFilter.TabIndex = 11;
            this.bt_DelivFilter.Text = "Найти метод доставки";
            this.bt_DelivFilter.UseVisualStyleBackColor = true;
            this.bt_DelivFilter.Click += new System.EventHandler(this.bt_DelivFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Метод доставки";
            // 
            // cb_FilterDeliv
            // 
            this.cb_FilterDeliv.FormattingEnabled = true;
            this.cb_FilterDeliv.Location = new System.Drawing.Point(24, 290);
            this.cb_FilterDeliv.Name = "cb_FilterDeliv";
            this.cb_FilterDeliv.Size = new System.Drawing.Size(121, 21);
            this.cb_FilterDeliv.TabIndex = 5;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(97, 241);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(3, 241);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 5;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "По какую дату";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "C какой даты";
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(6, 215);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(150, 20);
            this.DateEnd.TabIndex = 8;
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(6, 174);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(150, 20);
            this.DateStart.TabIndex = 5;
            // 
            // Last_3Mounth
            // 
            this.Last_3Mounth.Location = new System.Drawing.Point(42, 121);
            this.Last_3Mounth.Name = "Last_3Mounth";
            this.Last_3Mounth.Size = new System.Drawing.Size(75, 23);
            this.Last_3Mounth.TabIndex = 7;
            this.Last_3Mounth.Text = "90 Дней";
            this.Last_3Mounth.UseVisualStyleBackColor = true;
            this.Last_3Mounth.Click += new System.EventHandler(this.Last_3Mounth_Click);
            // 
            // Last_Mounth
            // 
            this.Last_Mounth.Location = new System.Drawing.Point(42, 81);
            this.Last_Mounth.Name = "Last_Mounth";
            this.Last_Mounth.Size = new System.Drawing.Size(75, 23);
            this.Last_Mounth.TabIndex = 6;
            this.Last_Mounth.Text = "30 Дней";
            this.Last_Mounth.UseVisualStyleBackColor = true;
            this.Last_Mounth.Click += new System.EventHandler(this.Last_Mounth_Click);
            // 
            // bt_Lastweek
            // 
            this.bt_Lastweek.Location = new System.Drawing.Point(42, 39);
            this.bt_Lastweek.Name = "bt_Lastweek";
            this.bt_Lastweek.Size = new System.Drawing.Size(75, 23);
            this.bt_Lastweek.TabIndex = 5;
            this.bt_Lastweek.Text = "За неделю";
            this.bt_Lastweek.UseVisualStyleBackColor = true;
            this.bt_Lastweek.Click += new System.EventHandler(this.bt_Lastweek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фильтр";
            // 
            // dataIncomeDocum
            // 
            this.dataIncomeDocum.AllowUserToAddRows = false;
            this.dataIncomeDocum.AllowUserToDeleteRows = false;
            this.dataIncomeDocum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIncomeDocum.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataIncomeDocum.Location = new System.Drawing.Point(178, 0);
            this.dataIncomeDocum.Name = "dataIncomeDocum";
            this.dataIncomeDocum.ReadOnly = true;
            this.dataIncomeDocum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataIncomeDocum.Size = new System.Drawing.Size(730, 388);
            this.dataIncomeDocum.TabIndex = 1;
            // 
            // bt_CreateInDoc
            // 
            this.bt_CreateInDoc.Location = new System.Drawing.Point(208, 409);
            this.bt_CreateInDoc.Name = "bt_CreateInDoc";
            this.bt_CreateInDoc.Size = new System.Drawing.Size(75, 23);
            this.bt_CreateInDoc.TabIndex = 2;
            this.bt_CreateInDoc.Text = "Создать";
            this.bt_CreateInDoc.UseVisualStyleBackColor = true;
            this.bt_CreateInDoc.Click += new System.EventHandler(this.bt_CreateInDoc_Click);
            // 
            // UpdateInDoc
            // 
            this.UpdateInDoc.Location = new System.Drawing.Point(350, 409);
            this.UpdateInDoc.Name = "UpdateInDoc";
            this.UpdateInDoc.Size = new System.Drawing.Size(75, 23);
            this.UpdateInDoc.TabIndex = 3;
            this.UpdateInDoc.Text = "Изменить";
            this.UpdateInDoc.UseVisualStyleBackColor = true;
            this.UpdateInDoc.Click += new System.EventHandler(this.UpdateInDoc_Click);
            // 
            // bt_Back
            // 
            this.bt_Back.Location = new System.Drawing.Point(812, 409);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(75, 23);
            this.bt_Back.TabIndex = 4;
            this.bt_Back.Text = "Вернуться";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // Income_Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.UpdateInDoc);
            this.Controls.Add(this.bt_CreateInDoc);
            this.Controls.Add(this.dataIncomeDocum);
            this.Controls.Add(this.Income_Filter);
            this.MaximumSize = new System.Drawing.Size(924, 489);
            this.MinimumSize = new System.Drawing.Size(924, 489);
            this.Name = "Income_Documents";
            this.Text = "Входящий документ";
            this.Load += new System.EventHandler(this.Income_Documents_Load);
            this.Income_Filter.ResumeLayout(false);
            this.Income_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIncomeDocum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Income_Filter;
        private System.Windows.Forms.DataGridView dataIncomeDocum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_CreateInDoc;
        private System.Windows.Forms.Button UpdateInDoc;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Button Last_3Mounth;
        private System.Windows.Forms.Button Last_Mounth;
        private System.Windows.Forms.Button bt_Lastweek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button bt_DelivFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_FilterDeliv;
        private System.Windows.Forms.Button bt_Counterparty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Counterparty;
    }
}