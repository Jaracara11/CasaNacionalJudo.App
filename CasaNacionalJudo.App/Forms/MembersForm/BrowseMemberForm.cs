using CasaNacionalJudo.Repository;

namespace CasaNacionalJudo.App
{
    public partial class BrowseMemberForm : Form
    {
        public BrowseMemberForm()
        {
            InitializeComponent();      
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        #region Utilities
        private void LoadMembers()
        {
            MemberRepository memberRepo = new();
            dgvMembers.DataSource = memberRepo.GetAllMembers();
            dgvMembers.Columns["MemberId"].Visible = false;
        }
        #endregion
    }
}
