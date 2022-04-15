namespace CasaNacionalJudo.App
{
    public static class FormHelper
    {
        public static bool ValidateTextboxes(TextBox[] tBoxes, string errorMsg, string alertTitle)
        {
            bool result = true;

            foreach (var tb in tBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    MessageBox.Show(tb.Name + errorMsg, alertTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    result = false;
                    break;
                }
            }

            return result;
        }

        public static bool ConfirmDialog(string dialogText, string alertTitle)
        {
            bool result = true;

            if (MessageBox.Show(dialogText, alertTitle,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                result = false;
            }

            return result;
        }

        public static void SuccessDialog(string dialogText, string alertTitle)
        {
            MessageBox.Show(dialogText, alertTitle,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
