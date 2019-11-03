namespace WSR_0
{
    partial class FormMenuRunner
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRegitrationRunner = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnMyResult = new System.Windows.Forms.Button();
            this.btn_MySponsor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 87);
            this.panel1.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(15, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(330, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARAPHONE SKILLS 2019";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 36);
            this.panel2.TabIndex = 8;
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(0, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(1029, 36);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnRegitrationRunner
            // 
            this.btnRegitrationRunner.BackColor = System.Drawing.Color.White;
            this.btnRegitrationRunner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegitrationRunner.Location = new System.Drawing.Point(174, 198);
            this.btnRegitrationRunner.Name = "btnRegitrationRunner";
            this.btnRegitrationRunner.Size = new System.Drawing.Size(313, 49);
            this.btnRegitrationRunner.TabIndex = 9;
            this.btnRegitrationRunner.Text = "Регистрация на марафон";
            this.btnRegitrationRunner.UseVisualStyleBackColor = false;
            this.btnRegitrationRunner.Click += new System.EventHandler(this.BtnRegitrationRunner_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.White;
            this.btnEditProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditProfile.Location = new System.Drawing.Point(174, 265);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(313, 49);
            this.btnEditProfile.TabIndex = 9;
            this.btnEditProfile.Text = "Редактирование профиля";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.White;
            this.btnContact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContact.Location = new System.Drawing.Point(174, 338);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(313, 49);
            this.btnContact.TabIndex = 9;
            this.btnContact.Text = "Контакты";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // btnMyResult
            // 
            this.btnMyResult.BackColor = System.Drawing.Color.White;
            this.btnMyResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMyResult.Location = new System.Drawing.Point(542, 198);
            this.btnMyResult.Name = "btnMyResult";
            this.btnMyResult.Size = new System.Drawing.Size(313, 49);
            this.btnMyResult.TabIndex = 9;
            this.btnMyResult.Text = "Мои результаты";
            this.btnMyResult.UseVisualStyleBackColor = false;
            // 
            // btn_MySponsor
            // 
            this.btn_MySponsor.BackColor = System.Drawing.Color.White;
            this.btn_MySponsor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MySponsor.Location = new System.Drawing.Point(542, 271);
            this.btn_MySponsor.Name = "btn_MySponsor";
            this.btn_MySponsor.Size = new System.Drawing.Size(313, 49);
            this.btn_MySponsor.TabIndex = 9;
            this.btn_MySponsor.Text = "Мой спонсор";
            this.btn_MySponsor.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(416, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Меню Бегуна";
            // 
            // FormMenuRunner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 509);
            this.Controls.Add(this.btn_MySponsor);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMyResult);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnRegitrationRunner);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormMenuRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuRunner";
            this.Load += new System.EventHandler(this.FormMenuRunner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRegitrationRunner;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnMyResult;
        private System.Windows.Forms.Button btn_MySponsor;
        private System.Windows.Forms.Label label2;
    }
}