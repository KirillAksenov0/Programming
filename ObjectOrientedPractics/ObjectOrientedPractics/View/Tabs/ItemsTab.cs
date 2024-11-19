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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items;

        private List<Item> _displayedItems;
        private Item selectedItem;

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public ItemsTab()
        {
            InitializeComponent();
            _items = new List<Item>();
            _displayedItems = new List<Item>();


            SortingComboBox.SelectedIndex = 0;

            FillingCategoryComboBox();

        }

        public event EventHandler ItemsChanged;

        /// <summary>
        /// Обновляет все данные в ItemsTab.
        /// </summary>
        public void RefreshData()
        {
            
            ClearTextBox();
            UpdateItemsListBox();
            UpdateTextBox();
            FillingCategoryComboBox();
            
        }

        /// <summary>
        /// Заполняет CategoryComboBox.
        /// </summary>
        private void FillingCategoryComboBox()
        {
            foreach (Category category in Enum.GetValues(typeof(Category)))

                CategoryComboBox.Items.Add(category);
        }

        /// <summary>
        /// Обновляет данные в ItemsListBox.
        /// </summary>
        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }
        }

        /// <summary>
        /// Сортирует список по выбранному методу.
        /// </summary>
        private void SortingMethodSelection()
        {
            if (SortingComboBox.SelectedIndex != -1)
            {
                switch (SortingComboBox.SelectedItem.ToString())
                {
                    case "Name":
                        {
                            DataTools.ItemSorting(_displayedItems, DataTools.CompareAscendingByName);
                            break;
                        }
                    case "Cost (Ascending)":
                        {
                            DataTools.ItemSorting(_displayedItems, DataTools.CompareAscending);
                            break;
                        }
                    case "Cost (Descending)":
                        {
                            DataTools.ItemSorting(_displayedItems, DataTools.CompareDescending);
                            break;
                        }
                }

            }
            else
            {
                DataTools.ItemSorting(_displayedItems, DataTools.CompareAscendingByName);
            }
        }

        /// <summary>
        /// Добавляет новые товары в список и ItemsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void AddButton_Click(object sender, EventArgs e)
        {
            ValidateCategoryComboBox();
            try
            {
                selectedItem = new Item(NameTextBox.Text, DescriptionTextBox.Text,
                    Convert.ToDouble(CostTextBox.Text), (Category)CategoryComboBox.SelectedItem);

                Items.Add(selectedItem);

                _displayedItems.Add(selectedItem);

                SortingMethodSelection();
                UpdateItemsListBox();

                ItemsChanged?.Invoke(this, new EventArgs());

            }
            catch (FormatException)
            {
                throw new Exception("Cost должен быть больше 0 и меньше 100000");
            }

        }

        /// <summary>
        /// Отображает изменения в данных товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обновляет данныее в TextBox.
        /// </summary>
        private void UpdateTextBox()
        {

            Item SelectedValue = _displayedItems[ItemsListBox.SelectedIndex];

            NameTextBox.Text = SelectedValue.Name;
            CostTextBox.Text = Convert.ToString(SelectedValue.Cost);
            DescriptionTextBox.Text = SelectedValue.Info;
            IDTextBox.Text = Convert.ToString(SelectedValue.ID);
            CategoryComboBox.SelectedItem = SelectedValue.Category;
        }

        /// <summary>
        /// Очищает данные в TextBox.
        /// </summary>
        private void ClearTextBox()
        {
            NameTextBox.Text = "";
            NameTextBox.BackColor = SystemColors.Window;

            CostTextBox.Text = "";
            CostTextBox.BackColor = SystemColors.Window;

            DescriptionTextBox.Text = "";
            IDTextBox.Text = "";

            CategoryComboBox.SelectedItem = null;
        }

        /// <summary>
        /// Обеспечивает валидацию значений в CostTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обеспечивает валидацию значений в NameTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обеспечивает валидацию значений в DescriptionTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Удаляет выбранный товар из списка и ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);

                _displayedItems.RemoveAt(ItemsListBox.SelectedIndex);

                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);

                ClearTextBox();
            }

            SortingMethodSelection();
            UpdateItemsListBox();

            ItemsChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Сохраняет изменениия в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void EditButton_Click(object sender, EventArgs e)
        {
            ValidateCategoryComboBox();
            try
            {

                if (ItemsListBox.SelectedIndex != -1)
                {
                    _displayedItems[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    _displayedItems[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                    _displayedItems[ItemsListBox.SelectedIndex].Cost = Convert.ToDouble(CostTextBox.Text);
                    _displayedItems[ItemsListBox.SelectedIndex].Category = (Category)CategoryComboBox.SelectedItem;
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = NameTextBox.Text;

                    SortingMethodSelection();
                    UpdateItemsListBox();

                    ItemsChanged?.Invoke(this, new EventArgs());
                }
            }
            catch (FormatException)
            {
                throw new Exception("Cost должен быть больше 0 и меньше 100000");
            }
        }

        /// <summary>
        /// Выполняет валидацию значении в CategoryComboBox.
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void ValidateCategoryComboBox()
        {
            if (string.IsNullOrWhiteSpace(CategoryComboBox.Text))
            {
                CategoryComboBox.BackColor = Color.LightPink;
                throw new Exception("Выберите значение Category");

            }
            else
            {
                CategoryComboBox.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Организует поисковую строку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string subString = SearchTextBox.Text;
            _displayedItems =
                DataTools.ItemFiltering(Items, (item) => { return item.Name.Contains(subString); });

            ItemsListBox.Items.Clear();

            foreach (Item item in _displayedItems)
            {
                ItemsListBox.Items.Add(item.Name);
            }


        }

        /// <summary>
        /// Сортирует список при смене метода сортировки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortingMethodSelection();
            UpdateItemsListBox();
        }
    }
}
