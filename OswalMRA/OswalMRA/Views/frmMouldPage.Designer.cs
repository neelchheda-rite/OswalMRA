﻿namespace OswalMRA
{
    partial class frmMouldPage
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dvgMouldManagement = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            addMouldBtn = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMouldManagement).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1920, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 45);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dvgMouldManagement, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 85);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1370, 664);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // dvgMouldManagement
            // 
            dvgMouldManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgMouldManagement.BackgroundColor = Color.White;
            dvgMouldManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMouldManagement.Location = new Point(3, 3);
            dvgMouldManagement.Name = "dvgMouldManagement";
            dvgMouldManagement.RowTemplate.Height = 25;
            dvgMouldManagement.Size = new Size(1364, 658);
            dvgMouldManagement.TabIndex = 0;
            dvgMouldManagement.CellContentClick += dvgMouldManagement_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.5F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 693);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1370, 56);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Controls.Add(button2, 1, 0);
            tableLayoutPanel4.Location = new Point(962, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(329, 50);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 128, 185);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.MaximumSize = new Size(89, 30);
            button1.MinimumSize = new Size(89, 30);
            button1.Name = "button1";
            button1.Size = new Size(89, 30);
            button1.TabIndex = 0;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 128, 185);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(167, 3);
            button2.MaximumSize = new Size(89, 30);
            button2.MinimumSize = new Size(89, 30);
            button2.Name = "button2";
            button2.Size = new Size(89, 30);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1370, 40);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(1167, 3);
            button3.Name = "button3";
            button3.Size = new Size(200, 34);
            button3.TabIndex = 0;
            button3.Text = "Add Mould";
            button3.UseVisualStyleBackColor = false;
            button3.Click += addMouldBtn_Click_1;
            // 
            // addMouldBtn
            // 
            addMouldBtn.BackColor = Color.FromArgb(41, 128, 185);
            addMouldBtn.FlatStyle = FlatStyle.Flat;
            addMouldBtn.ForeColor = Color.White;
            addMouldBtn.Location = new Point(3, 3);
            addMouldBtn.MaximumSize = new Size(89, 30);
            addMouldBtn.MinimumSize = new Size(89, 30);
            addMouldBtn.Name = "addMouldBtn";
            addMouldBtn.Size = new Size(89, 30);
            addMouldBtn.TabIndex = 1;
            addMouldBtn.Text = "Add +";
            addMouldBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // frmMouldPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1364, 726);
            Name = "frmMouldPage";
            ShowIcon = false;
            Text = "Mould Management";
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgMouldManagement).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dvgMouldManagement;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addMouldBtn;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button3;
    }
}