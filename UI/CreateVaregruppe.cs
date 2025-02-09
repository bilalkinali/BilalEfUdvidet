﻿using BusinessLogic;
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
        StoreBL storeBL;
        public event Action OnCreateVaregruppeOpen;
        public CreateVaregruppe(StoreBL bl)
        {
            storeBL = bl;
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;
            tboxName.PlaceholderText = "Monitors";

            btnCreate.Click += BtnCreate_Click;
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to create this item?\n\n" +
                $"Name: {tboxName.Text}\n",
                "Confirm Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                VaregruppeUI vgUI = new VaregruppeUI { Name = tboxName.Text };
                bool result = await storeBL.CreateVaregruppeAsync(vgUI);

                if (result)
                {
                    OnCreateVaregruppeOpen.Invoke();

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
