using System;
using System.Text;
using System.Windows.Forms;
using OktaSessionMaster.Bridge;

namespace OktaSessionMaster.SL
{
    public partial class Environment : Form
    {
        public Environment()
        {
            InitializeComponent();
        }

        private async void button_ValidateSettings_Click(object sender, System.EventArgs e)
        {
            LockProgram(true);

            string validationText = ValidateInputs();
            if (!String.IsNullOrEmpty(validationText))
            {
                MessageBox.Show(validationText, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LockProgram(false);

                return;
            }

            string tenantUrl = textBox_TenantUrl.Text;
            string apiToken = textBox_ApiToken.Text;

            OktaInterface.Initialize(tenantUrl, apiToken);

            bool valid = await OktaInterface.Validate();

            if (!valid)
            {
                MessageBox.Show(@"The given data was invalid!", @"Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            LockProgram(false);
        }

        private string ValidateInputs()
        {
            StringBuilder sb = new StringBuilder();

            string tenantUrl = textBox_TenantUrl.Text;

            if (!tenantUrl.StartsWith("https://"))
            {
                if (!tenantUrl.StartsWith("http://"))
                {
                    tenantUrl = $@"https://{tenantUrl}";
                }
                else
                {
                    tenantUrl = tenantUrl.Remove(0, 7);
                    tenantUrl = $@"https://{tenantUrl}";
                }
            }

            if (!tenantUrl.EndsWith(".com"))
            {
                int firstDotIndex = tenantUrl.IndexOf(".", StringComparison.CurrentCulture);
                int lastDotIndex = tenantUrl.LastIndexOf(".", StringComparison.CurrentCulture);

                if (firstDotIndex == lastDotIndex)
                {
                    sb.AppendLine("The Okta tenant URL is invalid!");
                }
                else
                {
                    tenantUrl = tenantUrl.Remove(lastDotIndex, (tenantUrl.Length - lastDotIndex));
                    tenantUrl = $@"{tenantUrl}.com";
                }
            }

            if (!tenantUrl.Contains("okta"))
            {
                sb.AppendLine("The given URL is not an Okta tenant!");
            }

            textBox_TenantUrl.Text = tenantUrl;

            if (String.IsNullOrEmpty(textBox_ApiToken.Text))
            {
                sb.AppendLine("The API token field cannot be empty!");
            }

            return sb.ToString();
        }

        private void LockProgram(bool targetState)
        {
            if (targetState)
            {
                textBox_TenantUrl.Enabled = false;
                textBox_ApiToken.Enabled = false;
                //checkBox_RememberSettings.Enabled = false;
                button_ValidateSettings.Enabled = false;

                return;
            }
            textBox_TenantUrl.Enabled = true;
            textBox_ApiToken.Enabled = true;
            //checkBox_RememberSettings.Enabled = true;
            button_ValidateSettings.Enabled = true;
        }

        private void Environment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                e.Handled = true;

                button_ValidateSettings_Click(this, null);
            }
        }
    }
}
