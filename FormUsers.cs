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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
            btn_addUser.Click += (s, e) => { pnl_NewUsers.BringToFront(); };
            btn_Cancel.Click += (s, e) => { pnl_Users.BringToFront(); };
            btnCancel.Click += (s, e) => { pnl_Users.BringToFront(); };
            pnl_Users.BringToFront();
            btn_EditUser.Click += (s, e) => { pnl_UserEidt.BringToFront(); };
            PassowrdBox(txt_Password, showPassword);
            PassowrdBox(txt_ConfirmPassword, showConfirmPassword);
            txt_ConfirmPassword.TextChanged += (s, e) => { CheckPassword(); };
            txt_Password.TextChanged += (s, e) =>
            {
                if (txt_ConfirmPassword.Text != "")
                    CheckPassword();
            };
        }
        private void CheckPassword()
        {
            if (txt_Password.Text != txt_ConfirmPassword.Text)
            {
                lblError.Text = "Внимание, пароли не совпадают!";
                btnSave.Enabled = false;
            }
            else
            {
                lblError.Text = "";
                btnSave.Enabled = true;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneTime = new DateTime(2019, 12, 10, 6, 0, 0);
            TimeSpan totalTime = maraphoneTime - DateTime.Now;
            lblTime.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона";
        }
        private new void Refresh()
        {
            DataTable dt = Select();
            dataGridView1.DataSource = dt;
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.UserPersonalInformation". При необходимости она может быть перемещена или удалена.
            this.userPersonalInformationTableAdapter.Fill(this.dataSet.UserPersonalInformation);
            timer1.Start();
            Refresh();
        }

        public new DataTable Select()
        {
            DataTable data = new DataTable();
            try
            {
                using(SqlConnection connection = new SqlConnection(Connection.GetSetring()))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT UserPersonalInformation.id, UserPersonalInformation.[Name], UserPersonalInformation.[Surname], UserPersonalInformation.[Email], UserPersonalInformation.[Password] FROM UserPersonalInformation", connection);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(data);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return data;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти из системы!", "Оповещение системы!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                ActiveForm.Hide();
                FormStart start = new FormStart();
                start.ShowDialog();
                Close();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FormAdmin admin = new FormAdmin();
            admin.ShowDialog();
            Close();
        }
        private void PassowrdBox(TextBox textBox, Button button)
        {
            textBox.TextChanged += (s, e) => { textBox.UseSystemPasswordChar = true; };
            button.MouseDown += (s, e) => { textBox.UseSystemPasswordChar = false; };
            button.MouseUp += (s, e) => { textBox.UseSystemPasswordChar = true; };
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_ID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            lbl_Email.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Surname.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private async void Btn_Save_Click(object sender, EventArgs e)
        {
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
            try
            {
                string query = $"UPDATE UserPersonalInformation SET Email = '{lbl_Email.Text}', [Name]='{txt_Name.Text}', [Surname]='{txt_Surname.Text}' WHERE id='{int.Parse(txt_ID.Text)}'";
                using (SqlConnection connection = new SqlConnection(Connection.GetSetring()))
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (txt_Password.Text != "")
                        command.Parameters.AddWithValue(txt_Password.Text, txt_Password.Text);
                    MessageBox.Show("Сохранение прошло успешно!", "Оповещение системы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnl_Users.BringToFront();
                    Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }
}
