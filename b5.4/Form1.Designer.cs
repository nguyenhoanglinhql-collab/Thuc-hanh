namespace b5._4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layout;
        private Panel toolbar;
        private Label title;
        private Label viewLabel;
        private ComboBox cmbView;
        private SplitContainer split;
        private TreeView tvDepartments;
        private ListView lsvEmployees;
        private Label lblStatus;
        private ImageList treeImages;
        private ImageList employeeSmallImages;
        private ImageList employeeLargeImages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            layout = new TableLayoutPanel();
            toolbar = new Panel();
            cmbView = new ComboBox();
            viewLabel = new Label();
            title = new Label();
            split = new SplitContainer();
            tvDepartments = new TreeView();
            lsvEmployees = new ListView();
            lblStatus = new Label();
            treeImages = new ImageList(components);
            employeeSmallImages = new ImageList(components);
            employeeLargeImages = new ImageList(components);
            layout.SuspendLayout();
            toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)split).BeginInit();
            split.Panel1.SuspendLayout();
            split.Panel2.SuspendLayout();
            split.SuspendLayout();
            SuspendLayout();
            // 
            // layout
            // 
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.Controls.Add(toolbar, 0, 0);
            layout.Controls.Add(split, 0, 1);
            layout.Controls.Add(lblStatus, 0, 2);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(0, 0);
            layout.Name = "layout";
            layout.Padding = new Padding(16);
            layout.RowCount = 3;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            layout.Size = new Size(1100, 700);
            layout.TabIndex = 0;
            // 
            // toolbar
            // 
            toolbar.BackColor = Color.White;
            toolbar.Controls.Add(cmbView);
            toolbar.Controls.Add(viewLabel);
            toolbar.Controls.Add(title);
            toolbar.Dock = DockStyle.Fill;
            toolbar.Location = new Point(19, 19);
            toolbar.Name = "toolbar";
            toolbar.Padding = new Padding(16, 10, 16, 10);
            toolbar.Size = new Size(1062, 58);
            toolbar.TabIndex = 0;
            // 
            // cmbView
            // 
            cmbView.Dock = DockStyle.Right;
            cmbView.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbView.Items.AddRange(new object[] { "Details", "SmallIcon", "LargeIcon", "Tile" });
            cmbView.Location = new Point(806, 10);
            cmbView.Name = "cmbView";
            cmbView.Size = new Size(140, 28);
            cmbView.TabIndex = 0;
            // 
            // viewLabel
            // 
            viewLabel.Dock = DockStyle.Right;
            viewLabel.ForeColor = Color.FromArgb(70, 80, 95);
            viewLabel.Location = new Point(946, 10);
            viewLabel.Name = "viewLabel";
            viewLabel.Size = new Size(100, 38);
            viewLabel.TabIndex = 1;
            viewLabel.Text = "Chế độ xem:";
            viewLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // title
            // 
            title.Dock = DockStyle.Left;
            title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(35, 55, 80);
            title.Location = new Point(16, 10);
            title.Name = "title";
            title.Size = new Size(280, 38);
            title.TabIndex = 2;
            title.Text = "DANH SÁCH NHÂN SỰ";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // split
            // 
            split.BackColor = Color.FromArgb(220, 225, 232);
            split.Dock = DockStyle.Fill;
            split.FixedPanel = FixedPanel.Panel1;
            split.Location = new Point(19, 83);
            split.Name = "split";
            // 
            // split.Panel1
            // 
            split.Panel1.BackColor = Color.White;
            split.Panel1.Controls.Add(tvDepartments);
            split.Panel1.Padding = new Padding(8);
            split.Panel1MinSize = 200;
            // 
            // split.Panel2
            // 
            split.Panel2.BackColor = Color.White;
            split.Panel2.Controls.Add(lsvEmployees);
            split.Panel2.Padding = new Padding(8);
            split.Panel2MinSize = 400;
            split.Size = new Size(1062, 566);
            split.SplitterDistance = 270;
            split.TabIndex = 1;
            // 
            // tvDepartments
            // 
            tvDepartments.BackColor = Color.White;
            tvDepartments.BorderStyle = BorderStyle.None;
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.Font = new Font("Segoe UI", 10F);
            tvDepartments.ForeColor = Color.FromArgb(45, 55, 70);
            tvDepartments.FullRowSelect = true;
            tvDepartments.HideSelection = false;
            tvDepartments.Location = new Point(8, 8);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.Size = new Size(254, 550);
            tvDepartments.TabIndex = 0;
            // 
            // lsvEmployees
            // 
            lsvEmployees.BackColor = Color.White;
            lsvEmployees.BorderStyle = BorderStyle.None;
            lsvEmployees.Dock = DockStyle.Fill;
            lsvEmployees.Font = new Font("Segoe UI", 9.5F);
            lsvEmployees.ForeColor = Color.FromArgb(45, 55, 70);
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.Location = new Point(8, 8);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(772, 550);
            lsvEmployees.TabIndex = 0;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(90, 100, 115);
            lblStatus.Location = new Point(19, 652);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1062, 32);
            lblStatus.TabIndex = 2;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // treeImages
            // 
            treeImages.ColorDepth = ColorDepth.Depth32Bit;
            treeImages.ImageSize = new Size(16, 16);
            treeImages.TransparentColor = Color.Transparent;
            // 
            // employeeSmallImages
            // 
            employeeSmallImages.ColorDepth = ColorDepth.Depth32Bit;
            employeeSmallImages.ImageSize = new Size(16, 16);
            employeeSmallImages.TransparentColor = Color.Transparent;
            // 
            // employeeLargeImages
            // 
            employeeLargeImages.ColorDepth = ColorDepth.Depth32Bit;
            employeeLargeImages.ImageSize = new Size(16, 16);
            employeeLargeImages.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 700);
            Controls.Add(layout);
            MinimumSize = new Size(850, 550);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trình quản lý nhân sự";
            layout.ResumeLayout(false);
            toolbar.ResumeLayout(false);
            split.Panel1.ResumeLayout(false);
            split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split).EndInit();
            split.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
