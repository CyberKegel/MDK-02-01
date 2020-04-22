namespace Cafe_AfekWinForms.Формы
{
    partial class Connection_Form
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
            this.lblServers = new System.Windows.Forms.Label();
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.btChecked = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConnecti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServers.Location = new System.Drawing.Point(0, 0);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(200, 26);
            this.lblServers.TabIndex = 1;
            this.lblServers.Text = "Название сервера";
            this.lblServers.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cbServers
            // 
            this.cbServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(0, 26);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(522, 33);
            this.cbServers.TabIndex = 2;
            this.cbServers.SelectedIndexChanged += new System.EventHandler(this.CbServers_SelectedIndexChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData.Location = new System.Drawing.Point(0, 59);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(251, 26);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Название базы данных";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblData.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cbDatabases
            // 
            this.cbDatabases.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(0, 85);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(522, 33);
            this.cbDatabases.TabIndex = 9;
            // 
            // btChecked
            // 
            this.btChecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btChecked.Enabled = false;
            this.btChecked.Location = new System.Drawing.Point(0, 118);
            this.btChecked.Name = "btChecked";
            this.btChecked.Size = new System.Drawing.Size(170, 91);
            this.btChecked.TabIndex = 10;
            this.btChecked.Text = "Проверка подключения";
            this.btChecked.UseVisualStyleBackColor = true;
            this.btChecked.Click += new System.EventHandler(this.BtChecked_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Location = new System.Drawing.Point(370, 118);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(152, 91);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btConnecti
            // 
            this.btConnecti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConnecti.Enabled = false;
            this.btConnecti.Location = new System.Drawing.Point(170, 118);
            this.btConnecti.Name = "btConnecti";
            this.btConnecti.Size = new System.Drawing.Size(200, 91);
            this.btConnecti.TabIndex = 13;
            this.btConnecti.Text = "Подключиться";
            this.btConnecti.UseVisualStyleBackColor = true;
            this.btConnecti.Click += new System.EventHandler(this.BtConnecti_Click);
            // 
            // Connection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 209);
            this.Controls.Add(this.btConnecti);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChecked);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbServers);
            this.Controls.Add(this.lblServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Connection_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка пдключения к источнику данных";
            this.Load += new System.EventHandler(this.Connection_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.ComboBox cbServers;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Button btChecked;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConnecti;
    }
}