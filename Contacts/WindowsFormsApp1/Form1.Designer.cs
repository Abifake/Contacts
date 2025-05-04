namespace WindowsFormsApp1
{
    partial class form1
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
            this.index = new System.Windows.Forms.GroupBox();
            this.phone = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.richTextBoxContacts = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.index.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // index
            // 
            this.index.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.index.Controls.Add(this.phone);
            this.index.Controls.Add(this.LastName);
            this.index.Controls.Add(this.name);
            this.index.Controls.Add(this.txtPhone);
            this.index.Controls.Add(this.txtFirstName);
            this.index.Controls.Add(this.txtLastName);
            this.index.Controls.Add(this.btnAdd);
            this.index.ForeColor = System.Drawing.Color.LavenderBlush;
            this.index.Location = new System.Drawing.Point(167, 225);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(621, 154);
            this.index.TabIndex = 0;
            this.index.TabStop = false;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(495, 116);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(58, 13);
            this.phone.TabIndex = 7;
            this.phone.Text = "شماره تلفن";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(495, 74);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(69, 13);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "نام خانوادگی";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(495, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(20, 13);
            this.name.TabIndex = 5;
            this.name.Text = "نام";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(229, 113);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(218, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(20, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(427, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(20, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(427, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(20, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ذخیره";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.ForeColor = System.Drawing.Color.Olive;
            this.btnSearch.Location = new System.Drawing.Point(27, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBoxContacts
            // 
            this.richTextBoxContacts.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBoxContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.richTextBoxContacts.Location = new System.Drawing.Point(12, 37);
            this.richTextBoxContacts.Name = "richTextBoxContacts";
            this.richTextBoxContacts.Size = new System.Drawing.Size(776, 160);
            this.richTextBoxContacts.TabIndex = 10;
            this.richTextBoxContacts.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 154);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(131, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(380, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Abifake";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBoxContacts);
            this.Controls.Add(this.index);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Name = "form1";
            this.Text = "مخاطبین";
            this.index.ResumeLayout(false);
            this.index.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox index;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox richTextBoxContacts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}

