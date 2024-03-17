namespace UI
{
    partial class VareDetails
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
            lblName = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            tboxName = new TextBox();
            tboxDescription = new TextBox();
            tboxPrice = new TextBox();
            btnEdit = new Button();
            btnSave = new Button();
            tboxVaregruppe = new TextBox();
            lblVaregruppe = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(68, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(40, 71);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(74, 130);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // tboxName
            // 
            tboxName.Location = new Point(124, 29);
            tboxName.Name = "tboxName";
            tboxName.Size = new Size(100, 23);
            tboxName.TabIndex = 3;
            // 
            // tboxDescription
            // 
            tboxDescription.Location = new Point(124, 68);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(100, 44);
            tboxDescription.TabIndex = 4;
            // 
            // tboxPrice
            // 
            tboxPrice.Location = new Point(124, 127);
            tboxPrice.Name = "tboxPrice";
            tboxPrice.Size = new Size(100, 23);
            tboxPrice.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(45, 208);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(149, 208);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // tboxVaregruppe
            // 
            tboxVaregruppe.Location = new Point(124, 164);
            tboxVaregruppe.Name = "tboxVaregruppe";
            tboxVaregruppe.Size = new Size(100, 23);
            tboxVaregruppe.TabIndex = 9;
            // 
            // lblVaregruppe
            // 
            lblVaregruppe.AutoSize = true;
            lblVaregruppe.Location = new Point(40, 167);
            lblVaregruppe.Name = "lblVaregruppe";
            lblVaregruppe.Size = new Size(67, 15);
            lblVaregruppe.TabIndex = 8;
            lblVaregruppe.Text = "Varegruppe";
            // 
            // VareDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 255);
            Controls.Add(tboxVaregruppe);
            Controls.Add(lblVaregruppe);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(tboxPrice);
            Controls.Add(tboxDescription);
            Controls.Add(tboxName);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Name = "VareDetails";
            Text = "VareDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private TextBox tboxName;
        private TextBox tboxDescription;
        private TextBox tboxPrice;
        private Button btnEdit;
        private Button btnSave;
        private TextBox tboxVaregruppe;
        private Label lblVaregruppe;
    }
}