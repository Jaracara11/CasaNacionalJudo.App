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

        private readonly MemberRepository _memberRepo = new();
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
            var alertTitle = "Add Member";
            var newMemberName = $"{tbFirstName.Text} {tbLastName.Text}";

            TextBox[] tBoxes = { tbFirstName, tbLastName, tbAddress, tbPhone };

            if (FormHelper.ValidateTextboxes(tBoxes, " Field cannot be empty!", alertTitle) == true)
            {
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

                if (FormHelper.ConfirmDialog($"Are you sure you want to add " +
                    $"{newMemberName} as a new member?", alertTitle) == true)
                {
                    _memberRepo.AddMember(member);

                    FormHelper.SuccessDialog($"{newMemberName} has been added!", alertTitle);

                    ClearFields();
                }
            }
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