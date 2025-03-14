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
    public partial class DiscountsTab : UserControl
    {
        private List<Item> _items;

        private PointsDiscount pointsDiscount;
        public List<Item> Items
        {
            get { return _items; }

            set { _items = value; }
        }

        public DiscountsTab()
        {
            InitializeComponent();
            _items = new List<Item>()
            {
                new Item("Item 1", "sss", 20, Category.Books),
                new Item("Item 2", "sss", 30, Category.Books)
            };
            pointsDiscount = new PointsDiscount();

            UpdateLabels();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double discount = pointsDiscount.Calculate(Items);
            DisplayDiscountAmountLabel.Text = $"{discount}";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            double discount = pointsDiscount.Apply(Items);
            DisplayDiscountAmountLabel.Text = $"Сумма скидки: {discount}";
            UpdateLabels();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            pointsDiscount.Update(Items);
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            AmountLabel.Text = $"{CalculateTotalCost()}";
            InfoLabel.Text = pointsDiscount.Info;
        }

        private double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (var item in Items)
            {
                totalCost += item.Cost;
            }
            return totalCost;
        }

    }
}
