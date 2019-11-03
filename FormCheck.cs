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
    public partial class FormCheck : Form
    {
        public FormCheck()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormStart formStart = new FormStart();
            formStart.ShowDialog();
            Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;

            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона";
        }

        private void FormCheck_Load(object sender, EventArgs e) => timer1.Start();

        private void Button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.ShowDialog();
            Close();
        }
    }
}
