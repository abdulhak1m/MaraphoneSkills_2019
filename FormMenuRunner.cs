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
    public partial class FormMenuRunner : Form
    {
        public FormMenuRunner()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона";
        }

        private void FormMenuRunner_Load(object sender, EventArgs e) => timer1.Start();

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormStart formStart = new FormStart();
            formStart.ShowDialog();
            Close();
        }

        private void BtnRegitrationRunner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormRegistrationMaraphone formRegistration = new FormRegistrationMaraphone();
            formRegistration.ShowDialog();
            Close();
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
            Close();
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            FormDialogWindowContact formDialog = new FormDialogWindowContact();
            formDialog.ShowDialog();
        }
    }
}
