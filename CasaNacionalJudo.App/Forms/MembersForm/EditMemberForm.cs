using CasaNacionalJudo.Core;
using CasaNacionalJudo.Repository;
using CasaNacionalJudo.Service;

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

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            var alertTitle = "Edit Member";
            var memberName = $"{_member.FirstName} {_member.LastName}";
            TextBox[] mandatoryTboxes = { tbFirstName, tbLastName, tbAddress, tbPhone1 };

            try
            {
                if (FormHelper.ValidateTextboxes(mandatoryTboxes, " Field cannot be empty!", alertTitle) == true)
                {
                    Member member = new()
                    {
                        MemberId = _member.MemberId,
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
                        MonthlyFee = tbMonthlyFee.Value,
                        AnualFee = tbAnualFee.Value
                    };

                    if (FormHelper.ConfirmDialog($"Are you sure you want to update " +
                        $"{memberName}'s information?", alertTitle) == true)
                    {
                        MemberRepository.UpdateMember(member);

                        FormHelper.InfoDialog($"{memberName}'s information has been updated!", alertTitle);

                        Close();
                        BrowseMemberForm browseMemberFrm = new();
                        browseMemberFrm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var alertTitle = "DELETE Member";
            var memberName = $"{_member.FirstName} {_member.LastName}";


            if (FormHelper.ConfirmDialog($"Are you sure you want to delete the member " +
                        $"{memberName}'?", alertTitle) == true)
            {
                if (FormHelper.ConfirmDialog($"Please confirm the delete action.", alertTitle) == true)
                {
                    MemberRepository.DeleteMember(_member.MemberId);

                    FormHelper.InfoDialog($"{memberName} has been deleted!", alertTitle);

                    Close();
                    BrowseMemberForm browseMemberFrm = new();
                    browseMemberFrm.Show();
                }
            }
        }

        #region Utilities
        private void LoadMemberData()
        {
            tbFirstName.Text = _member.FirstName;
            tbLastName.Text = _member.LastName;
            dtpBirthDate.Value = StringService.ConvertToDateTime(_member.BirthDate);
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
