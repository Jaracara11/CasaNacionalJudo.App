using CasaNacionalJudo.Core;
using CasaNacionalJudo.Repository;

namespace CasaNacionalJudo.App
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            panelTutor.Visible = false;
        }

        private void cbTutor_Click(object sender, EventArgs e)
        {
            switch (cbTutor.CheckState)
            {
                case CheckState.Checked:
                    panelTutor.Visible = true;
                    break;
                case CheckState.Unchecked:
                    panelTutor.Visible = false;
                    break;
            }
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            MemberRepository memberRepo = new();

            Member member = new()
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                BirthDate = dtpBirthDate.Text,
                BloodType = tbBloodType.Text,
                Identification = tbIdentification.Text,
                Address = tbAddress.Text,
                Phone = tbPhone.Text,
                Email = tbEmail.Text,
                Belt = tbBelt.Text,
                SignUpDate = DateTime.Now.ToString("dd-MM-yyyy"),
                MonthlyFee = tbMonthlyFee.Value,
                AnualFee = tbAnualFee.Value
            };

            memberRepo.AddMember(member);

            ClearFields();
        }

        #region Utilities
        private void ClearFields()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbBloodType.Text = "";
            tbIdentification.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbBelt.Text = "";
            tbMonthlyFee.Value = 0;
            tbAnualFee.Value = 0;
        }
        #endregion
    }
}