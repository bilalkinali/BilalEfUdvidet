namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVaregruppe = new DataGridView();
            btnCreate = new Button();
            dgvVare = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVaregruppe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVare).BeginInit();
            SuspendLayout();
            // 
            // dgvVaregruppe
            // 
            dgvVaregruppe.AllowUserToAddRows = false;
            dgvVaregruppe.AllowUserToDeleteRows = false;
            dgvVaregruppe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaregruppe.Location = new Point(12, 12);
            dgvVaregruppe.Name = "dgvVaregruppe";
            dgvVaregruppe.ReadOnly = true;
            dgvVaregruppe.Size = new Size(244, 339);
            dgvVaregruppe.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 357);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // dgvVare
            // 
            dgvVare.AllowUserToAddRows = false;
            dgvVare.AllowUserToDeleteRows = false;
            dgvVare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVare.Location = new Point(262, 12);
            dgvVare.Name = "dgvVare";
            dgvVare.ReadOnly = true;
            dgvVare.Size = new Size(526, 339);
            dgvVare.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVare);
            Controls.Add(btnCreate);
            Controls.Add(dgvVaregruppe);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvVaregruppe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVare).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVaregruppe;
        private Button btnCreate;
        private DataGridView dgvVare;
    }
}
