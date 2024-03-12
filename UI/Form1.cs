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
        }

        private async void Dgv_VisibleChanged(object? sender, EventArgs e)
        {
            dgv.DataSource = await vgBL.GetAsync();
        }
    }
}
