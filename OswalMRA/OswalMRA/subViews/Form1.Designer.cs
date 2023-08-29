using PresentationControls;

namespace OswalMRA
{
    partial class Form1
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
            CheckBoxProperties checkBoxProperties1 = new CheckBoxProperties();
            checkBox1 = new CheckBox();
            cmbIListDataSource = new CheckBoxComboBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(362, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbIListDataSource
            // 
            checkBoxProperties1.ForeColor = SystemColors.ControlText;
            cmbIListDataSource.CheckBoxProperties = checkBoxProperties1;
            cmbIListDataSource.DisplayMemberSingleItem = "";
            cmbIListDataSource.FormattingEnabled = true;
            cmbIListDataSource.Location = new Point(248, 96);
            cmbIListDataSource.Name = "cmbIListDataSource";
            cmbIListDataSource.Size = new Size(152, 28);
            cmbIListDataSource.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(cmbIListDataSource);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBoxComboBox cmbIListDataSource;
    }
}