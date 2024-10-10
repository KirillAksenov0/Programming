using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers;

        private List<Order> _orders;

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public OrdersTab()
        {
            InitializeComponent();
            Customers = new List<Customer>();
            Orders = new List<Order>();

            IDTextBox.ReadOnly = true;
            CreatedTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Обновляет данные списка заказов.
        /// </summary>
        private void UpdateOrders()
        {
            Orders.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                for (int j = 0; j < Customers[i].OrderList.Count; j++)
                {
                    Orders.Add(Customers[i].OrderList[j]);
                }
            }
        }

        /// <summary>
        /// Обновляет данные таблицы OrdersDataGridView.
        /// </summary>
        private void UpdateOrdersDataGridView()
        {
            OrdersDataGridView.Rows.Clear();
            for (int i = 0; i < Orders.Count; i++)
            {
                OrdersDataGridView.Rows.Add(Orders[i].ID, Orders[i].OrderDate, Orders[i].OrderStatus,
                    Orders[i].CustomerFullName, $"{Orders[i].DeliveryAddress.Country}, " +
                    $"{Orders[i].DeliveryAddress.City}, {Orders[i].DeliveryAddress.Street}, " +
                    $"{Orders[i].DeliveryAddress.Building}, {Orders[i].DeliveryAddress.Apartment}",
                    Orders[i].ItemsAmount);
            }
        }

        /// <summary>
        /// Очищает StatusComboBox.
        /// </summary>
        private void ClearStatusComboBox()
        {
            StatusComboBox.Items.Clear();
        }

        /// <summary>
        /// Заполняет StatusComboBox.
        /// </summary>
        private void FillingStatusComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Обновляет все данные в OrdersTab.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();

            UpdateOrdersDataGridView();

            ClearStatusComboBox();
            FillingStatusComboBox();
        }

        /// <summary>
        /// Отображает данные выбранного элемента таблицы в текстбоксах.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = OrdersDataGridView.SelectedRows[0].Index;

                IDTextBox.Text = Orders[selectedIndex].ID.ToString();
                CreatedTextBox.Text = Orders[selectedIndex].OrderDate.ToString();
                StatusComboBox.SelectedItem = Orders[selectedIndex].OrderStatus;

                customerAddressControl1.OurAddress = Orders[selectedIndex].DeliveryAddress;
                customerAddressControl1.UpdateTextBoxs();
                TotalCostLabel.Text = Orders[selectedIndex].ItemsAmount.ToString();

                OrderItemsListBox.Items.Clear();
                for (int i = 0; i < Orders[selectedIndex].Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(Orders[selectedIndex].Items[i].Name);
                }
                

            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        /// <summary>
        /// Обновляет данные статуса заказа у выбранного заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = OrdersDataGridView.SelectedRows[0].Index;
            OrdersDataGridView.SelectedRows[0].Cells[2].Value = StatusComboBox.SelectedItem;

            Orders[selectedIndex].OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }

        /// <summary>
        /// Делает текстбоксы доступными только на чтение.
        /// </summary>
        public void AddressReadOnlyOn()
        {
            customerAddressControl1.AddressReadOnlyOn();
        }
    }
}
