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
    public partial class FormInteractiveMap : Form
    {
        public FormInteractiveMap()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона";
        }

        private void FormInteractiveMap_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblNum1_Click(object sender, EventArgs e)
        {
            FormCheckPoint1 fp1 = new FormCheckPoint1();
            fp1.ShowDialog();
        }

        private void LblNum2_Click(object sender, EventArgs e)
        {
            FormCheckPoint2 fp2 = new FormCheckPoint2();
            fp2.ShowDialog();
        }

        private void LblNum3_Click(object sender, EventArgs e)
        {
            FormCheckPointMap3 fp3 = new FormCheckPointMap3();
            fp3.ShowDialog();
        }

        private void LblNum4_Click(object sender, EventArgs e)
        {
            FormCheckPoint4 fp4 = new FormCheckPoint4();
            fp4.ShowDialog();
        }

        private void LblNum5_Click(object sender, EventArgs e)
        {
            FormCheckPoint5 fp5 = new FormCheckPoint5();
            fp5.ShowDialog();
        }

        private void LblNum6_Click(object sender, EventArgs e)
        {
            FormCheckPoint6 fp6 = new FormCheckPoint6();
            fp6.ShowDialog();
        }

        private void LblNum7_Click(object sender, EventArgs e)
        {
            FormCheckPoint7 fp7 = new FormCheckPoint7();
            fp7.ShowDialog();
        }

        private void LblNum8_Click(object sender, EventArgs e)
        {
            FormCheckPoint8 fp8 = new FormCheckPoint8();
            fp8.ShowDialog();
        }

        private void Start0_Click(object sender, EventArgs e)
        {
            FormStart01 start0 = new FormStart01();
            start0.ShowDialog();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            FormStart02 start02 = new FormStart02();
            start02.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FormStarts03 starts03 = new FormStarts03();
            starts03.ShowDialog();
        }
    }
}
