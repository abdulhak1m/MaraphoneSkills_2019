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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }
        // переход в форму авторизации пользователя
        private void LoginButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;

            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }
        // запускаем таймер
        private void FormStart_Load(object sender, EventArgs e) => timer1.Start();

        private void BtnSB_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormCheck formCheck = new FormCheck();
            formCheck.ShowDialog();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            //FormRegistrationMaraphone formRegistrationMaraphone = new FormRegistrationMaraphone();
            //formRegistrationMaraphone.ShowDialog();
            //Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            //FormMenuRunner formMenuRunner = new FormMenuRunner();
            //formMenuRunner.ShowDialog();
            //Close();
        }
    }
}
