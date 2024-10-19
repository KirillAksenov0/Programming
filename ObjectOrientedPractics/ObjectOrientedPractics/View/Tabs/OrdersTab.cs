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

        private int _selectedOrderIndex;

        private string _selectedDeliveryTime;

        private Order _selectedOrder;

        private PriorityOrder _selectedPriorityOrder;

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
                _selectedOrderIndex = OrdersDataGridView.SelectedRows[0].Index;
                _selectedOrder = Orders[_selectedOrderIndex];

                if (_selectedOrder is PriorityOrder)
                {
                    PriorityOptionsPanel.Visible = true;
                    _selectedPriorityOrder = _orders[_selectedOrderIndex] as PriorityOrder;
                    DeliveryTimeComboBox.SelectedIndex = ((int)_selectedPriorityOrder.DesiredDeliveryTime);
                }

                else if (_selectedOrder is Order)
                {
                    PriorityOptionsPanel.Visible = false;
                    _selectedPriorityOrder = null;
                }

                IDTextBox.Text = _selectedOrder.ID.ToString();
                CreatedTextBox.Text = _selectedOrder.OrderDate.ToString();
                StatusComboBox.SelectedItem = _selectedOrder.OrderStatus;

                customerAddressControl1.OurAddress = _selectedOrder.DeliveryAddress;
                customerAddressControl1.UpdateTextBoxs();
                TotalCostLabel.Text = _selectedOrder.ItemsAmount.ToString();

                OrderItemsListBox.Items.Clear();
                for (int i = 0; i < _selectedOrder.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(_selectedOrder.Items[i].Name);
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

        /// <summary>
        /// Обновляет время доставки текущего заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedDeliveryTime = DeliveryTimeComboBox.Text;
                switch (_selectedDeliveryTime)
                {
                    case "9:00 - 11:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Morning;
                        break;
                    case "11:00 - 13:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Lunch;
                        break;
                    case "13:00 - 15:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Afternoon;
                        break;
                    case "15:00 - 17:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Evening;
                        break;
                    case "17:00 - 19:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.LateEvening;
                        break;
                    case "19:00 - 21:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Night;
                        break;
                }
            }
            catch (Exception) { }
        }
    }
}
