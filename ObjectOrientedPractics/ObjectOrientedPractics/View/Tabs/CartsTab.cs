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

        public CartsTab()
        {
            InitializeComponent();
            _items = new List<Item>();
            _customers = new List<Customer>();
        }

        private void FillingCartItemsListBox()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                CartItemsListBox.Items.Add(Items[i].Name);
            }
        }
    }
}
