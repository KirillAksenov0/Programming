using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
            _store = new Store();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers= _store.Customers;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 2:
                    {
                        cartsTab1.RefreshData();
                        break;
                    }
                case 3:
                    {
                        ordersTab1.RefreshData();
                        ordersTab1.AddressReadOnlyOn();
                        break;
                    }

            }
        }
    }
}