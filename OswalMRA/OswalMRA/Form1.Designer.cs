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
            cmbIListDataSource = new CheckBoxComboBox();
            SuspendLayout();
            // 
            // cmbIListDataSource
            // 
            checkBoxProperties1.ForeColor = SystemColors.ControlText;
            cmbIListDataSource.CheckBoxProperties = checkBoxProperties1;
            cmbIListDataSource.DisplayMemberSingleItem = "";
            cmbIListDataSource.FormattingEnabled = true;
            cmbIListDataSource.Location = new Point(217, 72);
            cmbIListDataSource.Margin = new Padding(3, 2, 3, 2);
            cmbIListDataSource.Name = "cmbIListDataSource";
            cmbIListDataSource.Size = new Size(134, 23);
            cmbIListDataSource.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(cmbIListDataSource);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private CheckBoxComboBox cmbIListDataSource;
    }
}