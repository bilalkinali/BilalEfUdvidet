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
    public partial class CreateVare : Form
    {
        StoreBL storeBL;
        List<VaregruppeUI> listVgUi;
        public event Action OnCreateVareOpen;

        public CreateVare(StoreBL bl, List<VaregruppeUI> list)
        {
            storeBL = bl;
            listVgUi = list;
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            btnCreate.Click += BtnCreate_Click;
            cBox.DisplayMember = "Name";
            cBox.DataSource = listVgUi;
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            VaregruppeUI vgUI = (VaregruppeUI)cBox.SelectedItem;

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to create this item?\n\n" +
                $"Name: {tboxName.Text}\n" +
                $"Description: {tboxDescription.Text}\n" +
                $"Price: {tboxPrice.Text}\n" +
                $"Varegruppe: {vgUI.Name}",
                "Confirm Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                VareUI createVare = new VareUI
                {
                    Name = tboxName.Text,
                    Description = tboxDescription.Text,
                    Price = double.Parse(tboxPrice.Text),
                    VaregruppeId = vgUI.Id,
                    Varegruppe = vgUI
                };
                bool result = await storeBL.CreateVareAsync(createVare);

                if (result)
                {
                    OnCreateVareOpen.Invoke();

                    MessageBox.Show(
                            "The item has been successfully created.",
                            "Item Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                            "The item could not be created due to an unexpected error.\n",
                            "Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
    }
}
