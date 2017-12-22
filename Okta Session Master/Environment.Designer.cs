namespace OktaSessionMaster.SL
{
    partial class Environment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Environment));
            this.image_OktaLogo = new System.Windows.Forms.PictureBox();
            this.label_TenantUrl = new System.Windows.Forms.Label();
            this.textBox_TenantUrl = new System.Windows.Forms.TextBox();
            this.label_TenantUrl_Example = new System.Windows.Forms.Label();
            this.label_ApiToken = new System.Windows.Forms.Label();
            this.textBox_ApiToken = new System.Windows.Forms.TextBox();
            this.label_ApiToken_Example = new System.Windows.Forms.Label();
            this.button_ValidateSettings = new System.Windows.Forms.Button();
            this.checkBox_RememberSettings = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_OktaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // image_OktaLogo
            // 
            this.image_OktaLogo.Image = ((System.Drawing.Image)(resources.GetObject("image_OktaLogo.Image")));
            this.image_OktaLogo.Location = new System.Drawing.Point(12, 12);
            this.image_OktaLogo.Name = "image_OktaLogo";
            this.image_OktaLogo.Size = new System.Drawing.Size(324, 72);
            this.image_OktaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_OktaLogo.TabIndex = 0;
            this.image_OktaLogo.TabStop = false;
            // 
            // label_TenantUrl
            // 
            this.label_TenantUrl.AutoSize = true;
            this.label_TenantUrl.Location = new System.Drawing.Point(12, 116);
            this.label_TenantUrl.Name = "label_TenantUrl";
            this.label_TenantUrl.Size = new System.Drawing.Size(95, 13);
            this.label_TenantUrl.TabIndex = 2;
            this.label_TenantUrl.Text = "Okta Tenant URL:";
            // 
            // textBox_TenantUrl
            // 
            this.textBox_TenantUrl.Location = new System.Drawing.Point(113, 113);
            this.textBox_TenantUrl.Name = "textBox_TenantUrl";
            this.textBox_TenantUrl.Size = new System.Drawing.Size(223, 20);
            this.textBox_TenantUrl.TabIndex = 3;
            this.textBox_TenantUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_TenantUrl_Example
            // 
            this.label_TenantUrl_Example.AutoSize = true;
            this.label_TenantUrl_Example.Location = new System.Drawing.Point(203, 136);
            this.label_TenantUrl_Example.Name = "label_TenantUrl_Example";
            this.label_TenantUrl_Example.Size = new System.Drawing.Size(133, 13);
            this.label_TenantUrl_Example.TabIndex = 4;
            this.label_TenantUrl_Example.Text = "Example: tentant.okta.com";
            this.label_TenantUrl_Example.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_ApiToken
            // 
            this.label_ApiToken.AutoSize = true;
            this.label_ApiToken.Location = new System.Drawing.Point(20, 166);
            this.label_ApiToken.Name = "label_ApiToken";
            this.label_ApiToken.Size = new System.Drawing.Size(87, 13);
            this.label_ApiToken.TabIndex = 5;
            this.label_ApiToken.Text = "Okta API Token:";
            // 
            // textBox_ApiToken
            // 
            this.textBox_ApiToken.Location = new System.Drawing.Point(113, 163);
            this.textBox_ApiToken.Name = "textBox_ApiToken";
            this.textBox_ApiToken.PasswordChar = '•';
            this.textBox_ApiToken.Size = new System.Drawing.Size(223, 20);
            this.textBox_ApiToken.TabIndex = 6;
            this.textBox_ApiToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_ApiToken_Example
            // 
            this.label_ApiToken_Example.AutoSize = true;
            this.label_ApiToken_Example.Location = new System.Drawing.Point(145, 186);
            this.label_ApiToken_Example.Name = "label_ApiToken_Example";
            this.label_ApiToken_Example.Size = new System.Drawing.Size(191, 13);
            this.label_ApiToken_Example.TabIndex = 7;
            this.label_ApiToken_Example.Text = "A token from Security -> API -> Tokens";
            this.label_ApiToken_Example.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_ValidateSettings
            // 
            this.button_ValidateSettings.Location = new System.Drawing.Point(12, 252);
            this.button_ValidateSettings.Name = "button_ValidateSettings";
            this.button_ValidateSettings.Size = new System.Drawing.Size(324, 37);
            this.button_ValidateSettings.TabIndex = 8;
            this.button_ValidateSettings.Text = "Validate";
            this.button_ValidateSettings.UseVisualStyleBackColor = true;
            this.button_ValidateSettings.Click += new System.EventHandler(this.button_ValidateSettings_Click);
            // 
            // checkBox_RememberSettings
            // 
            this.checkBox_RememberSettings.AutoSize = true;
            this.checkBox_RememberSettings.Enabled = false;
            this.checkBox_RememberSettings.Location = new System.Drawing.Point(220, 229);
            this.checkBox_RememberSettings.Name = "checkBox_RememberSettings";
            this.checkBox_RememberSettings.Size = new System.Drawing.Size(116, 17);
            this.checkBox_RememberSettings.TabIndex = 9;
            this.checkBox_RememberSettings.Text = "Remember settings";
            this.checkBox_RememberSettings.UseVisualStyleBackColor = true;
            // 
            // Environment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 303);
            this.Controls.Add(this.checkBox_RememberSettings);
            this.Controls.Add(this.button_ValidateSettings);
            this.Controls.Add(this.label_ApiToken_Example);
            this.Controls.Add(this.textBox_ApiToken);
            this.Controls.Add(this.label_ApiToken);
            this.Controls.Add(this.label_TenantUrl_Example);
            this.Controls.Add(this.textBox_TenantUrl);
            this.Controls.Add(this.label_TenantUrl);
            this.Controls.Add(this.image_OktaLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Environment";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Okta Session Master";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Environment_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.image_OktaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_OktaLogo;
        private System.Windows.Forms.Label label_TenantUrl;
        private System.Windows.Forms.TextBox textBox_TenantUrl;
        private System.Windows.Forms.Label label_TenantUrl_Example;
        private System.Windows.Forms.Label label_ApiToken;
        private System.Windows.Forms.TextBox textBox_ApiToken;
        private System.Windows.Forms.Label label_ApiToken_Example;
        private System.Windows.Forms.Button button_ValidateSettings;
        private System.Windows.Forms.CheckBox checkBox_RememberSettings;
    }
}

