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
    public partial class ItemsTab : UserControl
    {
        List<Item> _items = new List<Item>();

        private Item selectedItem;
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectedItem = new Item(NameTextBox.Text, DescriptionTextBox.Text,
                    Convert.ToDouble(CostTextBox.Text));

                _items.Add(selectedItem);

                ItemsListBox.Items.Add($"{selectedItem.Name}");
            }
            catch (FormatException)
            {
                throw new Exception("Cost должен быть больше 0 и меньше 100000");
            }

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
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
            Item SelectedValue = _items[ItemsListBox.SelectedIndex];

            NameTextBox.Text = SelectedValue.Name;
            CostTextBox.Text = Convert.ToString(SelectedValue.Cost);
            DescriptionTextBox.Text = SelectedValue.Info;
            IDTextBox.Text = Convert.ToString(SelectedValue.ID);
        }

        private void ClearTextBox()
        {
            NameTextBox.Text = "";
            NameTextBox.BackColor = SystemColors.Window;

            CostTextBox.Text = "";
            CostTextBox.BackColor = SystemColors.Window;

            DescriptionTextBox.Text = "";
            IDTextBox.Text = "";
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(CostTextBox.Text) < 0 || Convert.ToDouble(CostTextBox.Text) > 100000
                  )
                {
                    CostTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    CostTextBox.BackColor = SystemColors.Window;
                }
            }
            catch (FormatException)
            {
                CostTextBox.BackColor = System.Drawing.Color.LightPink;

            }

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 200 || NameTextBox.Text.Length == 0)
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                NameTextBox.BackColor = SystemColors.Window;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text.Length > 1000)
            {
                DescriptionTextBox.BackColor = Color.LightPink;

            }
            else
            {
                DescriptionTextBox.BackColor = SystemColors.Window;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _items.RemoveAt(ItemsListBox.SelectedIndex);

            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);

            ClearTextBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex != -1)
                {
                    _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                    _items[ItemsListBox.SelectedIndex].Cost = Convert.ToDouble(CostTextBox.Text);
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = NameTextBox.Text;
                }
            }
            catch (FormatException)
            {
                throw new Exception("Cost должен быть больше 0 и меньше 100000");
            }
        }
    }
}
