﻿namespace WSR_0
{
    partial class FormAdmin
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
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_volunteers = new System.Windows.Forms.Button();
            this.btn_charitable = new System.Windows.Forms.Button();
            this.btn_interior = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btn_logOut);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 87);
            this.panel1.TabIndex = 6;
            // 
            // btn_logOut
            // 
            this.btn_logOut.ForeColor = System.Drawing.Color.Black;
            this.btn_logOut.Location = new System.Drawing.Point(993, 27);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(96, 33);
            this.btn_logOut.TabIndex = 2;
            this.btn_logOut.Text = "Выйти";
            this.btn_logOut.UseVisualStyleBackColor = true;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 27);
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
            this.panel2.Location = new System.Drawing.Point(0, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 36);
            this.panel2.TabIndex = 10;
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(0, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(1092, 36);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(376, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Меню Администратора";
            // 
            // btn_Users
            // 
            this.btn_Users.BackColor = System.Drawing.Color.White;
            this.btn_Users.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Users.Location = new System.Drawing.Point(269, 199);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Size = new System.Drawing.Size(249, 77);
            this.btn_Users.TabIndex = 11;
            this.btn_Users.Text = "Пользователи";
            this.btn_Users.UseVisualStyleBackColor = false;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_volunteers
            // 
            this.btn_volunteers.BackColor = System.Drawing.Color.White;
            this.btn_volunteers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_volunteers.Location = new System.Drawing.Point(574, 199);
            this.btn_volunteers.Name = "btn_volunteers";
            this.btn_volunteers.Size = new System.Drawing.Size(249, 77);
            this.btn_volunteers.TabIndex = 11;
            this.btn_volunteers.Text = "Волонтёры";
            this.btn_volunteers.UseVisualStyleBackColor = false;
            // 
            // btn_charitable
            // 
            this.btn_charitable.BackColor = System.Drawing.Color.White;
            this.btn_charitable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_charitable.Location = new System.Drawing.Point(269, 306);
            this.btn_charitable.Name = "btn_charitable";
            this.btn_charitable.Size = new System.Drawing.Size(249, 77);
            this.btn_charitable.TabIndex = 11;
            this.btn_charitable.Text = "Благотворительные\r\nорганизации";
            this.btn_charitable.UseVisualStyleBackColor = false;
            // 
            // btn_interior
            // 
            this.btn_interior.BackColor = System.Drawing.Color.White;
            this.btn_interior.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_interior.Location = new System.Drawing.Point(574, 306);
            this.btn_interior.Name = "btn_interior";
            this.btn_interior.Size = new System.Drawing.Size(249, 77);
            this.btn_interior.TabIndex = 11;
            this.btn_interior.Text = "Инвентарь";
            this.btn_interior.UseVisualStyleBackColor = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 583);
            this.Controls.Add(this.btn_interior);
            this.Controls.Add(this.btn_charitable);
            this.Controls.Add(this.btn_volunteers);
            this.Controls.Add(this.btn_Users);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_volunteers;
        private System.Windows.Forms.Button btn_charitable;
        private System.Windows.Forms.Button btn_interior;
    }
}