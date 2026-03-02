using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using LR5_s8.UsersClasses;
using System.Windows.Forms;



namespace LR5_s8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBoxEmail.Text = "olezasinnicyn@mail.ru";
            textBoxName.Text = "Вещий Олег";
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private bool IsNullOrWhiteSpaceTextBox()
        {

            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxSubject.Text) || string.IsNullOrWhiteSpace(textBoxBody.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return true;
            }
            return false;
        }
        private void TextBoxIsCleaning()
        {
            DialogResult result = MessageBox.Show("Очистить все поля ввода?", "Сообщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
        }
        private InfoEmail SetInfoEmail(EmailsTypes type)
        {
            StringPair toInfo = new StringPair(textBoxEmail.Text, textBoxName.Text);
            string subject = textBoxSubject.Text;
            string body = $"{DateTime.Now} \n" + $"{Dns.GetHostName()} \n" + $"{Dns.GetHostAddresses(Dns.GetHostName()).First()} \n" +
                $"{textBoxBody.Text}";
            if (type == EmailsTypes.GMail)
                return new InfoGMail(toInfo, subject, body);
            else
                return new InfoMailRu(toInfo, subject, body);
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (IsNullOrWhiteSpaceTextBox())
                return;
            try
            {
                SendingEmail sendingEmail1 = new SendingEmail(SetInfoEmail(comboBox1.SelectedItem.ToString() == "GMail" ? EmailsTypes.GMail : EmailsTypes.MailRu));
                sendingEmail1.Send();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Письмо отправлено!");
            TextBoxIsCleaning();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
