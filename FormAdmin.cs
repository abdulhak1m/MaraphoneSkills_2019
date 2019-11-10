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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + "минут до старта Марафона";
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormUsers users = new FormUsers();
            users.ShowDialog();
            users.Close();
        }
    }
}
