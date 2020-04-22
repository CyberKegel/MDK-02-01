namespace Cafe_AfekWinForms.Формы
{
    partial class Authorization_Form
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
            this.lblUser_Login = new System.Windows.Forms.Label();
            this.tbUser_Login = new System.Windows.Forms.TextBox();
            this.lblUser_Password = new System.Windows.Forms.Label();
            this.tbUser_Password = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.btLeave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser_Login
            // 
            this.lblUser_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser_Login.Location = new System.Drawing.Point(0, 0);
            this.lblUser_Login.Name = "lblUser_Login";
            this.lblUser_Login.Size = new System.Drawing.Size(402, 25);
            this.lblUser_Login.TabIndex = 0;
            this.lblUser_Login.Text = "Логин";
            this.lblUser_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbUser_Login
            // 
            this.tbUser_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUser_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser_Login.Location = new System.Drawing.Point(0, 25);
            this.tbUser_Login.Name = "tbUser_Login";
            this.tbUser_Login.PasswordChar = '*';
            this.tbUser_Login.Size = new System.Drawing.Size(402, 32);
            this.tbUser_Login.TabIndex = 1;
            this.tbUser_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUser_Login.Enter += new System.EventHandler(this.back_Color);
            // 
            // lblUser_Password
            // 
            this.lblUser_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser_Password.Location = new System.Drawing.Point(0, 57);
            this.lblUser_Password.Name = "lblUser_Password";
            this.lblUser_Password.Size = new System.Drawing.Size(402, 25);
            this.lblUser_Password.TabIndex = 2;
            this.lblUser_Password.Text = "Пароль";
            this.lblUser_Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbUser_Password
            // 
            this.tbUser_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUser_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser_Password.Location = new System.Drawing.Point(0, 82);
            this.tbUser_Password.Name = "tbUser_Password";
            this.tbUser_Password.Size = new System.Drawing.Size(402, 32);
            this.tbUser_Password.TabIndex = 3;
            this.tbUser_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbUser_Password.Enter += new System.EventHandler(this.back_Color);
            // 
            // btEnter
            // 
            this.btEnter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEnter.Location = new System.Drawing.Point(0, 114);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(189, 47);
            this.btEnter.TabIndex = 4;
            this.btEnter.Text = "Вход";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.BtEnter_Click);
            // 
            // btLeave
            // 
            this.btLeave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLeave.Location = new System.Drawing.Point(215, 114);
            this.btLeave.Name = "btLeave";
            this.btLeave.Size = new System.Drawing.Size(187, 47);
            this.btLeave.TabIndex = 5;
            this.btLeave.Text = "Выход";
            this.btLeave.UseVisualStyleBackColor = true;
            this.btLeave.Click += new System.EventHandler(this.BtLeave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Authorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btLeave);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbUser_Password);
            this.Controls.Add(this.lblUser_Password);
            this.Controls.Add(this.tbUser_Login);
            this.Controls.Add(this.lblUser_Login);
            this.Name = "Authorization_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser_Login;
        private System.Windows.Forms.TextBox tbUser_Login;
        private System.Windows.Forms.Label lblUser_Password;
        private System.Windows.Forms.TextBox tbUser_Password;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btLeave;
        private System.Windows.Forms.Button button1;
    }
}