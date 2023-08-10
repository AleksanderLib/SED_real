namespace SED_real
{
    partial class AddBaseDoc
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_DocNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Create = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.cb_DocKind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(116, 43);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(153, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(116, 100);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(153, 20);
            this.txt_subject.TabIndex = 1;
            // 
            // txt_DocNumber
            // 
            this.txt_DocNumber.Location = new System.Drawing.Point(116, 161);
            this.txt_DocNumber.Name = "txt_DocNumber";
            this.txt_DocNumber.Size = new System.Drawing.Size(153, 20);
            this.txt_DocNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(38, 103);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(57, 13);
            this.Subject.TabIndex = 4;
            this.Subject.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер документа";
            // 
            // bt_Create
            // 
            this.bt_Create.Location = new System.Drawing.Point(41, 259);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(75, 23);
            this.bt_Create.TabIndex = 6;
            this.bt_Create.Text = "Создать";
            this.bt_Create.UseVisualStyleBackColor = true;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(169, 259);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 23);
            this.bt_back.TabIndex = 7;
            this.bt_back.Text = "Вернуться";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // cb_DocKind
            // 
            this.cb_DocKind.FormattingEnabled = true;
            this.cb_DocKind.Location = new System.Drawing.Point(116, 209);
            this.cb_DocKind.Name = "cb_DocKind";
            this.cb_DocKind.Size = new System.Drawing.Size(153, 21);
            this.cb_DocKind.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вид документа";
            // 
            // AddBaseDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_DocKind);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DocNumber);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_Name);
            this.MaximumSize = new System.Drawing.Size(330, 353);
            this.MinimumSize = new System.Drawing.Size(330, 353);
            this.Name = "AddBaseDoc";
            this.Text = "Создать_документ";
            this.Load += new System.EventHandler(this.AddBaseDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.TextBox txt_DocNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Create;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.ComboBox cb_DocKind;
        private System.Windows.Forms.Label label2;
    }
}