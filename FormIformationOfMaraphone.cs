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
    public partial class FormIformationOfMaraphone : Form
    {
        public FormIformationOfMaraphone()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormAbout about = new FormAbout();
            about.ShowDialog();
            Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона";
        }

        private void FormIformationOfMaraphone_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FormInteractiveMap interactiveMap = new FormInteractiveMap();
            interactiveMap.ShowDialog();
        }
    }
}
