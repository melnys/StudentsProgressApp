using System;
using System.Windows.Forms;

namespace StudentsProgressApp
{
    public partial class Registration : Form
    {
        public string UserName { get; private set; }
        public Registration()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            string login = txtLog.Text;
            string password = txtPass.Text;

            if (password == "admin123")
            {
                MainTch mainTch = new MainTch(login);
                this.Hide();
                mainTch.Show();
                MessageBox.Show("Ви зайшли в аккаунт викладача!", $"Вітаю, {login}!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (password == "user123")
            {
                MainSt mainSt = new MainSt(login);
                this.Hide();
                mainSt.Show();
                MessageBox.Show("Ви зайшли в аккаунт студента!", $"Вітаю, {login}!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (string.IsNullOrWhiteSpace(txtLog.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Будь ласка, введіть логін та пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (txtPass.Text != "admin123" || txtPass.Text != "user123")
            {
                MessageBox.Show("Неправильний пароль! Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserName = txtLog.Text;

        }

        private void InfoLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ім'я: Мельничук Софія Дмитрівна \nгрупа: БІКСб12340 \nспеціальність: кібербезпека 2 курс", "Інформація про автора");
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви точно хочете вийти?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {
                return;
            }
        }
    }
}
