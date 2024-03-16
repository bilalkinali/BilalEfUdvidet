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
    public partial class CreateVaregruppe : Form
    {
        VaregruppeBL vgBL;
        public CreateVaregruppe(VaregruppeBL bl)
        {
            vgBL = bl;
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;
            tboxName.PlaceholderText = "Monitors";

            btnCreate.Click += BtnCreate_Click;
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            VaregruppeUI vgUI = new VaregruppeUI { Name = tboxName.Text };

            bool result = await vgBL.CreateAsync(vgUI);

            if (result)
            {
                MessageBox.Show("SUCCESS!");
            }
            else
            {
                MessageBox.Show("FAILED!");
            }

        }
    }
}
