namespace _5._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpAccount = new GroupBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            grpAdditional = new GroupBox();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblGender = new Label();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            chkTerms = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            epCheck = new ErrorProvider(components);
            grpAccount.SuspendLayout();
            grpAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            //
            // grpAccount
            //
            grpAccount.Controls.Add(lblUsername);
            grpAccount.Controls.Add(txtUsername);
            grpAccount.Controls.Add(lblPassword);
            grpAccount.Controls.Add(txtPassword);
            grpAccount.Controls.Add(lblConfirmPassword);
            grpAccount.Controls.Add(txtConfirmPassword);
            grpAccount.Location = new Point(30, 25);
            grpAccount.Name = "grpAccount";
            grpAccount.Size = new Size(540, 205);
            grpAccount.TabIndex = 0;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin tài khoản";
            //
            // lblUsername
            //
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(24, 38);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập";
            //
            // txtUsername
            //
            txtUsername.Location = new Point(205, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(290, 27);
            txtUsername.TabIndex = 1;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 91);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu";
            //
            // txtPassword
            //
            txtPassword.Location = new Point(205, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(290, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            //
            // lblConfirmPassword
            //
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(24, 144);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(139, 20);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Xác nhận mật khẩu";
            //
            // txtConfirmPassword
            //
            txtConfirmPassword.Location = new Point(205, 141);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(290, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            //
            // grpAdditional
            //
            grpAdditional.Controls.Add(lblDateOfBirth);
            grpAdditional.Controls.Add(dtpDateOfBirth);
            grpAdditional.Controls.Add(lblGender);
            grpAdditional.Controls.Add(rdoMale);
            grpAdditional.Controls.Add(rdoFemale);
            grpAdditional.Controls.Add(chkTerms);
            grpAdditional.Location = new Point(30, 250);
            grpAdditional.Name = "grpAdditional";
            grpAdditional.Size = new Size(540, 160);
            grpAdditional.TabIndex = 1;
            grpAdditional.TabStop = false;
            grpAdditional.Text = "Thông tin bổ sung";
            //
            // lblDateOfBirth
            //
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(24, 38);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(73, 20);
            lblDateOfBirth.TabIndex = 0;
            lblDateOfBirth.Text = "Ngày sinh";
            //
            // dtpDateOfBirth
            //
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(205, 34);
            dtpDateOfBirth.MaxDate = DateTime.Today;
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(290, 27);
            dtpDateOfBirth.TabIndex = 1;
            dtpDateOfBirth.Value = DateTime.Today;
            //
            // lblGender
            //
            lblGender.AutoSize = true;
            lblGender.Location = new Point(24, 78);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(62, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính";
            //
            // rdoMale
            //
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(205, 76);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(57, 24);
            rdoMale.TabIndex = 2;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            //
            // rdoFemale
            //
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(290, 76);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(48, 24);
            rdoFemale.TabIndex = 3;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            //
            // chkTerms
            //
            chkTerms.AutoSize = true;
            chkTerms.Location = new Point(205, 112);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(243, 24);
            chkTerms.TabIndex = 4;
            chkTerms.Text = "Tôi đồng ý với điều khoản dịch vụ";
            chkTerms.UseVisualStyleBackColor = true;
            //
            // btnRegister
            //
            btnRegister.Location = new Point(320, 430);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 38);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            //
            // btnReset
            //
            btnReset.Location = new Point(450, 430);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 38);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            //
            // epCheck
            //
            epCheck.ContainerControl = this;
            //
            // Form1
            //
            AcceptButton = btnRegister;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 495);
            Controls.Add(btnReset);
            Controls.Add(btnRegister);
            Controls.Add(grpAdditional);
            Controls.Add(grpAccount);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            grpAccount.ResumeLayout(false);
            grpAccount.PerformLayout();
            grpAdditional.ResumeLayout(false);
            grpAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
        }

        private GroupBox grpAccount;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private GroupBox grpAdditional;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblGender;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private CheckBox chkTerms;
        private Button btnRegister;
        private Button btnReset;
        private ErrorProvider epCheck;

        #endregion
    }
}
