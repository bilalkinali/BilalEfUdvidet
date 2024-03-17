namespace UI
{
    partial class CreateVare
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
            btnCreate = new Button();
            lblName = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            tboxName = new TextBox();
            tboxDescription = new TextBox();
            tboxPrice = new TextBox();
            cBox = new ComboBox();
            lblVaregruppe = new Label();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(115, 239);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(42, 81);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(76, 155);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // tboxName
            // 
            tboxName.Location = new Point(115, 33);
            tboxName.Name = "tboxName";
            tboxName.Size = new Size(100, 23);
            tboxName.TabIndex = 4;
            // 
            // tboxDescription
            // 
            tboxDescription.Location = new Point(115, 78);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(100, 47);
            tboxDescription.TabIndex = 5;
            // 
            // tboxPrice
            // 
            tboxPrice.Location = new Point(115, 152);
            tboxPrice.Name = "tboxPrice";
            tboxPrice.Size = new Size(100, 23);
            tboxPrice.TabIndex = 6;
            // 
            // cBox
            // 
            cBox.FormattingEnabled = true;
            cBox.Location = new Point(115, 194);
            cBox.Name = "cBox";
            cBox.Size = new Size(100, 23);
            cBox.TabIndex = 7;
            // 
            // lblVaregruppe
            // 
            lblVaregruppe.AutoSize = true;
            lblVaregruppe.Location = new Point(42, 197);
            lblVaregruppe.Name = "lblVaregruppe";
            lblVaregruppe.Size = new Size(67, 15);
            lblVaregruppe.TabIndex = 8;
            lblVaregruppe.Text = "Varegruppe";
            // 
            // CreateVare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 297);
            Controls.Add(lblVaregruppe);
            Controls.Add(cBox);
            Controls.Add(tboxPrice);
            Controls.Add(tboxDescription);
            Controls.Add(tboxName);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(btnCreate);
            Name = "CreateVare";
            Text = "CreateVare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private TextBox tboxName;
        private TextBox tboxDescription;
        private TextBox tboxPrice;
        private ComboBox cBox;
        private Label lblVaregruppe;
    }
}