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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 10, 12, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона";
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите покинуть свой профиль?", "Оповещение системы!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                ActiveForm.Hide();
                FormStart start = new FormStart();
                start.ShowDialog();
                Close();
            }
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormUsers users = new FormUsers();
            users.ShowDialog();
            Close();
        }
    }
}
