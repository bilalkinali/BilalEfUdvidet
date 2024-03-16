using UiModels;
using BusinessLogic;

namespace UI
{
    public partial class Form1 : Form
    {
        VaregruppeBL vgBL;
        VareBL vBL;
        public Form1()
        {
            vgBL = new();
            vBL = new();
            InitializeComponent();
            dgv.VisibleChanged += Dgv_VisibleChanged;
            btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateVaregruppe createVaregruppe = new CreateVaregruppe(vgBL);
            createVaregruppe.ShowDialog();
        }

        private async void Dgv_VisibleChanged(object? sender, EventArgs e)
        {
            dgv.DataSource = await vgBL.GetAsync();
        }
    }
}
