namespace WSR_0
{
    partial class FormUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Users = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.pnl_UserEidt = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.Button();
            this.showConfirmPassword = new System.Windows.Forms.Button();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnl_NewUsers = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.ComboBox();
            this.newSurname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.dataSet = new WSR_0.DataSet();
            this.userPersonalInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userPersonalInformationTableAdapter = new WSR_0.DataSetTableAdapters.UserPersonalInformationTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_UserEidt.SuspendLayout();
            this.pnl_NewUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPersonalInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 87);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(15, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARAPHONE SKILLS 2019";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 557);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 36);
            this.panel2.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(1138, 36);
            this.lblTime.TabIndex = 6;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Silver;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(989, 27);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(96, 33);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Выйти";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // pnl_Users
            // 
            this.pnl_Users.Controls.Add(this.txt_Search);
            this.pnl_Users.Controls.Add(this.label3);
            this.pnl_Users.Controls.Add(this.dataGridView1);
            this.pnl_Users.Controls.Add(this.btn_EditUser);
            this.pnl_Users.Controls.Add(this.btn_addUser);
            this.pnl_Users.Controls.Add(this.label2);
            this.pnl_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Users.Location = new System.Drawing.Point(0, 87);
            this.pnl_Users.Name = "pnl_Users";
            this.pnl_Users.Size = new System.Drawing.Size(1138, 470);
            this.pnl_Users.TabIndex = 7;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(618, 113);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(386, 27);
            this.txt_Search.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Поиск:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 316);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.White;
            this.btn_addUser.FlatAppearance.BorderSize = 0;
            this.btn_addUser.ForeColor = System.Drawing.Color.Black;
            this.btn_addUser.Location = new System.Drawing.Point(14, 23);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(218, 47);
            this.btn_addUser.TabIndex = 11;
            this.btn_addUser.Text = "Добавление нового";
            this.btn_addUser.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Управление пользователями.";
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.BackColor = System.Drawing.Color.White;
            this.btn_EditUser.FlatAppearance.BorderSize = 0;
            this.btn_EditUser.ForeColor = System.Drawing.Color.Black;
            this.btn_EditUser.Location = new System.Drawing.Point(908, 9);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(218, 47);
            this.btn_EditUser.TabIndex = 11;
            this.btn_EditUser.Text = "Редактировать";
            this.btn_EditUser.UseVisualStyleBackColor = false;
            // 
            // pnl_UserEidt
            // 
            this.pnl_UserEidt.Controls.Add(this.showPassword);
            this.pnl_UserEidt.Controls.Add(this.showConfirmPassword);
            this.pnl_UserEidt.Controls.Add(this.txt_ConfirmPassword);
            this.pnl_UserEidt.Controls.Add(this.label13);
            this.pnl_UserEidt.Controls.Add(this.txt_Password);
            this.pnl_UserEidt.Controls.Add(this.label11);
            this.pnl_UserEidt.Controls.Add(this.label10);
            this.pnl_UserEidt.Controls.Add(this.label12);
            this.pnl_UserEidt.Controls.Add(this.lblError);
            this.pnl_UserEidt.Controls.Add(this.btn_Cancel);
            this.pnl_UserEidt.Controls.Add(this.btn_Save);
            this.pnl_UserEidt.Controls.Add(this.cmb_Role);
            this.pnl_UserEidt.Controls.Add(this.txt_Surname);
            this.pnl_UserEidt.Controls.Add(this.label8);
            this.pnl_UserEidt.Controls.Add(this.txt_ID);
            this.pnl_UserEidt.Controls.Add(this.txt_Name);
            this.pnl_UserEidt.Controls.Add(this.label7);
            this.pnl_UserEidt.Controls.Add(this.label14);
            this.pnl_UserEidt.Controls.Add(this.lbl_Email);
            this.pnl_UserEidt.Controls.Add(this.label6);
            this.pnl_UserEidt.Controls.Add(this.label5);
            this.pnl_UserEidt.Controls.Add(this.label4);
            this.pnl_UserEidt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_UserEidt.Location = new System.Drawing.Point(0, 87);
            this.pnl_UserEidt.Name = "pnl_UserEidt";
            this.pnl_UserEidt.Size = new System.Drawing.Size(1138, 470);
            this.pnl_UserEidt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(329, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Редактирование  пользователями.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(210, 175);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(256, 27);
            this.txt_Name.TabIndex = 13;
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Items.AddRange(new object[] {
            "Бегун",
            "Волонтёр"});
            this.cmb_Role.Location = new System.Drawing.Point(210, 264);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(256, 29);
            this.cmb_Role.TabIndex = 14;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Location = new System.Drawing.Point(210, 137);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(256, 27);
            this.lbl_Email.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Имя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Фамилия:";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(210, 221);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(256, 27);
            this.txt_Surname.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Роль:";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(388, 321);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(168, 48);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(583, 321);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(168, 48);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // showPassword
            // 
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.FlatAppearance.BorderSize = 0;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.Image = ((System.Drawing.Image)(resources.GetObject("showPassword.Image")));
            this.showPassword.Location = new System.Drawing.Point(1055, 184);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(25, 25);
            this.showPassword.TabIndex = 25;
            this.showPassword.UseVisualStyleBackColor = true;
            // 
            // showConfirmPassword
            // 
            this.showConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showConfirmPassword.FlatAppearance.BorderSize = 0;
            this.showConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showConfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("showConfirmPassword.Image")));
            this.showConfirmPassword.Location = new System.Drawing.Point(1055, 239);
            this.showConfirmPassword.Name = "showConfirmPassword";
            this.showConfirmPassword.Size = new System.Drawing.Size(25, 25);
            this.showConfirmPassword.TabIndex = 26;
            this.showConfirmPassword.UseVisualStyleBackColor = true;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(795, 237);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(254, 27);
            this.txt_ConfirmPassword.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label13.Location = new System.Drawing.Point(580, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 22);
            this.label13.TabIndex = 18;
            this.label13.Text = "Подтвердите пароль:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(795, 187);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(254, 27);
            this.txt_Password.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label11.Location = new System.Drawing.Point(742, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(352, 44);
            this.label11.TabIndex = 19;
            this.label11.Text = "Оставьте эти поля не запоненными, \r\nесли вы не хотите менять пароль";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label10.Location = new System.Drawing.Point(818, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Смена пароля";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label12.Location = new System.Drawing.Point(703, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Пароль:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(792, 167);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 22;
            // 
            // pnl_NewUsers
            // 
            this.pnl_NewUsers.Controls.Add(this.button3);
            this.pnl_NewUsers.Controls.Add(this.button4);
            this.pnl_NewUsers.Controls.Add(this.confirmPassword);
            this.pnl_NewUsers.Controls.Add(this.label9);
            this.pnl_NewUsers.Controls.Add(this.newPassword);
            this.pnl_NewUsers.Controls.Add(this.label15);
            this.pnl_NewUsers.Controls.Add(this.label16);
            this.pnl_NewUsers.Controls.Add(this.label17);
            this.pnl_NewUsers.Controls.Add(this.btnCancel);
            this.pnl_NewUsers.Controls.Add(this.btnSave);
            this.pnl_NewUsers.Controls.Add(this.role);
            this.pnl_NewUsers.Controls.Add(this.newSurname);
            this.pnl_NewUsers.Controls.Add(this.label18);
            this.pnl_NewUsers.Controls.Add(this.txt_Email);
            this.pnl_NewUsers.Controls.Add(this.newName);
            this.pnl_NewUsers.Controls.Add(this.label19);
            this.pnl_NewUsers.Controls.Add(this.label21);
            this.pnl_NewUsers.Controls.Add(this.label22);
            this.pnl_NewUsers.Controls.Add(this.label23);
            this.pnl_NewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_NewUsers.Location = new System.Drawing.Point(0, 87);
            this.pnl_NewUsers.Name = "pnl_NewUsers";
            this.pnl_NewUsers.Size = new System.Drawing.Size(1138, 470);
            this.pnl_NewUsers.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1018, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 45;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1018, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 46;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(758, 271);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(254, 27);
            this.confirmPassword.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label9.Location = new System.Drawing.Point(543, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 22);
            this.label9.TabIndex = 38;
            this.label9.Text = "Подтвердите пароль:";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(758, 221);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(254, 27);
            this.newPassword.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label15.Location = new System.Drawing.Point(791, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 23);
            this.label15.TabIndex = 40;
            this.label15.Text = "Новый пароль";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label16.Location = new System.Drawing.Point(666, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 22);
            this.label16.TabIndex = 41;
            this.label16.Text = "Пароль:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(755, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 42;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(583, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 48);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(388, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 48);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Бегун",
            "Волонтёр"});
            this.role.Location = new System.Drawing.Point(172, 275);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(256, 29);
            this.role.TabIndex = 35;
            // 
            // newSurname
            // 
            this.newSurname.Location = new System.Drawing.Point(172, 232);
            this.newSurname.Name = "newSurname";
            this.newSurname.Size = new System.Drawing.Size(256, 27);
            this.newSurname.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(116, 275);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 21);
            this.label18.TabIndex = 31;
            this.label18.Text = "Роль:";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(172, 194);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(256, 27);
            this.newName.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(81, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 21);
            this.label19.TabIndex = 30;
            this.label19.Text = "Фамилия:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(119, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 21);
            this.label21.TabIndex = 28;
            this.label21.Text = "Имя:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(111, 154);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 21);
            this.label22.TabIndex = 32;
            this.label22.Text = "Email:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label23.Location = new System.Drawing.Point(334, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(470, 33);
            this.label23.TabIndex = 27;
            this.label23.Text = "Добавление нового пользователя";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(172, 151);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(256, 27);
            this.txt_Email.TabIndex = 33;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userPersonalInformationBindingSource
            // 
            this.userPersonalInformationBindingSource.DataMember = "UserPersonalInformation";
            this.userPersonalInformationBindingSource.DataSource = this.dataSet;
            // 
            // userPersonalInformationTableAdapter
            // 
            this.userPersonalInformationTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(157, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(210, 94);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(256, 27);
            this.txt_ID.TabIndex = 13;
            // 
            // FormUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 593);
            this.Controls.Add(this.pnl_NewUsers);
            this.Controls.Add(this.pnl_UserEidt);
            this.Controls.Add(this.pnl_Users);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl_Users.ResumeLayout(false);
            this.pnl_Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_UserEidt.ResumeLayout(false);
            this.pnl_UserEidt.PerformLayout();
            this.pnl_NewUsers.ResumeLayout(false);
            this.pnl_NewUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPersonalInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pnl_Users;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Panel pnl_UserEidt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Button showConfirmPassword;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnl_NewUsers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.TextBox newSurname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_Email;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource userPersonalInformationBindingSource;
        private DataSetTableAdapters.UserPersonalInformationTableAdapter userPersonalInformationTableAdapter;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label14;
    }
}