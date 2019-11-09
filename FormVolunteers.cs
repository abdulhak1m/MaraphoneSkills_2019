﻿using System;
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
    public partial class FormVolunteers : Form
    {
        public FormVolunteers()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 10, 12, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона";
        }

        private void FormVolunteers_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormAdmin admin = new FormAdmin();
            admin.ShowDialog();
            Close();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите покинуть свой профиль?", "Оповещение системы!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ActiveForm.Hide();
                FormStart start = new FormStart();
                start.ShowDialog();
                Close();
            }
        }
    }
}
