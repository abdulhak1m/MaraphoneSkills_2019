using System;
using WSR_0;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WSR_0
{
    public partial class FormEditProfile : Form
    {
        public FormEditProfile()
        {
            InitializeComponent();
            PassowrdBox(txt_Password, showPassword);
            PassowrdBox(txt_ConfirmPassword, showConfirmPassword);
            txt_ConfirmPassword.TextChanged += (s, e) => { PasswordCheck(); };
            txt_Password.TextChanged += (s, e) => 
            {
                if (txt_ConfirmPassword.Text != "")
                    PasswordCheck();
            };
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTimer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта марафона";
        }
        private void PassowrdBox(TextBox textBox, Button button)
        {
            textBox.TextChanged += (s, e) => { textBox.UseSystemPasswordChar = true; };
            button.MouseDown += (s, e) => { textBox.UseSystemPasswordChar = false; };
            button.MouseUp += (s, e) => { textBox.UseSystemPasswordChar = true; };
        }
        private async void FormEditProfile_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.GetSetring()))
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand("SELECT * from UserPersonalInformation  where Email = '" + FormLogin.email + "'", connection);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lblEmail.Text = dataReader["Email"].ToString();
                            txt_name.Text = dataReader["Name"].ToString();
                            txt_Surname.Text = dataReader["Surname"].ToString();
                            cmb_Gender.Text = dataReader["Gender"].ToString();
                            dtp_DateOfBirth.Value = Convert.ToDateTime(dataReader["Date"]);
                            cmb_Country.Text = dataReader["County"].ToString();
                            txt_FileName.Text = dataReader["Picture_name"].ToString();
                            byte[] byteArray = new byte[0];
                            byteArray = (byte[])dataReader["Image"];
                            MemoryStream ms = new MemoryStream(byteArray);
                            this.pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                            ms.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SwitchFormMenu()
        {
            ActiveForm.Hide();
            FormMenuRunner formMenuRunner = new FormMenuRunner();
            formMenuRunner.ShowDialog();
            Close();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            SwitchFormMenu();
        }

        private void Btn_logOut_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormStart formStart = new FormStart();
            formStart.ShowDialog();
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            SwitchFormMenu();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void Open()
        {
            try
            {
                ofd.InitialDirectory = @"C:\Users\magom\Pictures";
                ofd.Filter = "Image Files (*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF| All Files(*.*)|*.*";
                ofd.FilterIndex = 2;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    txt_FileName.Text = ofd.SafeFileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла исключение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void PasswordCheck()
        {
            if(txt_Password.Text != txt_ConfirmPassword.Text)
            {
                lblError.Text = "Внимание, пароль не совпадает!";
                btn_Save.Enabled = false;
            }
            else
            {
                lblError.Text = "";
                btn_Save.Enabled = true;
            }
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                using (Font myFont = new Font("Century Gothic", 20))
                {
                    e.Graphics.DrawString("Фото", myFont, Brushes.Gray, new Point(2, 2));
                }
            }
        }

        private async void Btn_Save_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();

            if (txt_Password.Text != "")
            {
                bool digit = false;
                bool spec = false;
                bool lowChar = false;

                for (int i = 0; i < txt_Password.TextLength; i++)
                {
                    if (char.IsDigit(txt_Password.Text[i]))
                    {
                        digit = true;
                        break;
                    }
                }
                for (int i = 0; i < txt_Password.TextLength; i++)
                {
                    if (char.IsLower(txt_Password.Text[i]))
                    {
                        lowChar = true;
                        break;
                    }
                }
                for (int i = 0; i < txt_Password.TextLength; i++)
                {
                    if (txt_Password.Text[i] == '#' || txt_Password.Text[i] == '!' || txt_Password.Text[i] == '@' || txt_Password.Text[i] == '$' || txt_Password.Text[i] == '%' || txt_Password.Text[i] == '^')
                    {
                        spec = true;
                        break;
                    }
                }
                if (txt_Password.TextLength < 6 || !spec || !digit || !lowChar)
                    MessageBox.Show("Некорректный формат пароля! Длина пароля должно быть не менее шести символов, из которых должна быть, как минимум, одна буква нижнего регистра, одна цифра и одна из следующих символов: !,#,%,^,@", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DateTime dateOfBirth = Convert.ToDateTime(dtp_DateOfBirth.Value);
            if (DateTime.Now.Year - dateOfBirth.Year < 10)
                MessageBox.Show("Возраст бегуна на момент регистрации должен быть не менее 10-ти лет!", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(Connection.GetSetring()))
                    {
                        await connection.OpenAsync();
                        SqlCommand command = new SqlCommand("UPDATE UserPersonalInformation SET Email = @e, [Name]=@n, [Surname]=@s, [Gender]=@g,[Picture_name]=@pn, [Image]=@picture, [Date]=@d, [County]=@cn where Email = '" + FormLogin.email + "'", connection);
                        command.Parameters.AddWithValue("@e", lblEmail.Text);
                        if(txt_Password.Text != "")
                            command.Parameters.AddWithValue(txt_Password.Text, txt_Password.Text);
                        command.Parameters.AddWithValue("@n", txt_name.Text);
                        command.Parameters.AddWithValue("@s", txt_Surname.Text);
                        command.Parameters.AddWithValue("@g", cmb_Gender.Text);
                        command.Parameters.AddWithValue("@pn", txt_FileName.Text);
                        command.Parameters.AddWithValue("@picture", a);
                        command.Parameters.AddWithValue("@d", dtp_DateOfBirth.Value);
                        command.Parameters.AddWithValue("@cn", cmb_Country.Text);
                        await command.ExecuteNonQueryAsync();
                        MessageBox.Show("Сохранение изменений, прошло успешно!", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        SwitchFormMenu();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
