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
            btnCreateVg = new Button();
            dgvVare = new DataGridView();
            btnCreateV = new Button();
            btnDeleteV = new Button();
            btnDetails = new Button();
            btnDeleteVg = new Button();
            btnShowAll = new Button();
            lblCategories = new Label();
            lblProducts = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVaregruppe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVare).BeginInit();
            SuspendLayout();
            // 
            // dgvVaregruppe
            // 
            dgvVaregruppe.AllowUserToAddRows = false;
            dgvVaregruppe.AllowUserToDeleteRows = false;
            dgvVaregruppe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaregruppe.Location = new Point(12, 30);
            dgvVaregruppe.Name = "dgvVaregruppe";
            dgvVaregruppe.ReadOnly = true;
            dgvVaregruppe.Size = new Size(244, 292);
            dgvVaregruppe.TabIndex = 0;
            // 
            // btnCreateVg
            // 
            btnCreateVg.Location = new Point(181, 328);
            btnCreateVg.Name = "btnCreateVg";
            btnCreateVg.Size = new Size(75, 23);
            btnCreateVg.TabIndex = 1;
            btnCreateVg.Text = "Create";
            btnCreateVg.UseVisualStyleBackColor = true;
            // 
            // dgvVare
            // 
            dgvVare.AllowUserToAddRows = false;
            dgvVare.AllowUserToDeleteRows = false;
            dgvVare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVare.Location = new Point(262, 30);
            dgvVare.Name = "dgvVare";
            dgvVare.ReadOnly = true;
            dgvVare.Size = new Size(526, 321);
            dgvVare.TabIndex = 2;
            // 
            // btnCreateV
            // 
            btnCreateV.Location = new Point(713, 357);
            btnCreateV.Name = "btnCreateV";
            btnCreateV.Size = new Size(75, 23);
            btnCreateV.TabIndex = 3;
            btnCreateV.Text = "Create";
            btnCreateV.UseVisualStyleBackColor = true;
            // 
            // btnDeleteV
            // 
            btnDeleteV.Location = new Point(262, 357);
            btnDeleteV.Name = "btnDeleteV";
            btnDeleteV.Size = new Size(75, 23);
            btnDeleteV.TabIndex = 4;
            btnDeleteV.Text = "Delete";
            btnDeleteV.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(356, 357);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(75, 23);
            btnDetails.TabIndex = 6;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnDeleteVg
            // 
            btnDeleteVg.Location = new Point(12, 328);
            btnDeleteVg.Name = "btnDeleteVg";
            btnDeleteVg.Size = new Size(75, 23);
            btnDeleteVg.TabIndex = 7;
            btnDeleteVg.Text = "Delete";
            btnDeleteVg.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(454, 357);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(12, 12);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(63, 15);
            lblCategories.TabIndex = 9;
            lblCategories.Text = "Categories";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(262, 12);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(54, 15);
            lblProducts.TabIndex = 10;
            lblProducts.Text = "Products";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(lblProducts);
            Controls.Add(lblCategories);
            Controls.Add(btnShowAll);
            Controls.Add(btnDeleteVg);
            Controls.Add(btnDetails);
            Controls.Add(btnDeleteV);
            Controls.Add(btnCreateV);
            Controls.Add(dgvVare);
            Controls.Add(btnCreateVg);
            Controls.Add(dgvVaregruppe);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvVaregruppe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVare).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVaregruppe;
        private Button btnCreateVg;
        private DataGridView dgvVare;
        private Button btnCreateV;
        private Button btnDeleteV;
        private Button btnDetails;
        private Button btnDeleteVg;
        private Button btnShowAll;
        private Label lblCategories;
        private Label lblProducts;
    }
}
