using CasaNacionalJudo.Core;

namespace CasaNacionalJudo.App.Forms.MembersForm
{
    public partial class EditMemberForm : Form
    {
        private readonly Member _member;

        public EditMemberForm(Member member)
        {
            _member = member;
            InitializeComponent();
            LoadMemberData();
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {

        }

        #region Utilities
        private void LoadMemberData()
        {
            tbFirstName.Text = _member.FirstName;
            tbLastName.Text = _member.LastName;
            dtpBirthDate.Value = DateTime.Parse(_member.BirthDate);
            tbBloodType.Text = _member.BloodType;
            tbIdentification.Text = _member.Identification;
            tbAddress.Text = _member.Address;
            tbPhone1.Text = _member.Phone1;
            tbPhone2.Text = _member.Phone2;
            tbEmail.Text = _member.Email;
            tbBelt.Text = _member.Belt;
            tbSignUpDate.Text = _member.SignUpDate;
            tbMonthlyFee.Value = _member.MonthlyFee;
            tbAnualFee.Value = _member.AnualFee;
            tbTotalAmountDue.Value = _member.TotalAmountDue;
        }
        #endregion
    }
}
