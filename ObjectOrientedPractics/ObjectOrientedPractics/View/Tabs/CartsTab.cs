using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ObjectOrientedPractics.View.Tabs
{

    public partial class CartsTab : UserControl
    {
        private List<Item> _items;

        private List<Customer> _customers;

        private Customer _currentCustomer;

        private Order _order;
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }

            set
            {
                _customers = value;
            }
        }

        public Customer CurrentCustomer
        {
            get
            {
                return _currentCustomer;
            }
            set
            {
                _currentCustomer = value;
            }
        }

        public Order Order
        {
            get { return _order; }
            set { _order = value; }
        }
        public CartsTab()
        {
            InitializeComponent();
            _items = new List<Item>();
            _customers = new List<Customer>();

        }

        /// <summary>
        /// Заполняет CartItemsListBox.
        /// </summary>
        public void FillingCartItemsListBox()
        {
            ClearCartItemsListBox();

            for (int i = 0; i < Items.Count; i++)
            {
                CartItemsListBox.Items.Add(Items[i].Name);
            }
        }

        /// <summary>
        /// Очищает CartItemsListBox.
        /// </summary>
        private void ClearCartItemsListBox()
        {
            CartItemsListBox.Items.Clear();
        }

        /// <summary>
        /// Очищает CustomerComboBox.
        /// </summary>
        private void ClearCustomerComboBox()
        {
            CustomerComboBox.Items.Clear();
        }

        /// <summary>
        /// Заполняет CustomerComboBox.
        /// </summary>
        public void FillingCustomerComboBox()
        {
            ClearCustomerComboBox();

            for (int i = 0; i < Customers.Count; i++)
            {
                CustomerComboBox.Items.Add(Customers[i].FullName);
            }

            CustomerComboBox.SelectedItem = CustomerComboBox.Items[0];
        }

        /// <summary>
        /// Добавляет выбранные товары в корзину покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {

            if (CartItemsListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.CustomerCart.Items.Add(Items[CartItemsListBox.SelectedIndex]);
                CartListBox.Items.Add(CartItemsListBox.Items[CartItemsListBox.SelectedIndex]);

                TotalCostLabel.Text = Convert.ToString(CurrentCustomer.CustomerCart.Amount);
            }
        }

        /// <summary>
        /// Обновляет данные корзины в зависимости от выбранного пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];

            if (CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];

                CartListBox.Items.Clear();
                for (int i = 0; i < CurrentCustomer.CustomerCart.Items.Count; i++)
                {
                    CartListBox.Items.Add(CurrentCustomer.CustomerCart.Items[i].Name);
                }
                TotalCostLabel.Text = Convert.ToString(CurrentCustomer.CustomerCart.Amount);

            }
        }

        /// <summary>
        /// Удаляет выбранные товары из корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];
            if (CartListBox.SelectedIndex != -1)
            {
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
                CurrentCustomer.CustomerCart.Items.RemoveAt(CartListBox.SelectedIndex + 1);

                TotalCostLabel.Text = Convert.ToString(CurrentCustomer.CustomerCart.Amount);
            }
        }
        
        /// <summary>
        /// Создает заказ покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1 && CurrentCustomer.CustomerCart.Items.Count != 0)
            {
                CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];

                if (CurrentCustomer.IsPriority)
                {
                    DateTime deliveryDate = DateTime.Now.Date;
                    Order = new PriorityOrder(CurrentCustomer.CustomerCart.Items, CurrentCustomer.CustomerAddress
               , CurrentCustomer.FullName, CurrentCustomer.CustomerCart.Amount, deliveryDate, 
               DeliveryTime.Morning);

                    CartListBox.Items.Clear();

                    CurrentCustomer.OrderList.Add(Order);
                    CurrentCustomer.CustomerCart.Items.Clear();
                    TotalCostLabel.Text = Convert.ToString(CurrentCustomer.CustomerCart.Amount);
                }

                else
                {
                    Order = new Order(CurrentCustomer.CustomerCart.Items, CurrentCustomer.CustomerAddress
               , CurrentCustomer.FullName, CurrentCustomer.CustomerCart.Amount);

                    CartListBox.Items.Clear();

                    CurrentCustomer.OrderList.Add(Order);
                    CurrentCustomer.CustomerCart.Items.Clear();
                    TotalCostLabel.Text = Convert.ToString(CurrentCustomer.CustomerCart.Amount);
                }
            }
            
           
        }

        /// <summary>
        /// Обновляет все данные CartsTab.
        /// </summary>
        public void RefreshData()
        {
            FillingCartItemsListBox();
            FillingCustomerComboBox();

            
            if (CustomerComboBox.SelectedItem == CustomerComboBox.Items[0])
            {
                CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];

                CartListBox.Items.Clear();
                for (int i = 0; i < CurrentCustomer.CustomerCart.Items.Count; i++)
                {
                    CartListBox.Items.Add(CurrentCustomer.CustomerCart.Items[i].Name);
                }

                TotalCostLabel.Text = Convert.ToString(CurrentCustomer.CustomerCart.Amount);
            }
        }
    }
}
