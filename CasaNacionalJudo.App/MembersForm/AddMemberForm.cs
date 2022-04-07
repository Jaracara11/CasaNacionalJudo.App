using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
