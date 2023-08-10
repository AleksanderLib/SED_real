namespace SED_real
{
    partial class AddIncDoc
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.txt_DocNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_addressee = new System.Windows.Forms.ComboBox();
            this.cb_Counterparty = new System.Windows.Forms.ComboBox();
            this.cb_DeliveryMethod = new System.Windows.Forms.ComboBox();
            this.cb_CameFrom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_CreateInDoc = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Button();
            this.cb_DocNum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(115, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(123, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(115, 73);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(123, 20);
            this.txt_Subject.TabIndex = 1;
            // 
            // txt_DocNum
            // 
            this.txt_DocNum.Location = new System.Drawing.Point(115, 115);
            this.txt_DocNum.Name = "txt_DocNum";
            this.txt_DocNum.Size = new System.Drawing.Size(123, 20);
            this.txt_DocNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер_документа *";
            // 
            // cb_addressee
            // 
            this.cb_addressee.FormattingEnabled = true;
            this.cb_addressee.Location = new System.Drawing.Point(362, 30);
            this.cb_addressee.Name = "cb_addressee";
            this.cb_addressee.Size = new System.Drawing.Size(121, 21);
            this.cb_addressee.TabIndex = 6;
            // 
            // cb_Counterparty
            // 
            this.cb_Counterparty.FormattingEnabled = true;
            this.cb_Counterparty.Location = new System.Drawing.Point(362, 73);
            this.cb_Counterparty.Name = "cb_Counterparty";
            this.cb_Counterparty.Size = new System.Drawing.Size(121, 21);
            this.cb_Counterparty.TabIndex = 7;
            // 
            // cb_DeliveryMethod
            // 
            this.cb_DeliveryMethod.FormattingEnabled = true;
            this.cb_DeliveryMethod.Location = new System.Drawing.Point(362, 115);
            this.cb_DeliveryMethod.Name = "cb_DeliveryMethod";
            this.cb_DeliveryMethod.Size = new System.Drawing.Size(121, 21);
            this.cb_DeliveryMethod.TabIndex = 8;
            // 
            // cb_CameFrom
            // 
            this.cb_CameFrom.FormattingEnabled = true;
            this.cb_CameFrom.Location = new System.Drawing.Point(360, 157);
            this.cb_CameFrom.Name = "cb_CameFrom";
            this.cb_CameFrom.Size = new System.Drawing.Size(121, 21);
            this.cb_CameFrom.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Адресат *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Контерагент *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Метод доставки *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Откуда пришёл *";
            // 
            // bt_CreateInDoc
            // 
            this.bt_CreateInDoc.Location = new System.Drawing.Point(110, 204);
            this.bt_CreateInDoc.Name = "bt_CreateInDoc";
            this.bt_CreateInDoc.Size = new System.Drawing.Size(85, 31);
            this.bt_CreateInDoc.TabIndex = 14;
            this.bt_CreateInDoc.Text = "Создать";
            this.bt_CreateInDoc.UseVisualStyleBackColor = true;
            this.bt_CreateInDoc.Click += new System.EventHandler(this.bt_CreateInDoc_Click);
            // 
            // bt_Back
            // 
            this.bt_Back.Location = new System.Drawing.Point(306, 204);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(85, 31);
            this.bt_Back.TabIndex = 15;
            this.bt_Back.Text = "Вернуться";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // cb_DocNum
            // 
            this.cb_DocNum.FormattingEnabled = true;
            this.cb_DocNum.Location = new System.Drawing.Point(117, 157);
            this.cb_DocNum.Name = "cb_DocNum";
            this.cb_DocNum.Size = new System.Drawing.Size(121, 21);
            this.cb_DocNum.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Вид документа *";
            // 
            // AddIncDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 260);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_DocNum);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.bt_CreateInDoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_CameFrom);
            this.Controls.Add(this.cb_DeliveryMethod);
            this.Controls.Add(this.cb_Counterparty);
            this.Controls.Add(this.cb_addressee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DocNum);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.txt_name);
            this.MaximumSize = new System.Drawing.Size(547, 299);
            this.MinimumSize = new System.Drawing.Size(547, 299);
            this.Name = "AddIncDoc";
            this.Text = "Создание входящего документа";
            this.Load += new System.EventHandler(this.AddIncDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.TextBox txt_DocNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_addressee;
        private System.Windows.Forms.ComboBox cb_Counterparty;
        private System.Windows.Forms.ComboBox cb_DeliveryMethod;
        private System.Windows.Forms.ComboBox cb_CameFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_CreateInDoc;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.ComboBox cb_DocNum;
        private System.Windows.Forms.Label label8;
    }
}