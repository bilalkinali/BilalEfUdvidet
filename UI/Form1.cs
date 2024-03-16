using UiModels;
using BusinessLogic;

namespace UI
{
    public partial class Form1 : Form
    {
        VaregruppeBL varegruppeBL;
        VareBL vareBL;

        public Form1()
        {
            varegruppeBL = new();
            vareBL = new();
            InitializeComponent();

            dgvVaregruppe.VisibleChanged += Dgv_VisibleChanged;
            dgvVare.VisibleChanged += DgvVare_VisibleChanged;
            btnCreate.Click += BtnCreate_Click;
        }        

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateVaregruppe createVaregruppe = new CreateVaregruppe(varegruppeBL);
            createVaregruppe.ShowDialog();
        }

        private async void Dgv_VisibleChanged(object? sender, EventArgs e)
        {
            dgvVaregruppe.DataSource = await varegruppeBL.GetAsync();
        }

        private async void DgvVare_VisibleChanged(object? sender, EventArgs e)
        {
            dgvVare.DataSource = await vareBL.GetAsync();
        }
    }
}
