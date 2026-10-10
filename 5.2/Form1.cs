namespace _5._2
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, List<ServiceItem>> _servicesByCategory = new()
        {
            ["Khám bệnh"] = new()
            {
                new("Khám tổng quát", 300_000),
                new("Khám chuyên khoa", 250_000),
                new("Tái khám", 150_000)
            },
            ["Xét nghiệm"] = new()
            {
                new("Xét nghiệm máu", 200_000),
                new("Xét nghiệm nước tiểu", 120_000),
                new("Xét nghiệm đường huyết", 100_000)
            },
            ["Chụp X-Quang"] = new()
            {
                new("Chụp X-Quang ngực", 250_000),
                new("Chụp X-Quang xương", 300_000)
            },
            ["Vắc-xin"] = new()
            {
                new("Vắc-xin cúm", 350_000),
                new("Vắc-xin viêm gan B", 400_000),
                new("Vắc-xin uốn ván", 280_000)
            }
        };

        public Form1()
        {
            InitializeComponent();
            cboCategory.Items.AddRange(_servicesByCategory.Keys.Cast<object>().ToArray());
            cboCategory.SelectedIndex = 0;
            UpdateTotals();
        }

        private void cboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadAvailableServices();
        }

        private void lstAvailableServices_DoubleClick(object? sender, EventArgs e)
        {
            SelectServices();
        }

        private void btnSelect_Click(object? sender, EventArgs e)
        {
            SelectServices();
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            RemoveServices();
        }

        private void btnClearAll_Click(object? sender, EventArgs e)
        {
            ClearSelectedServices();
        }

        private void nudDiscount_ValueChanged(object? sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void LoadAvailableServices()
        {
            if (cboCategory.SelectedItem is not string category)
            {
                return;
            }

            var selectedServices = lstSelectedServices.Items.Cast<ServiceItem>().ToHashSet();
            lstAvailableServices.Items.Clear();
            foreach (var service in _servicesByCategory[category])
            {
                if (!selectedServices.Contains(service))
                {
                    lstAvailableServices.Items.Add(service);
                }
            }
        }

        private void SelectServices()
        {
            var services = lstAvailableServices.SelectedItems.Cast<ServiceItem>().ToList();
            foreach (var service in services)
            {
                lstSelectedServices.Items.Add(service);
                lstAvailableServices.Items.Remove(service);
            }

            UpdateTotals();
        }

        private void RemoveServices()
        {
            var services = lstSelectedServices.SelectedItems.Cast<ServiceItem>().ToList();
            foreach (var service in services)
            {
                lstSelectedServices.Items.Remove(service);
            }

            LoadAvailableServices();
            UpdateTotals();
        }

        private void ClearSelectedServices()
        {
            lstSelectedServices.Items.Clear();
            LoadAvailableServices();
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            var subtotal = lstSelectedServices.Items.Cast<ServiceItem>().Sum(service => service.Price);
            var total = subtotal * (100 - nudDiscount.Value) / 100;
            lblSubtotalValue.Text = FormatCurrency(subtotal);
            lblTotalValue.Text = FormatCurrency(total);
        }

        private static string FormatCurrency(decimal amount)
        {
            return $"{amount:N0} ₫";
        }

        private void lstSelectedServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private sealed record ServiceItem(string Name, decimal Price)
        {
            public override string ToString()
            {
                return $"{Name} - {Price:N0} ₫";
            }
        }
    }
}
