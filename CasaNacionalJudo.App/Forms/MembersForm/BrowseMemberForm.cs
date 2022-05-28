using CasaNacionalJudo.App.Forms.MembersForm;
using CasaNacionalJudo.Core;
using CasaNacionalJudo.Repository;
using CasaNacionalJudo.Service;

namespace CasaNacionalJudo.App
{
    public partial class BrowseMemberForm : Form
    {
        private List<Member> _memberList = new();

        public BrowseMemberForm()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var rowIndex = e.RowIndex;

            if (FormHelper.ConfirmDialog("Want to display this user's information?", "More info on user") == true)
            {
                Member member = new()
                {
                    MemberId = Convert.ToInt32(dgvMembers.Rows[rowIndex].Cells["MemberId"].Value),
                    FirstName = dgvMembers.Rows[rowIndex].Cells["FirstName"].Value.ToString()!,
                    LastName = dgvMembers.Rows[rowIndex].Cells["LastName"].Value.ToString()!,
                    BirthDate = dgvMembers.Rows[rowIndex].Cells["BirthDate"].Value.ToString()!,
                    BloodType = dgvMembers.Rows[rowIndex].Cells["BloodType"].Value.ToString()!,
                    Identification = dgvMembers.Rows[rowIndex].Cells["Identification"].Value.ToString()!,
                    Address = dgvMembers.Rows[rowIndex].Cells["Address"].Value.ToString()!,
                    Phone1 = dgvMembers.Rows[rowIndex].Cells["Phone1"].Value.ToString()!,
                    Phone2 = dgvMembers.Rows[rowIndex].Cells["Phone2"].Value.ToString()!,
                    Email = dgvMembers.Rows[rowIndex].Cells["Email"].Value.ToString()!,
                    Belt = dgvMembers.Rows[rowIndex].Cells["Belt"].Value.ToString()!,
                    SignUpDate = dgvMembers.Rows[rowIndex].Cells["SignUpDate"].Value.ToString()!,
                    MonthlyFee = Convert.ToDecimal(dgvMembers.Rows[rowIndex].Cells["MonthlyFee"].Value),
                    AnualFee = Convert.ToDecimal(dgvMembers.Rows[rowIndex].Cells["AnualFee"].Value),
                    TotalAmountDue = Convert.ToDecimal(dgvMembers.Rows[rowIndex].Cells["TotalAmountDue"].Value)
                };

                EditMemberForm editMemberFrm = new(member);
                editMemberFrm.Show();
                Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMembers.DataSource = MemberRepository.GetMemberByName(tbSearchByName.Text);

            if (dgvMembers.RowCount == 0)
            {
                FormHelper.InfoDialog($"Member {tbSearchByName.Text} Not Found!", "Search Member");
                LoadMembers();
            }

            tbSearchByName.Text = "";
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (FormHelper.ConfirmDialog("Want to export all members to a .CSV file?", "Export CSV") == true)
            {
                CsvService.MembersToCsv(_memberList);
                FormHelper.InfoDialog($"File successfully created in path: {FilePathService.CsvPath}", "Export CSV");
            }
        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            LoadMembers();
            tbSearchByName.Text = "";
        }

        #region Utilities
        private void LoadMembers()
        {
            dgvMembers.DataSource = MemberRepository.GetAllMembers();
            _memberList = (List<Member>)dgvMembers.DataSource;
            dgvMembers.Columns["MemberId"].Visible = false;
        }
        #endregion
    }
}
