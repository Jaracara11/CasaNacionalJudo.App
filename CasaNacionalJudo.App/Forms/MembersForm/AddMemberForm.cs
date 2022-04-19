using CasaNacionalJudo.Core;
using CasaNacionalJudo.Repository;
using CasaNacionalJudo.Service;

namespace CasaNacionalJudo.App
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            var alertTitle = "Add Member";
            var newMemberName = $"{tbFirstName.Text} {tbLastName.Text}";
            TextBox[] mandatoryTboxes = { tbFirstName, tbLastName, tbAddress, tbPhone1 };

            try
            {
                if (FormHelper.ValidateTextboxes(mandatoryTboxes, " Field cannot be empty!", alertTitle) == true)
                {
                    Member member = new()
                    {
                        FirstName = StringService.FirstCharToUpper(tbFirstName.Text),
                        LastName = StringService.FirstCharToUpper(tbLastName.Text),
                        BirthDate = dtpBirthDate.Text,
                        BloodType = tbBloodType.Text,
                        Identification = tbIdentification.Text,
                        Address = tbAddress.Text,
                        Phone1 = tbPhone1.Text,
                        Phone2 = tbPhone2.Text,
                        Email = tbEmail.Text,
                        Belt = StringService.FirstCharToUpper(tbBelt.Text),
                        SignUpDate = DateTime.Now.ToString("dd-MM-yyyy"),
                        MonthlyFee = tbMonthlyFee.Value,
                        AnualFee = tbAnualFee.Value
                    };

                    if (FormHelper.ConfirmDialog($"Are you sure you want to add " +
                        $"{newMemberName} as a new member?", alertTitle) == true)
                    {
                        MemberRepository.AddMember(member);

                        FormHelper.InfoDialog($"{newMemberName} has been added!", alertTitle);

                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            tbPhone1.Text = "";
            tbPhone2.Text = "";
            tbEmail.Text = "";
            tbBelt.Text = "";
            tbMonthlyFee.Value = 0;
            tbAnualFee.Value = 0;
        }
        #endregion
    }
}