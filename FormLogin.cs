using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR_0
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            HidePassword();
        }
        // переход обратно в стартувую форму
        private void BtnBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите покинуть окно авторизации?", "Уведомление системы!", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.OK)
            {
                ActiveForm.Hide();
                FormStart formStart = new FormStart();
                formStart.ShowDialog();
                Close();
            }
        }

        private void HidePassword()
        {
            txtPassword.TextChanged += (s, e) => { txtPassword.UseSystemPasswordChar = true; };
            showButton.MouseDown += (s, e) => { txtPassword.UseSystemPasswordChar = false; };
            showButton.MouseUp += (s, e) => { txtPassword.UseSystemPasswordChar = true; };
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtEmail.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;

            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormLogin_Load(object sender, EventArgs e) =>  timer1.Start();
    }
}
