using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR_0
{
    public partial class FormLogin : Form
    {
        public static string email;
        public FormLogin()
        {
            InitializeComponent();
            HidePassword();
        }
        // переход обратно в стартувую форму
        private void BtnBack_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите покинуть окно авторизации?", "Уведомление системы!", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.OK)
            {
                ActiveForm.Hide();
                FormStart formStart = new FormStart();
                formStart.ShowDialog();
                Close();
            }
        }

        private void HidePassword()
        {
            txtPassword.TextChanged += (s, e) => { txtPassword.UseSystemPasswordChar = true; };
            showButton.MouseDown += (s, e) => { txtPassword.UseSystemPasswordChar = false; };
            showButton.MouseUp += (s, e) => { txtPassword.UseSystemPasswordChar = true; };
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtEmail.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;

            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона!";
        }

        private void FormLogin_Load(object sender, EventArgs e) =>  timer1.Start();

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {

                try
                {
                    string query = "SELECT * FROM UserPersonalInformation WHERE Email = '" + txtEmail.Text.Trim() + "' and [Password] = '" + txtPassword.Text.Trim() + "'";
                    using (SqlConnection connection = new SqlConnection(Connection.GetSetring()))
                    {
                        await connection.OpenAsync();
                        SqlCommand command1 = new SqlCommand("SELECT * FROM Administration WHERE Email = '" + txtEmail.Text.Trim() + "' and [Password] = '" + txtPassword.Text.Trim() + "'", connection);
                        SqlCommand command = new SqlCommand(query, connection);
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    email = dataReader["Email"].ToString();
                                }
                                ActiveForm.Hide();
                                FormMenuRunner runner = new FormMenuRunner();
                                runner.ShowDialog();
                                Close();
                                return;
                            }
                        }
                        
                        using (SqlDataReader reader = command1.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                ActiveForm.Hide();
                                FormAdmin admin = new FormAdmin();
                                admin.ShowDialog();
                                Close();
                            }
                            else
                                MessageBox.Show("Не верный Email или Пароль. Пожалуйста, повторите попытку!", "Уведомление системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Уведомление системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Заполните поля!", "Уведомление системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
