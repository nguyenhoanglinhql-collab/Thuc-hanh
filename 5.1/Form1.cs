namespace _5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            epCheck.Clear();
            var isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Vui lòng nhập tên đăng nhập.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Vui lòng nhập mật khẩu.");
                isValid = false;
            }

            if (!string.Equals(txtPassword.Text, txtConfirmPassword.Text, StringComparison.Ordinal))
            {
                epCheck.SetError(txtConfirmPassword, "Mật khẩu xác nhận không khớp.");
                isValid = false;
            }

            if (dtpDateOfBirth.Value.Date.AddYears(18) > DateTime.Today)
            {
                epCheck.SetError(dtpDateOfBirth, "Bạn phải đủ 18 tuổi để đăng ký.");
                isValid = false;
            }

            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms, "Vui lòng đồng ý với điều khoản dịch vụ.");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpDateOfBirth.Value = DateTime.Today;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkTerms.Checked = false;
            epCheck.Clear();
            txtUsername.Focus();
        }
    }
}
