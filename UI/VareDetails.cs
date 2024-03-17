using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UiModels;

namespace UI
{
    public partial class VareDetails : Form
    {
        StoreBL storeBL;
        VareUI vareUI;

        int id;
        public VareDetails(StoreBL bl, int id)
        {
            this.id = id;
            storeBL = bl;
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            Load += VareDetails_Load;
            btnEdit.Click += BtnEdit_Click;
            btnSave.Click += BtnSave_Click;
        }

        private async void BtnSave_Click(object? sender, EventArgs e)
        {
            DisableEdit();
            // Promp user for update confirmation
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to update this item?\n\n" +
                $"Name: {tboxName.Text}\n" +
                $"Description: {tboxDescription.Text}\n" +
                $"Price: {tboxPrice.Text}\n",
                "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                vareUI.Id = id;
                vareUI.Name = tboxName.Text;
                vareUI.Description = tboxDescription.Text;
                vareUI.Price = int.Parse(tboxPrice.Text);

                bool result = await storeBL.UpdateVareAsync(vareUI);

                if (result)
                {
                    MessageBox.Show(
                            "The item has been successfully updated.",
                            "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                            "The item could not be updated due to an unexpected error.\n\n" +
                            "Item doesn't exist.",
                            "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            EnableEdit();
        }

        private async void VareDetails_Load(object? sender, EventArgs e)
        {
            vareUI = new VareUI();
            vareUI = await storeBL.GetVareAsync(id);
            if (vareUI.Id > 0)
            {
                tboxName.Text = vareUI.Name;
                tboxDescription.Text = vareUI.Description;
                tboxPrice.Text = vareUI.Price.ToString();
                tboxVaregruppe.Text = vareUI.Varegruppe.Name;
            }
            DisableEdit();
        }


        private void DisableEdit()
        {
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            tboxName.ReadOnly = tboxDescription.ReadOnly = tboxPrice.ReadOnly = tboxVaregruppe.ReadOnly = true;
            tboxName.BorderStyle = tboxDescription.BorderStyle = tboxPrice.BorderStyle = tboxVaregruppe.BorderStyle = BorderStyle.None;
        }

        private void EnableEdit()
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            tboxName.ReadOnly = tboxDescription.ReadOnly = tboxPrice.ReadOnly = tboxVaregruppe.ReadOnly = false;
            tboxName.BorderStyle = tboxDescription.BorderStyle = tboxPrice.BorderStyle = tboxVaregruppe.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
