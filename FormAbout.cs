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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона";
        }

        private void Btn_BMI_calc_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormBMICalculator BMI = new FormBMICalculator();
            BMI.ShowDialog();
            Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormStart start = new FormStart();
            start.ShowDialog();
            Close();
        }

        private void Btn_BMR_calc_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormBMRCalculater BMR = new FormBMRCalculater();
            BMR.ShowDialog();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormIformationOfMaraphone infoMaraphone = new FormIformationOfMaraphone();
            infoMaraphone.ShowDialog();
            Close();
        }
    }
}
