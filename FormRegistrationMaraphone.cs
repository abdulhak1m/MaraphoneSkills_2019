using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WSR_0
{
    public partial class FormRegistrationMaraphone : Form
    {
        public string email;
        public string runnerId;
        public int value;
        public FormRegistrationMaraphone()
        {
            InitializeComponent();
            cmb_contribution.SelectedIndex = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;

            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormStart formStart = new FormStart();
            formStart.ShowDialog();
            Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                value = Convert.ToInt32(label15.Text);
                value += 0;
                label15.Text = value.ToString();
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                value = Convert.ToInt32(label15.Text);
                value += 20;
                label15.Text = value.ToString();
            }
            else
                label15.Text = (value - 20).ToString();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                value = Convert.ToInt32(label15.Text);
                value += 45;
                label15.Text = value.ToString();
            }
            else
                label15.Text = (value - 45).ToString();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                value = Convert.ToInt32(label15.Text);
                value += 145;
                label15.Text = value.ToString();
            }
            else
                label15.Text = (value - 145).ToString();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                value = Convert.ToInt32(label15.Text);
                value += 75;
                label15.Text = value.ToString();
            }
            else
                label15.Text = (value - 75).ToString();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                value = Convert.ToInt32(label15.Text);
                value += 20;
                label15.Text = value.ToString();
            }
            else
                label15.Text = (value - 20).ToString();
        }

        private void Txt_installment_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private async void SignupButton_Click(object sender, EventArgs e)
        {
            if (txt_installment_amount.Text == "" || cmb_contribution.Text == "")
                MessageBox.Show("Пожалуйста, выберите спонсора из числа благотворительных организаций и внесите сумму спонсорского взноса", "Оповещение системы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
                    MessageBox.Show("Пожалуйста, выберите один из представленных марафонов!", "Оповещение системы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        string query = $"insert into SponsorInformation values (@c, @p)";
                        using (SqlConnection connection = new SqlConnection(Connection.GetSetring()))
                        {
                            await connection.OpenAsync();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@c", cmb_contribution.Text);
                            command.Parameters.AddWithValue("@p", int.Parse(label15.Text));
                            await command.ExecuteNonQueryAsync();
                            pnlDoneRegistr.BringToFront();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Txt_installment_amount_TextChanged(object sender, EventArgs e)
        {
            value = Convert.ToInt32(label15.Text);
            value = Convert.ToInt32(txt_installment_amount.Text);
            label15.Text = value.ToString();
        }

        private void FormRegistrationMaraphone_Load(object sender, EventArgs e) => timer1.Start();

        private void OkButton_Click(object sender, EventArgs e)
        {
            SwitchFormStart();
        }
        private void SwitchFormStart()
        {
            ActiveForm.Hide();
            FormMenuRunner formMenuRunner = new FormMenuRunner();
            formMenuRunner.ShowDialog();
            Close();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            SwitchFormStart();
        }
    }
}
