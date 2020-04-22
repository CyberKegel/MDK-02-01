namespace Cafe_AfekWinForms.Формы
{
    partial class Employee_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lblKlient_Surname = new System.Windows.Forms.Label();
            this.lblKlient_Create = new System.Windows.Forms.Label();
            this.lblKlient_Middlename = new System.Windows.Forms.Label();
            this.lblKlient_Name = new System.Windows.Forms.Label();
            this.bpgKlientProfile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPosition = new System.Windows.Forms.ListBox();
            this.tbConfernPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMiddle_Name = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFirst_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpgKlientCheckHistory = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbctrKlient = new System.Windows.Forms.TabPage();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.chrExpensens = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpgKlientTopProduct = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.bpgKlientProfile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbctrKlient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrExpensens)).BeginInit();
            this.tbpgKlientTopProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbpgKlientTopProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 480);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lbPosition);
            this.groupBox1.Controls.Add(this.lblKlient_Surname);
            this.groupBox1.Controls.Add(this.lblKlient_Create);
            this.groupBox1.Controls.Add(this.lblKlient_Middlename);
            this.groupBox1.Controls.Add(this.lblKlient_Name);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Word документ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(6, 77);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(35, 13);
            this.lbPosition.TabIndex = 5;
            this.lbPosition.Text = "label7";
            // 
            // lblKlient_Surname
            // 
            this.lblKlient_Surname.AutoSize = true;
            this.lblKlient_Surname.Location = new System.Drawing.Point(6, 16);
            this.lblKlient_Surname.Name = "lblKlient_Surname";
            this.lblKlient_Surname.Size = new System.Drawing.Size(56, 13);
            this.lblKlient_Surname.TabIndex = 2;
            this.lblKlient_Surname.Text = "Фамилия";
            // 
            // lblKlient_Create
            // 
            this.lblKlient_Create.AutoSize = true;
            this.lblKlient_Create.Location = new System.Drawing.Point(6, 55);
            this.lblKlient_Create.Name = "lblKlient_Create";
            this.lblKlient_Create.Size = new System.Drawing.Size(142, 13);
            this.lblKlient_Create.TabIndex = 3;
            this.lblKlient_Create.Text = "Дата создания уч. записи:";
            // 
            // lblKlient_Middlename
            // 
            this.lblKlient_Middlename.AutoSize = true;
            this.lblKlient_Middlename.Location = new System.Drawing.Point(6, 42);
            this.lblKlient_Middlename.Name = "lblKlient_Middlename";
            this.lblKlient_Middlename.Size = new System.Drawing.Size(54, 13);
            this.lblKlient_Middlename.TabIndex = 2;
            this.lblKlient_Middlename.Text = "Отчество";
            // 
            // lblKlient_Name
            // 
            this.lblKlient_Name.AutoSize = true;
            this.lblKlient_Name.Location = new System.Drawing.Point(6, 29);
            this.lblKlient_Name.Name = "lblKlient_Name";
            this.lblKlient_Name.Size = new System.Drawing.Size(32, 13);
            this.lblKlient_Name.TabIndex = 1;
            this.lblKlient_Name.Text = "Имя:";
            // 
            // bpgKlientProfile
            // 
            this.bpgKlientProfile.Controls.Add(this.tableLayoutPanel1);
            this.bpgKlientProfile.Location = new System.Drawing.Point(4, 22);
            this.bpgKlientProfile.Name = "bpgKlientProfile";
            this.bpgKlientProfile.Padding = new System.Windows.Forms.Padding(3);
            this.bpgKlientProfile.Size = new System.Drawing.Size(544, 361);
            this.bpgKlientProfile.TabIndex = 3;
            this.bpgKlientProfile.Text = "Личный профиль";
            this.bpgKlientProfile.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.18216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.81784F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbFirst_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbMiddle_Name, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btSave, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbConfernPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbPosition, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.393939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.39394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPosition
            // 
            this.tbPosition.FormattingEnabled = true;
            this.tbPosition.Location = new System.Drawing.Point(160, 286);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(120, 30);
            this.tbPosition.TabIndex = 14;
            // 
            // tbConfernPassword
            // 
            this.tbConfernPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfernPassword.Location = new System.Drawing.Point(160, 222);
            this.tbConfernPassword.Name = "tbConfernPassword";
            this.tbConfernPassword.PasswordChar = '*';
            this.tbConfernPassword.Size = new System.Drawing.Size(375, 20);
            this.tbConfernPassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль";
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.Location = new System.Drawing.Point(3, 286);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(151, 41);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Сохранить данные";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(160, 191);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(375, 20);
            this.tbPassword.TabIndex = 10;
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(160, 144);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(375, 20);
            this.tbLogin.TabIndex = 9;
            // 
            // tbMiddle_Name
            // 
            this.tbMiddle_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMiddle_Name.Location = new System.Drawing.Point(160, 97);
            this.tbMiddle_Name.Name = "tbMiddle_Name";
            this.tbMiddle_Name.Size = new System.Drawing.Size(375, 20);
            this.tbMiddle_Name.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(160, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(375, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbFirst_Name
            // 
            this.tbFirst_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirst_Name.Location = new System.Drawing.Point(160, 3);
            this.tbFirst_Name.Name = "tbFirst_Name";
            this.tbFirst_Name.Size = new System.Drawing.Size(375, 20);
            this.tbFirst_Name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Подтерждение пароля:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // tbpgKlientCheckHistory
            // 
            this.tbpgKlientCheckHistory.Location = new System.Drawing.Point(4, 22);
            this.tbpgKlientCheckHistory.Name = "tbpgKlientCheckHistory";
            this.tbpgKlientCheckHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgKlientCheckHistory.Size = new System.Drawing.Size(544, 361);
            this.tbpgKlientCheckHistory.TabIndex = 2;
            this.tbpgKlientCheckHistory.Text = "История продаж";
            this.tbpgKlientCheckHistory.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рейтинг товаров";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbctrKlient
            // 
            this.tbctrKlient.Controls.Add(this.chrExpensens);
            this.tbctrKlient.Controls.Add(this.dtpEndDate);
            this.tbctrKlient.Controls.Add(this.lblEndDate);
            this.tbctrKlient.Controls.Add(this.dtpStartDate);
            this.tbctrKlient.Controls.Add(this.lblStartDate);
            this.tbctrKlient.Location = new System.Drawing.Point(4, 22);
            this.tbctrKlient.Name = "tbctrKlient";
            this.tbctrKlient.Padding = new System.Windows.Forms.Padding(3);
            this.tbctrKlient.Size = new System.Drawing.Size(544, 361);
            this.tbctrKlient.TabIndex = 0;
            this.tbctrKlient.Text = "Затраты";
            this.tbctrKlient.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStartDate.Location = new System.Drawing.Point(3, 3);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Начальная дата";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpStartDate.Location = new System.Drawing.Point(3, 16);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(538, 20);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.DtpStartDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEndDate.Location = new System.Drawing.Point(3, 36);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(81, 13);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Конечная дата";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpEndDate.Location = new System.Drawing.Point(3, 49);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(538, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // chrExpensens
            // 
            chartArea1.Name = "ChartArea1";
            this.chrExpensens.ChartAreas.Add(chartArea1);
            this.chrExpensens.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chrExpensens.Legends.Add(legend1);
            this.chrExpensens.Location = new System.Drawing.Point(3, 69);
            this.chrExpensens.Name = "chrExpensens";
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "srExpens";
            series1.YValuesPerPoint = 3;
            this.chrExpensens.Series.Add(series1);
            this.chrExpensens.Size = new System.Drawing.Size(538, 289);
            this.chrExpensens.TabIndex = 4;
            this.chrExpensens.Text = "chart1";
            // 
            // tbpgKlientTopProduct
            // 
            this.tbpgKlientTopProduct.Controls.Add(this.tbctrKlient);
            this.tbpgKlientTopProduct.Controls.Add(this.tabPage2);
            this.tbpgKlientTopProduct.Controls.Add(this.tbpgKlientCheckHistory);
            this.tbpgKlientTopProduct.Controls.Add(this.bpgKlientProfile);
            this.tbpgKlientTopProduct.Location = new System.Drawing.Point(3, 3);
            this.tbpgKlientTopProduct.Name = "tbpgKlientTopProduct";
            this.tbpgKlientTopProduct.SelectedIndex = 0;
            this.tbpgKlientTopProduct.Size = new System.Drawing.Size(552, 387);
            this.tbpgKlientTopProduct.TabIndex = 0;
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 699);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_Form";
            this.Text = "Профиль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personal_Profile_Klient_FormClosing);
            this.Load += new System.EventHandler(this.Personal_Profile_Klient_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bpgKlientProfile.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbctrKlient.ResumeLayout(false);
            this.tbctrKlient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrExpensens)).EndInit();
            this.tbpgKlientTopProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKlient_Create;
        private System.Windows.Forms.Label lblKlient_Middlename;
        private System.Windows.Forms.Label lblKlient_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKlient_Surname;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tbpgKlientTopProduct;
        private System.Windows.Forms.TabPage tbctrKlient;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrExpensens;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tbpgKlientCheckHistory;
        private System.Windows.Forms.TabPage bpgKlientProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFirst_Name;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMiddle_Name;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConfernPassword;
        private System.Windows.Forms.ListBox tbPosition;
    }
}