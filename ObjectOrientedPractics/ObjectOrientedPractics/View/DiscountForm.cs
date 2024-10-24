using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class DiscountForm : Form
    {
        public Category SelectedCategory { get; set; }

        private CustomersTab _customersTab;
        public DiscountForm(CustomersTab customersTab)
        {
            InitializeComponent();
            FillingCategoryComboBox();
            _customersTab = customersTab;
        }

        /// <summary>
        /// Заполняет CategoryComboBox.
        /// </summary>
        private void FillingCategoryComboBox()
        {
            CategoryComboBox.Items.Clear();

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        /// <summary>
        /// Вызывает метод добавления процентной скидки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != -1)
            {
                SelectedCategory = (Category)CategoryComboBox.SelectedItem;

                _customersTab.AddPercentDiscount(SelectedCategory);
            }
        }

        /// <summary>
        /// Закрывает всплывающее окно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
