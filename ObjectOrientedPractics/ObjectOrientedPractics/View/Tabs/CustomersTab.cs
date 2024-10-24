﻿using ObjectOrientedPractics.View.Controls;
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
    public partial class CustomersTab : UserControl
    {
        List<Customer> _customers = new List<Customer>();

        private Customer selectedCustomer;

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public CustomersTab()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Заполняет листбокс покупателями.
        /// </summary>
        private void FillCustomersListbox()
        {
            //Очищает.
            CustomersListBox.Items.Clear();

            //Заполняет.
            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.FullName}");
            }
        }
        /// <summary>
        /// Добавляет новых клиентов в список и CustomerListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            selectedCustomer = new Customer("Name", new Address());

            _customers.Add(selectedCustomer);

            FillCustomersListbox();

        }

        /// <summary>
        /// Отображает изменения в данных клиентов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                UpdateTextBox();
            }
            else
            {
                ClearTextBox();
            }
        }

        /// <summary>
        /// Обновляет данныее в TextBox.
        /// </summary>
        private void UpdateTextBox()
        {
            selectedCustomer = _customers[CustomersListBox.SelectedIndex];
            customerAddressControl1.OurAddress = selectedCustomer.CustomerAddress;
            FullNameTextBox.Text = selectedCustomer.FullName;
            IDTextBox.Text = Convert.ToString(selectedCustomer.ID);
            IsPriorityCheckBox.Checked = selectedCustomer.IsPriority;
            customerAddressControl1.UpdateTextBoxs();

            FillCustomersListbox();
        }

        /// <summary>
        /// Очищает данные в TextBox.
        /// </summary>
        private void ClearTextBox()
        {
            FullNameTextBox.Text = "";
            FullNameTextBox.BackColor = SystemColors.Window;
            IDTextBox.Text = "";
            customerAddressControl1.ClearTextBoxs();
            FillCustomersListbox();
        }

        /// <summary>
        /// Обеспечивает валидацию значений в FullNameTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length > 200 || FullNameTextBox.Text.Length == 0)
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
            else
            {
                selectedCustomer.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Удаляет выбранного клиента из списка и ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(selectedCustomer);

            ClearTextBox();
        }

        /// <summary>
        /// Обновляет значение приорететности.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selectedCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }
    }
}
