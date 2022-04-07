namespace CasaNacionalJudo.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            BrowseMemberForm memberFrm = new();
            memberFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberFrm = new();
            addMemberFrm.Show();
        }
    }
}