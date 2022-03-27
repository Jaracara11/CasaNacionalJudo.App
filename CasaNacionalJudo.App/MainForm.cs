namespace CasaNacionalJudo.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            MemberForm memberFrm = new();
            memberFrm.Show();
        }
    }
}