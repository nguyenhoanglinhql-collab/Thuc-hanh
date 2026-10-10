namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpProductInfo;
        private GroupBox grpFunctions;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvProducts;

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
            grpProductInfo = new GroupBox();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            grpFunctions = new GroupBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            grpProductInfo.SuspendLayout();
            grpFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // grpProductInfo
            // 
            grpProductInfo.Controls.Add(lblProductId);
            grpProductInfo.Controls.Add(txtProductId);
            grpProductInfo.Controls.Add(lblProductName);
            grpProductInfo.Controls.Add(txtProductName);
            grpProductInfo.Controls.Add(lblUnitPrice);
            grpProductInfo.Controls.Add(txtUnitPrice);
            grpProductInfo.Controls.Add(lblQuantity);
            grpProductInfo.Controls.Add(txtQuantity);
            grpProductInfo.Controls.Add(lblCategory);
            grpProductInfo.Controls.Add(txtCategory);
            grpProductInfo.Location = new Point(12, 12);
            grpProductInfo.Name = "grpProductInfo";
            grpProductInfo.Size = new Size(635, 205);
            grpProductInfo.TabIndex = 0;
            grpProductInfo.TabStop = false;
            grpProductInfo.Text = "Thông tin sản phẩm";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(20, 38);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(50, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(105, 35);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(190, 27);
            txtProductId.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(320, 38);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(52, 20);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(405, 35);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(205, 27);
            txtProductName.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(20, 83);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(62, 20);
            lblUnitPrice.TabIndex = 4;
            lblUnitPrice.Text = "Đơn giá";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(105, 80);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(190, 27);
            txtUnitPrice.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(320, 83);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(69, 20);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(405, 80);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(205, 27);
            txtQuantity.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 128);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 20);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Danh mục";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(105, 125);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(505, 27);
            txtCategory.TabIndex = 9;
            // 
            // grpFunctions
            // 
            grpFunctions.Controls.Add(btnAdd);
            grpFunctions.Controls.Add(btnEdit);
            grpFunctions.Controls.Add(btnDelete);
            grpFunctions.Controls.Add(txtSearch);
            grpFunctions.Controls.Add(btnSearch);
            grpFunctions.Location = new Point(663, 12);
            grpFunctions.Name = "grpFunctions";
            grpFunctions.Size = new Size(325, 205);
            grpFunctions.TabIndex = 1;
            grpFunctions.TabStop = false;
            grpFunctions.Text = "Chức năng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += AddProduct;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(118, 35);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += EditProduct;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(218, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += DeleteProduct;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tên sản phẩm cần tìm";
            txtSearch.Size = new Size(185, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(18, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += SearchProducts;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 223);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(936, 405);
            dgvProducts.TabIndex = 2;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(dgvProducts);
            Controls.Add(grpFunctions);
            Controls.Add(grpProductInfo);
            MinimumSize = new Size(850, 560);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh sách sản phẩm";
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            grpFunctions.ResumeLayout(false);
            grpFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
