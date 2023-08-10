namespace SED_real
{
    partial class BaseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Filter_Base = new System.Windows.Forms.Panel();
            this.ClearFilter = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.LastWeek = new System.Windows.Forms.Button();
            this.bt_90day = new System.Windows.Forms.Button();
            this.bt_30day = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBaseDoc = new System.Windows.Forms.DataGridView();
            this.bt_create = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.Filter_Base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // Filter_Base
            // 
            this.Filter_Base.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Filter_Base.Controls.Add(this.ClearFilter);
            this.Filter_Base.Controls.Add(this.Search);
            this.Filter_Base.Controls.Add(this.label3);
            this.Filter_Base.Controls.Add(this.label2);
            this.Filter_Base.Controls.Add(this.dateEnd);
            this.Filter_Base.Controls.Add(this.dateStart);
            this.Filter_Base.Controls.Add(this.LastWeek);
            this.Filter_Base.Controls.Add(this.bt_90day);
            this.Filter_Base.Controls.Add(this.bt_30day);
            this.Filter_Base.Controls.Add(this.label1);
            this.Filter_Base.Dock = System.Windows.Forms.DockStyle.Left;
            this.Filter_Base.Location = new System.Drawing.Point(0, 0);
            this.Filter_Base.Name = "Filter_Base";
            this.Filter_Base.Size = new System.Drawing.Size(200, 314);
            this.Filter_Base.TabIndex = 0;
            // 
            // ClearFilter
            // 
            this.ClearFilter.Location = new System.Drawing.Point(93, 269);
            this.ClearFilter.Name = "ClearFilter";
            this.ClearFilter.Size = new System.Drawing.Size(67, 23);
            this.ClearFilter.TabIndex = 8;
            this.ClearFilter.Text = "Сбросить";
            this.ClearFilter.UseVisualStyleBackColor = true;
            this.ClearFilter.Click += new System.EventHandler(this.ClearFilter_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(10, 269);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(60, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Поиск\r\n";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "По какую дату";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "С какой даты";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(10, 222);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(150, 20);
            this.dateEnd.TabIndex = 6;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(10, 183);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(150, 20);
            this.dateStart.TabIndex = 4;
            // 
            // LastWeek
            // 
            this.LastWeek.Location = new System.Drawing.Point(45, 40);
            this.LastWeek.Name = "LastWeek";
            this.LastWeek.Size = new System.Drawing.Size(72, 23);
            this.LastWeek.TabIndex = 4;
            this.LastWeek.Text = "За неделю\r\n";
            this.LastWeek.UseVisualStyleBackColor = true;
            this.LastWeek.Click += new System.EventHandler(this.LastWeek_Click);
            // 
            // bt_90day
            // 
            this.bt_90day.Location = new System.Drawing.Point(45, 120);
            this.bt_90day.Name = "bt_90day";
            this.bt_90day.Size = new System.Drawing.Size(72, 23);
            this.bt_90day.TabIndex = 5;
            this.bt_90day.Text = "90 дней";
            this.bt_90day.UseVisualStyleBackColor = true;
            this.bt_90day.Click += new System.EventHandler(this.bt_90day_Click);
            // 
            // bt_30day
            // 
            this.bt_30day.Location = new System.Drawing.Point(45, 80);
            this.bt_30day.Name = "bt_30day";
            this.bt_30day.Size = new System.Drawing.Size(73, 23);
            this.bt_30day.TabIndex = 4;
            this.bt_30day.Text = "30 дней";
            this.bt_30day.UseVisualStyleBackColor = true;
            this.bt_30day.Click += new System.EventHandler(this.bt_30day_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фильтр";
            // 
            // dataBaseDoc
            // 
            this.dataBaseDoc.AllowUserToAddRows = false;
            this.dataBaseDoc.AllowUserToDeleteRows = false;
            this.dataBaseDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataBaseDoc.Location = new System.Drawing.Point(200, 0);
            this.dataBaseDoc.Name = "dataBaseDoc";
            this.dataBaseDoc.ReadOnly = true;
            this.dataBaseDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBaseDoc.Size = new System.Drawing.Size(519, 263);
            this.dataBaseDoc.TabIndex = 1;
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(220, 280);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(75, 23);
            this.bt_create.TabIndex = 2;
            this.bt_create.Text = "Создать";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(325, 280);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 3;
            this.bt_Update.Text = "Изменить";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(619, 279);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 23);
            this.bt_back.TabIndex = 4;
            this.bt_back.Text = "Вернуться";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 314);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.dataBaseDoc);
            this.Controls.Add(this.Filter_Base);
            this.MaximumSize = new System.Drawing.Size(735, 353);
            this.MinimumSize = new System.Drawing.Size(735, 353);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Базовый_документ";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Filter_Base.ResumeLayout(false);
            this.Filter_Base.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Filter_Base;
        private System.Windows.Forms.DataGridView dataBaseDoc;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_90day;
        private System.Windows.Forms.Button bt_30day;
        private System.Windows.Forms.Button LastWeek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button ClearFilter;
        private System.Windows.Forms.Button bt_back;
    }
}

