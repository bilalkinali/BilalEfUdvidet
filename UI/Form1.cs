using UiModels;
using BusinessLogic;
using System.Data.Common;

namespace UI
{
    public partial class Form1 : Form
    {
        StoreBL storeBL;

        VaregruppeUI selectedVg;
        VareUI selectedV;
        int selectedVid, selectedVgid;

        public Form1()
        {
            storeBL = new();
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            // VaregruppeUI :
            // DataGridView
            dgvVaregruppe.SelectionChanged += DgvVaregruppe_SelectionChanged;
            dgvVaregruppe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Buttons
            btnCreateVg.Click += BtnCreateVg_Click;
            btnDeleteVg.Click += BtnDeleteVg_Click;
            btnDeleteVg.ForeColor = Color.OrangeRed;

            // Vare :
            // DataGridView
            dgvVare.SelectionChanged += DgvVare_SelectionChanged;
            dgvVare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Buttons
            btnCreateV.Click += BtnCreateV_Click;
            btnDeleteV.Click += BtnDeleteV_Click;
            btnDetails.Click += BtnEdit_Click;
            btnDeleteV.ForeColor = Color.OrangeRed;
            btnShowAll.Click += BtnShowAll_Click;

            Load += Form1_Load;

        }
        private async void BtnShowAll_Click(object? sender, EventArgs e)
        {
            dgvVare.DataSource = null;
            dgvVare.DataSource = await storeBL.GetVarerAsync();
            dgvVare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVare.Columns[0].Visible = false;
            dgvVare.Columns[^2].Visible = false;
            dgvVare.Columns[^1].Visible = false;
            dgvVare.Columns["Description"].FillWeight = 150;
        }

        private async void BtnDeleteVg_Click(object? sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                $"Are you sure you want to delete this item?\n\n" +
                $"Name: {selectedVg.Name}\n" +
                $"List count: {selectedVg.VareListe.Count}\n\n" +
                "*This action is irreversible and all related data will be permanently erased.",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                bool result = await storeBL.DeleteVaregruppeAsync(selectedVgid);

                if (result)
                {
                    RefreshDgvAsync();   // Update the dgv if success

                    MessageBox.Show(
                        "The item has been successfully removed.",
                        "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "The item could not be removed due to an unexpected error.\n\n" +
                        "Item doesn't exits.",
                        "Removal Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            //dgvVaregruppe.DataSource = await storeBL.GetVaregrupperAsync();
            //dgvVare.DataSource = await storeBL.GetVarerAsync();
            RefreshDgvAsync();

        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            VareDetails vareDetails = new VareDetails(storeBL, selectedVid);
            vareDetails.ShowDialog();
        }

        private async void BtnDeleteV_Click(object? sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                $"Are you sure you want to delete this item?\n\n" +
                $"Name: {selectedV.Name}\n" +
                $"Description: {selectedV.Description}\n" +
                $"Price: {selectedV.Price}\n" +
                $"Varegruppe: {selectedV.Varegruppe.Name}\n\n" +
                "*This action is irreversible and all related data will be permanently erased.",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                bool result = await storeBL.DeleteVareAsync(selectedVid);

                if (result)
                {
                    RefreshDgvAsync();   // Update the dgv if success

                    MessageBox.Show(
                        "The item has been successfully removed.",
                        "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "The item could not be removed due to an unexpected error.\n\n" +
                        "Item doesn't exits.",
                        "Removal Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvVare_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVare.SelectedRows.Count == 1)
            {
                selectedVid = (int)dgvVare.SelectedRows[0].Cells[0].Value;
                btnDeleteV.Enabled = true;
                btnDetails.Enabled = true;

                selectedV = (VareUI)dgvVare.SelectedRows[0].DataBoundItem;
            }
            else
            {
                selectedVid = 0;
                btnDetails.Enabled = false;
                btnDeleteV.Enabled = false;
            }
        }

        private void DgvVaregruppe_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVaregruppe.SelectedRows.Count == 1)
            {
                selectedVgid = (int)dgvVaregruppe.SelectedRows[0].Cells[0].Value;
                btnDeleteVg.Enabled = true;

                selectedVg = (VaregruppeUI)dgvVaregruppe.SelectedRows[0].DataBoundItem;
                dgvVare.DataSource = selectedVg?.VareListe;
            }
            else
            {
                selectedVgid = 0;
                btnDeleteVg.Enabled = false;
            }
        }

        private void BtnCreateV_Click(object? sender, EventArgs e)
        {
            CreateVare createVare = new CreateVare(storeBL, (List<VaregruppeUI>)dgvVaregruppe.DataSource);
            createVare.OnCreateVareOpen += RefreshDgvAsync;
            createVare.ShowDialog();
        }

        private void BtnCreateVg_Click(object? sender, EventArgs e)
        {
            CreateVaregruppe createVaregruppe = new CreateVaregruppe(storeBL);
            createVaregruppe.OnCreateVaregruppeOpen += RefreshDgvAsync;
            createVaregruppe.ShowDialog();
        }

        private async void RefreshDgvAsync()
        {
            dgvVaregruppe.DataSource = null;
            dgvVaregruppe.DataSource = await storeBL.GetVaregrupperAsync();
            dgvVaregruppe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaregruppe.Columns[0].Visible = false;
            dgvVare.DataSource = null;
            dgvVare.DataSource = await storeBL.GetVarerAsync();
            dgvVare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVare.Columns[0].Visible = false;
            dgvVare.Columns[^2].Visible = false;
            dgvVare.Columns[^1].Visible = false;
            dgvVare.Columns["Description"].FillWeight = 150;
        }
    }
}
