﻿namespace Cafe_AfekWinForms.Формы
{
    partial class Purchase
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.tbCheck = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
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
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(800, 20);
            this.tbSearch.TabIndex = 7;
            // 
            // tbCash
            // 
            this.tbCash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCash.Location = new System.Drawing.Point(0, 344);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(800, 20);
            this.tbCash.TabIndex = 8;
            this.tbCash.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // tbCheck
            // 
            this.tbCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCheck.Location = new System.Drawing.Point(0, 324);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(800, 20);
            this.tbCheck.TabIndex = 9;
            // 
            // tbAmount
            // 
            this.tbAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbAmount.Location = new System.Drawing.Point(0, 304);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(800, 20);
            this.tbAmount.TabIndex = 10;
            this.tbAmount.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // cbClient
            // 
            this.cbClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(0, 283);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(800, 21);
            this.cbClient.TabIndex = 11;
            // 
            // cbProduct
            // 
            this.cbProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(0, 262);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(800, 21);
            this.cbProduct.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbCheck);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Purchase";
            this.Text = "Тип товара";
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
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.TextBox tbCheck;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Button button4;
    }
    #endregion
}
