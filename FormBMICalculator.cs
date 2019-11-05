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
    public partial class FormBMICalculator : Form
    {
        public FormBMICalculator()
        {
            InitializeComponent();
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона";
        }

        private void FormBMICalculator_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
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

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            decimal bmi = 0;
            try
            {
                bmi = numericUpDown2.Value / (numericUpDown1.Value * numericUpDown1.Value) * 10000;
                bmi = Math.Round(bmi, 2);
                if(Convert.ToDouble(bmi) < 18.5)
                {
                    panel7.Visible = true;
                    panel10.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    lblInsufficient.Text = bmi.ToString();
                    pictureBox3.Image = Properties.Resources.bmi_underweight_icon;
                }
                if(Convert.ToDouble(bmi) >= 18.5 && Convert.ToDouble(bmi) <= 24.9)
                {
                    panel8.Visible = true;
                    panel10.Visible = false;
                    panel7.Visible = false;
                    panel9.Visible = false;
                    lblHealthy.Text = bmi.ToString();
                    pictureBox3.Image = Properties.Resources.bmi_healthy_icon;
                }
                if(Convert.ToDouble(bmi) >=25 && Convert.ToDouble(bmi) <= 29.9)
                {
                    panel9.Visible = true;
                    panel10.Visible = false;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    lblExcess.Text = bmi.ToString();
                    pictureBox3.Image = Properties.Resources.bmi_overweight_icon;
                }
                if(Convert.ToDouble(bmi) >= 30)
                {
                    panel10.Visible = true;
                    panel7.Visible = false;
                    panel8.Visible = false;
                    panel9.Visible = false;
                    lblObesity.Text = bmi.ToString();
                    pictureBox3.Image = Properties.Resources.bmi_obese_icon;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Source, "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            SwitchFormAbout();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            Thread thread = new Thread(
                delegate ()
                {
                    MessageBox.Show("BMI обозначает индекс массы тела. " +
                "Он используется, чтобя дать понять Вам представление о том, " +
                "является ли Ваш вес избыточным или идеальным для Вашего роста." +
                "Это полезно знать, потому что если Ваш вес увеличивается или " +
                "уменьшается за пределами идеального диапазона, у Вас повышается риск заболеть.",
                "Справочный центр.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                });
            thread.Start();
        }
    }
}
