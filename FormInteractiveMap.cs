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
    }
}
