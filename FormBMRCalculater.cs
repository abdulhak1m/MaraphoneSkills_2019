using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR_0
{
    public partial class FormBMRCalculater : Form
    {
        public FormBMRCalculater()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона";
        }

        private void FromBMRCalc_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel3.Visible = false;
        }

        private void SwitchFormAbout()
        {
            ActiveForm.Hide();
            FormAbout about = new FormAbout();
            about.ShowDialog();
            Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            SwitchFormAbout();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                MessageBox.Show("BMR - минимальное количество энергии, " +
                    "расходуемое человеческим организмом для поддержания собственной жизни в покое." +
                    " BMR используется в качестве оценки для измерения метаболизма взрослого человека," +
                    " который изменяется в зависимости от роста, веса," +
                    " возраста и различных медицинских факторов.",
                    "Справочный центр.", MessageBoxButtons.OK, MessageBoxIcon.Question);
            });
            thread.Start();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BorderStyle == BorderStyle.FixedSingle && pictureBox2.BorderStyle == BorderStyle.FixedSingle)
            {
                MessageBox.Show("Выберите свой пол, просто нажмите на рисунок с соответствующим обозначением пола",
                    "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (pictureBox1.BorderStyle == BorderStyle.Fixed3D)
                    {
                        double bmr = 66 + (13.7 * Convert.ToDouble(numericUpDown2.Value)) + (5 * Convert.ToDouble(numericUpDown1.Value)) - (6.8 * Convert.ToDouble(numericUpDown3.Value));
                        bmr = bmr / 1000;
                        bmr = Math.Round(bmr, 3);
                        lblBMR.Text = bmr.ToString();

                        panel3.Visible = true;

                        label14.Text = " " + (Math.Round(bmr * 1.2, 2)).ToString();
                        label16.Text = " " + (Math.Round(bmr * 1.375, 2)).ToString();
                        label18.Text = " " + (Math.Round(bmr * 1.55, 2)).ToString();
                        label20.Text = " " + (Math.Round(bmr * 1.725, 2)).ToString();
                        label22.Text = " " + (Math.Round(bmr * 1.9, 2)).ToString();
                    }
                    if (pictureBox2.BorderStyle == BorderStyle.Fixed3D)
                    {
                        double bmr = 655 + (9.6 * Convert.ToDouble(numericUpDown2.Value)) + (1.8 * Convert.ToDouble(numericUpDown1.Value)) - (4.7 * Convert.ToDouble(numericUpDown3.Value));

                        bmr = bmr / 1000;
                        bmr = Math.Round(bmr, 3);
                        lblBMR.Text = bmr.ToString();

                        panel3.Visible = true;

                        label14.Text = " " + (Math.Round(bmr * 1.2, 2)).ToString();
                        label16.Text = " " + (Math.Round(bmr * 1.375, 2)).ToString();
                        label18.Text = " " + (Math.Round(bmr * 1.55, 2)).ToString();
                        label20.Text = " " + (Math.Round(bmr * 1.725, 2)).ToString();
                        label22.Text = " " + (Math.Round(bmr * 1.9, 2)).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormBMRinfo bMRinfo = new FormBMRinfo();
            bMRinfo.ShowDialog();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            SwitchFormAbout();
        }
    }
}
