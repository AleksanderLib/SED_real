namespace SED_real
{
    partial class UpdateBase
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
            this.label3 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NameUP = new System.Windows.Forms.TextBox();
            this.txt_SubjectUp = new System.Windows.Forms.TextBox();
            this.txt_DocNumUP = new System.Windows.Forms.TextBox();
            this.bt_SaveUp = new System.Windows.Forms.Button();
            this.bt_backUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_DocKind = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер документа";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(31, 99);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(57, 13);
            this.Subject.TabIndex = 12;
            this.Subject.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя";
            // 
            // txt_NameUP
            // 
            this.txt_NameUP.Location = new System.Drawing.Point(109, 42);
            this.txt_NameUP.Name = "txt_NameUP";
            this.txt_NameUP.Size = new System.Drawing.Size(122, 20);
            this.txt_NameUP.TabIndex = 14;
            // 
            // txt_SubjectUp
            // 
            this.txt_SubjectUp.Location = new System.Drawing.Point(109, 96);
            this.txt_SubjectUp.Name = "txt_SubjectUp";
            this.txt_SubjectUp.Size = new System.Drawing.Size(122, 20);
            this.txt_SubjectUp.TabIndex = 15;
            // 
            // txt_DocNumUP
            // 
            this.txt_DocNumUP.Location = new System.Drawing.Point(109, 151);
            this.txt_DocNumUP.Name = "txt_DocNumUP";
            this.txt_DocNumUP.Size = new System.Drawing.Size(122, 20);
            this.txt_DocNumUP.TabIndex = 16;
            // 
            // bt_SaveUp
            // 
            this.bt_SaveUp.Location = new System.Drawing.Point(21, 246);
            this.bt_SaveUp.Name = "bt_SaveUp";
            this.bt_SaveUp.Size = new System.Drawing.Size(75, 23);
            this.bt_SaveUp.TabIndex = 17;
            this.bt_SaveUp.Text = "Сохранить";
            this.bt_SaveUp.UseVisualStyleBackColor = true;
            this.bt_SaveUp.Click += new System.EventHandler(this.bt_SaveUp_Click);
            // 
            // bt_backUp
            // 
            this.bt_backUp.Location = new System.Drawing.Point(156, 246);
            this.bt_backUp.Name = "bt_backUp";
            this.bt_backUp.Size = new System.Drawing.Size(75, 23);
            this.bt_backUp.TabIndex = 18;
            this.bt_backUp.Text = "Вернуться";
            this.bt_backUp.UseVisualStyleBackColor = true;
            this.bt_backUp.Click += new System.EventHandler(this.bt_backUp_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Вид документа";
            // 
            // cb_DocKind
            // 
            this.cb_DocKind.FormattingEnabled = true;
            this.cb_DocKind.Location = new System.Drawing.Point(109, 204);
            this.cb_DocKind.Name = "cb_DocKind";
            this.cb_DocKind.Size = new System.Drawing.Size(122, 21);
            this.cb_DocKind.TabIndex = 19;
            // 
            // UpdateBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_DocKind);
            this.Controls.Add(this.bt_backUp);
            this.Controls.Add(this.bt_SaveUp);
            this.Controls.Add(this.txt_DocNumUP);
            this.Controls.Add(this.txt_SubjectUp);
            this.Controls.Add(this.txt_NameUP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(275, 331);
            this.MinimumSize = new System.Drawing.Size(275, 331);
            this.Name = "UpdateBase";
            this.Text = "Измение";
            this.Load += new System.EventHandler(this.UpdateBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_NameUP;
        public System.Windows.Forms.TextBox txt_SubjectUp;
        public System.Windows.Forms.TextBox txt_DocNumUP;
        private System.Windows.Forms.Button bt_SaveUp;
        private System.Windows.Forms.Button bt_backUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_DocKind;
    }
}