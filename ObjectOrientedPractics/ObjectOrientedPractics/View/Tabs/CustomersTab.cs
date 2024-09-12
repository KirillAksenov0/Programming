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
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            selectedCustomer = new Customer(FullNameTextBox.Text, AddressTextBox.Text);

            _customers.Add(selectedCustomer);

            CustomersListBox.Items.Add($"{selectedCustomer.Fullname}");
        }

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

        private void UpdateTextBox()
        {
            Customer SelectedValue = _customers[CustomersListBox.SelectedIndex];

            FullNameTextBox.Text = SelectedValue.Fullname;
            AddressTextBox.Text = SelectedValue.Address;
            IDTextBox.Text = Convert.ToString(SelectedValue.ID);
        }

        private void ClearTextBox()
        {
            FullNameTextBox.Text = "";
            FullNameTextBox.BackColor = SystemColors.Window;

            AddressTextBox.Text = "";
            IDTextBox.Text = "";

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length > 200 || FullNameTextBox.Text.Length == 0)
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
            else
            {
                FullNameTextBox.BackColor = SystemColors.Window;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddressTextBox.Text.Length > 500)
            {
                AddressTextBox.BackColor = Color.LightPink;
            }
            else
            {
                AddressTextBox.BackColor = SystemColors.Window;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _customers.RemoveAt(CustomersListBox.SelectedIndex);

            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);

            ClearTextBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _customers[CustomersListBox.SelectedIndex].Fullname = FullNameTextBox.Text;
                _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = FullNameTextBox.Text;
            }
        }
    }
}
