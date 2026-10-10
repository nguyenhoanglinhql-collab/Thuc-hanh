namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly List<Product> products = new();
        private readonly BindingSource productBindingSource = new();

        private Product? selectedProduct;

        public Form1()
        {
            InitializeComponent();
            dgvProducts.DataSource = productBindingSource;
            RefreshProducts();
        }

        private void RefreshProducts(string? searchText = null)
        {
            var displayedProducts = string.IsNullOrWhiteSpace(searchText)
                ? products
                : products.Where(product => product.ProductName.Contains(searchText, StringComparison.CurrentCultureIgnoreCase)).ToList();
            productBindingSource.DataSource = displayedProducts.ToList();
            productBindingSource.ResetBindings(false);
        }

        private void AddProduct(object? sender, EventArgs e)
        {
            if (!TryReadProduct(out var product))
            {
                return;
            }

            products.Add(product);
            RefreshProducts();
            ClearInputs();
        }

        private void EditProduct(object? sender, EventArgs e)
        {
            if (selectedProduct is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryReadProduct(out var updatedProduct))
            {
                return;
            }

            selectedProduct.ProductId = updatedProduct.ProductId;
            selectedProduct.ProductName = updatedProduct.ProductName;
            selectedProduct.UnitPrice = updatedProduct.UnitPrice;
            selectedProduct.Quantity = updatedProduct.Quantity;
            selectedProduct.Category = updatedProduct.Category;
            RefreshProducts();
            ClearInputs();
        }

        private void DeleteProduct(object? sender, EventArgs e)
        {
            if (selectedProduct is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var answer = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm '{selectedProduct.ProductName}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            products.Remove(selectedProduct);
            selectedProduct = null;
            RefreshProducts();
            ClearInputs();
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            RefreshProducts(txtSearch.Text.Trim());
        }

        private bool TryReadProduct(out Product product)
        {
            product = new Product();
            var productId = txtProductId.Text.Trim();
            var productName = txtProductName.Text.Trim();
            var category = txtCategory.Text.Trim();

            if (productId.Length == 0 || productName.Length == 0 || category.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm, tên sản phẩm và danh mục.", "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out var unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm.", "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out var quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm.", "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            product = new Product
            {
                ProductId = productId,
                ProductName = productName,
                UnitPrice = unitPrice,
                Quantity = quantity,
                Category = category
            };
            return true;
        }

        private void DgvProducts_SelectionChanged(object? sender, EventArgs e)
        {
            selectedProduct = dgvProducts.CurrentRow?.DataBoundItem as Product;
            if (selectedProduct is null)
            {
                return;
            }

            txtProductId.Text = selectedProduct.ProductId;
            txtProductName.Text = selectedProduct.ProductName;
            txtUnitPrice.Text = selectedProduct.UnitPrice.ToString();
            txtQuantity.Text = selectedProduct.Quantity.ToString();
            txtCategory.Text = selectedProduct.Category;
        }

        private void ClearInputs()
        {
            selectedProduct = null;
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtCategory.Clear();
            dgvProducts.ClearSelection();
            txtProductId.Focus();
        }
    }
}
