namespace Cafe_AfekWinForms.Формы
{
    partial class Client
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
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbMiddlename = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(800, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Location = new System.Drawing.Point(0, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(800, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox1.Location = new System.Drawing.Point(0, 364);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(800, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Отфильтровать";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbDiscount.Location = new System.Drawing.Point(0, 344);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(800, 20);
            this.tbDiscount.TabIndex = 6;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(800, 20);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tbLastname
            // 
            this.tbLastname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLastname.Location = new System.Drawing.Point(0, 324);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(800, 20);
            this.tbLastname.TabIndex = 8;
            // 
            // tbMiddlename
            // 
            this.tbMiddlename.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMiddlename.Location = new System.Drawing.Point(0, 304);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.Size = new System.Drawing.Size(800, 20);
            this.tbMiddlename.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbName.Location = new System.Drawing.Point(0, 284);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(800, 20);
            this.tbName.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMiddlename);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Client";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbMiddlename;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button button4;
    }
    #endregion
}
