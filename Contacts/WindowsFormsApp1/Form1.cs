using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        private void ClearInputs()
        {
            txtFirstName.Text = "";
            LastName.Text = "";
            txtPhone.Text = "";
        }
        private void LoadContacts()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                richTextBoxContacts.Clear();
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length >= 3)
                    {

                        richTextBoxContacts.AppendText($"name: {parts[0]}، last name: {parts[1]}، phone: {parts[2]}{Environment.NewLine}");
                    }
                }
            }
            else
            {
                richTextBoxContacts.Clear();
            }

        }
        string filePath = "contacts.txt";
        public form1()
        {
            InitializeComponent();
             LoadContacts();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("لطفا همه فیلدها را پر کنید.");
                return;
            }

            string contact = $"{firstName},{lastName},{phone}";

            File.AppendAllLines(filePath, new[] { contact });

            MessageBox.Show("مخاطب با موفقیت ذخیره شد.");

            ClearInputs();
            LoadContacts();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("لطفا نام را وارد کنید تا جستجو انجام شود.");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("هیچ مخاطبی ذخیره نشده است.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            var found = false;
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 3 && (parts[0].Equals(searchName, StringComparison.OrdinalIgnoreCase) || parts[1].Equals(searchName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show($"اطلاعات مخاطب:\nنام: {parts[0]}\nنام خانوادگی: {parts[1]}\nشماره تلفن: {parts[2]}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("این مخاطب وجود ندارد.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
