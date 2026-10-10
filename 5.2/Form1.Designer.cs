namespace _5._2
{
    partial class Form1
    {
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAvailableServices;
        private ListBox lstAvailableServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Label lblSelectedServices;
        private ListBox lstSelectedServices;
        private Label lblSubtotal;
        private Label lblSubtotalValue;
        private Label lblDiscount;
        private NumericUpDown nudDiscount;
        private Label lblTotal;
        private Label lblTotalValue;

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
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAvailableServices = new Label();
            lstAvailableServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            lblSelectedServices = new Label();
            lstSelectedServices = new ListBox();
            lblSubtotal = new Label();
            lblSubtotalValue = new Label();
            lblDiscount = new Label();
            nudDiscount = new NumericUpDown();
            lblTotal = new Label();
            lblTotalValue = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 22);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 20);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Loại dịch vụ:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(125, 18);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(250, 28);
            cboCategory.TabIndex = 13;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lblAvailableServices
            // 
            lblAvailableServices.AutoSize = true;
            lblAvailableServices.Location = new Point(20, 65);
            lblAvailableServices.Name = "lblAvailableServices";
            lblAvailableServices.Size = new Size(110, 20);
            lblAvailableServices.TabIndex = 12;
            lblAvailableServices.Text = "Dịch vụ hiện có";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.Location = new Point(20, 90);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.SelectionMode = SelectionMode.MultiExtended;
            lstAvailableServices.Size = new Size(300, 244);
            lstAvailableServices.TabIndex = 11;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(350, 140);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(70, 35);
            btnSelect.TabIndex = 10;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(350, 190);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(70, 35);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(350, 240);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(70, 35);
            btnClearAll.TabIndex = 8;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // lblSelectedServices
            // 
            lblSelectedServices.AutoSize = true;
            lblSelectedServices.Location = new Point(450, 65);
            lblSelectedServices.Name = "lblSelectedServices";
            lblSelectedServices.Size = new Size(115, 20);
            lblSelectedServices.TabIndex = 7;
            lblSelectedServices.Text = "Dịch vụ đã chọn";
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.Location = new Point(450, 90);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.SelectionMode = SelectionMode.MultiExtended;
            lstSelectedServices.Size = new Size(340, 244);
            lstSelectedServices.TabIndex = 6;
            lstSelectedServices.SelectedIndexChanged += lstSelectedServices_SelectedIndexChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(20, 375);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(149, 20);
            lblSubtotal.TabIndex = 5;
            lblSubtotal.Text = "Tổng tiền chưa giảm:";
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Location = new Point(190, 375);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(0, 20);
            lblSubtotalValue.TabIndex = 4;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(20, 415);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(140, 20);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "Tỷ lệ chiết khấu (%):";
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(190, 411);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(100, 27);
            nudDiscount.TabIndex = 2;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(380, 415);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(169, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Thành tiền thanh toán:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalValue.Location = new Point(555, 415);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(0, 20);
            lblTotalValue.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 510);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotal);
            Controls.Add(nudDiscount);
            Controls.Add(lblDiscount);
            Controls.Add(lblSubtotalValue);
            Controls.Add(lblSubtotal);
            Controls.Add(lstSelectedServices);
            Controls.Add(lblSelectedServices);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstAvailableServices);
            Controls.Add(lblAvailableServices);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng tính tiền dịch vụ và chiết khấu đơn hàng";
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
