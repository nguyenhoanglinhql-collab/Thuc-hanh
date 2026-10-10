using System.Drawing.Drawing2D;

namespace b5._4
{
    public partial class Form1 : Form
    {
        private sealed record Employee(string Id, string Name, string Position, DateTime StartDate);

        public Form1()
        {
            InitializeComponent();
            lsvEmployees.Columns.Clear();
            lsvEmployees.Columns.Add("Mã NV", 100);
            lsvEmployees.Columns.Add("Họ Tên", 230);
            lsvEmployees.Columns.Add("Chức vụ", 190);
            lsvEmployees.Columns.Add("Ngày vào làm", 150);
            cmbView.SelectedIndexChanged += (_, _) => ChangeListViewMode();
            tvDepartments.AfterSelect += (_, e) => LoadEmployees(e.Node);
            BuildDepartmentTree();
        }

        private void BuildDepartmentTree()
        {
            tvDepartments.Nodes.Clear();
            lsvEmployees.Items.Clear();

            treeImages.ImageSize = new Size(20, 20);
            treeImages.ColorDepth = ColorDepth.Depth32Bit;
            treeImages.Images.Add("company", CreateIcon(Color.FromArgb(54, 120, 190), "C", 20));
            treeImages.Images.Add("department", CreateIcon(Color.FromArgb(232, 153, 54), "D", 20));
            treeImages.Images.Add("team", CreateIcon(Color.FromArgb(74, 160, 112), "G", 20));
            tvDepartments.ImageList = treeImages;

            employeeSmallImages.ImageSize = new Size(24, 24);
            employeeSmallImages.ColorDepth = ColorDepth.Depth32Bit;
            employeeSmallImages.Images.Add("employee", CreateIcon(Color.FromArgb(65, 130, 185), "NV", 24));
            employeeLargeImages.ImageSize = new Size(48, 48);
            employeeLargeImages.ColorDepth = ColorDepth.Depth32Bit;
            employeeLargeImages.Images.Add("employee", CreateIcon(Color.FromArgb(65, 130, 185), "NV", 48));
            lsvEmployees.SmallImageList = employeeSmallImages;
            lsvEmployees.LargeImageList = employeeLargeImages;

            var employeesByTeam = new Dictionary<string, List<Employee>>
            {
                ["Phát triển phần mềm"] =
                [
                    new("NV001", "Nguyễn Minh Anh", "Trưởng nhóm", new DateTime(2019, 3, 12)),
                    new("NV002", "Trần Quốc Bảo", "Lập trình viên", new DateTime(2021, 7, 5)),
                    new("NV003", "Lê Thu Hà", "Kiểm thử phần mềm", new DateTime(2022, 2, 14))
                ],
                ["Hạ tầng hệ thống"] =
                [
                    new("NV004", "Phạm Đức Long", "Quản trị hệ thống", new DateTime(2020, 9, 21)),
                    new("NV005", "Võ Thanh Tùng", "Kỹ sư mạng", new DateTime(2023, 1, 9))
                ],
                ["Kinh doanh"] =
                [
                    new("NV006", "Đỗ Ngọc Mai", "Trưởng nhóm kinh doanh", new DateTime(2018, 6, 18)),
                    new("NV007", "Bùi Hoàng Nam", "Chuyên viên kinh doanh", new DateTime(2021, 11, 1))
                ],
                ["Chăm sóc khách hàng"] =
                [
                    new("NV008", "Hoàng Thị Lan", "Trưởng nhóm dịch vụ", new DateTime(2019, 8, 26)),
                    new("NV009", "Nguyễn Hải Yến", "Chuyên viên hỗ trợ", new DateTime(2022, 4, 11))
                ],
                ["Tuyển dụng"] =
                [
                    new("NV010", "Trương Quốc Huy", "Chuyên viên tuyển dụng", new DateTime(2020, 5, 4))
                ]
            };

            var company = new TreeNode("Công ty ABC") { ImageKey = "company", SelectedImageKey = "company" };
            var technology = AddDepartment(company, "Phòng Công nghệ thông tin");
            AddTeam(technology, "Phát triển phần mềm", employeesByTeam);
            AddTeam(technology, "Hạ tầng hệ thống", employeesByTeam);

            var business = AddDepartment(company, "Phòng Kinh doanh");
            AddTeam(business, "Kinh doanh", employeesByTeam);
            AddTeam(business, "Chăm sóc khách hàng", employeesByTeam);

            var humanResources = AddDepartment(company, "Phòng Nhân sự");
            AddTeam(humanResources, "Tuyển dụng", employeesByTeam);

            tvDepartments.Nodes.Add(company);
            company.Expand();
            tvDepartments.SelectedNode = company;
        }

        private static TreeNode AddDepartment(TreeNode parent, string name)
        {
            var node = new TreeNode(name) { ImageKey = "department", SelectedImageKey = "department" };
            parent.Nodes.Add(node);
            return node;
        }

        private static void AddTeam(TreeNode parent, string name, IReadOnlyDictionary<string, List<Employee>> employeesByTeam)
        {
            var node = new TreeNode(name)
            {
                ImageKey = "team",
                SelectedImageKey = "team",
                Tag = employeesByTeam[name]
            };
            parent.Nodes.Add(node);
        }

        private void LoadEmployees(TreeNode selectedNode)
        {
            var employees = new List<Employee>();
            CollectEmployees(selectedNode, employees);
            lsvEmployees.BeginUpdate();
            lsvEmployees.Items.Clear();
            foreach (var employee in employees.OrderBy(employee => employee.Id))
            {
                var item = new ListViewItem(employee.Id, "employee") { Tag = employee };
                item.SubItems.Add(employee.Name);
                item.SubItems.Add(employee.Position);
                item.SubItems.Add(employee.StartDate.ToString("dd/MM/yyyy"));
                lsvEmployees.Items.Add(item);
            }
            lsvEmployees.EndUpdate();
            lblStatus.Text = $"{selectedNode.FullPath}    •    {employees.Count} nhân viên";
        }

        private static void CollectEmployees(TreeNode node, ICollection<Employee> employees)
        {
            if (node.Tag is List<Employee> teamEmployees)
            {
                foreach (var employee in teamEmployees)
                {
                    employees.Add(employee);
                }
            }

            foreach (TreeNode child in node.Nodes)
            {
                CollectEmployees(child, employees);
            }
        }

        private void ChangeListViewMode()
        {
            lsvEmployees.View = cmbView.SelectedItem?.ToString() switch
            {
                "SmallIcon" => View.SmallIcon,
                "LargeIcon" => View.LargeIcon,
                "Tile" => View.Tile,
                _ => View.Details
            };
        }

        private static Bitmap CreateIcon(Color color, string text, int size)
        {
            var bitmap = new Bitmap(size, size);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            using var brush = new SolidBrush(color);
            graphics.FillEllipse(brush, 1, 1, size - 2, size - 2);
            using var font = new Font("Segoe UI", size <= 24 ? 7 : 12, FontStyle.Bold, GraphicsUnit.Point);
            using var textBrush = new SolidBrush(Color.White);
            var textSize = graphics.MeasureString(text, font);
            graphics.DrawString(text, font, textBrush, (size - textSize.Width) / 2, (size - textSize.Height) / 2);
            return bitmap;
        }
    }
}
