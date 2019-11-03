using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR_0
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            PassowrdBox(txt_Password, showPassword);
            PassowrdBox(txt_ConfirmPassword, showConfirmPassword);
            txt_ConfirmPassword.TextChanged += (s, e) => { CheckPassword(); };
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;

            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов " + totalTime.Minutes + " минут до старта марафона";
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            timer1.Start();

            ofd.Filter = "Image Files |*.jpg;*.png;*gif;";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormStart formStart = new FormStart();
            formStart.ShowDialog();
            Close();
        }

        private void CheckPassword()
        {
            if(txt_Password.Text != txt_ConfirmPassword.Text)
            {
                lblError.Text = "Внимание, пароли не совпадают!";
                signupButton.Enabled = false;
            }
            else
            {
                lblError.Text = "";
                signupButton.Enabled = true;
            }
        }

        private void PassowrdBox(TextBox textBox, Button button)
        {
            textBox.TextChanged += (s, e) => { textBox.UseSystemPasswordChar = true; };
            button.MouseDown += (s, e) => { textBox.UseSystemPasswordChar = false; };
            button.MouseUp += (s, e) => { textBox.UseSystemPasswordChar = true; };
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormStart formStart = new FormStart();
            formStart.ShowDialog();
            Close();
        }

        private void Open()
        {
            try
            {
                ofd.InitialDirectory = @"C:\Users\magom\Pictures";
                ofd.Filter = "Image Files (*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF| All Files(*.*)|*.*";
                ofd.FilterIndex = 2;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    txt_NamePicture.Text = ofd.SafeFileName.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_ShowPicture_Click(object sender, EventArgs e)
        {
            Open();
        }


        private async void SignupButton_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();

            try
            {
                Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
                Match emailMatch = emailRegex.Match(txt_Email.Text);
                if (emailMatch.Value == "")
                    MessageBox.Show("Некорректный формат email", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool digit = false;
                    bool spec = false;
                    bool lowChar = false;

                    for(int i = 0; i < txt_Password.TextLength; i++)
                    {
                        if (Char.IsDigit(txt_Password.Text[i]))
                        {
                            digit = true;
                            break;
                        }
                    }
                    for(int i = 0; i < txt_Password.TextLength; i++)
                    {
                        if (Char.IsLower(txt_Password.Text[i]))
                        {
                            lowChar = true;
                            break;
                        }
                    }
                    for(int i = 0; i < txt_Password.TextLength; i++)
                    {
                        if(txt_Password.Text[i] == '#' || txt_Password.Text[i] == '!'|| txt_Password.Text[i] == '@' || txt_Password.Text[i] == '$' || txt_Password.Text[i] == '%' || txt_Password.Text[i] == '^')
                        {
                            spec = true;
                            break;
                        }
                    }
                    if (txt_Password.TextLength < 6 || !spec || !digit || !lowChar)
                        MessageBox.Show("Некорректный формат пароля! Длина пароля должно быть не менее шести символов, из которых должна быть, как минимум, одна буква нижнего регистра, одна цифра и одна из следующих символов: !,#,%,^,@", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DateTime dateOfBirth = Convert.ToDateTime(txt_DateOfBirth.Value);
                    if (DateTime.Now.Year - dateOfBirth.Year < 10)
                        MessageBox.Show("Возраст бегуна на момент регистрации должен быть не менее 10-ти лет!", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        using(SqlConnection connection = new SqlConnection(Connection.GetSetring()))
                        {
                            await connection.OpenAsync();
                            string query = $"insert into UserPersonalInformation values (@e,@p,@n,@s,@g,@pn,@picture,@d,@cn)";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@e", txt_Email.Text);
                            command.Parameters.AddWithValue("@p", txt_Password.Text);
                            command.Parameters.AddWithValue("@n", txt_Name.Text);
                            command.Parameters.AddWithValue("@s", txt_Surname.Text);
                            command.Parameters.AddWithValue("@g", cmb_Gender.Text);
                            command.Parameters.AddWithValue("@pn", txt_NamePicture.Text);
                            command.Parameters.AddWithValue("@picture", a);
                            command.Parameters.AddWithValue("@d", txt_DateOfBirth.Value);
                            command.Parameters.AddWithValue("@cn", cmb_Country.Text);
                            await command.ExecuteNonQueryAsync();

                            ActiveForm.Hide();
                            FormRegistrationMaraphone formRegistrationMaraphone = new FormRegistrationMaraphone();
                            formRegistrationMaraphone.ShowDialog();
                            Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
