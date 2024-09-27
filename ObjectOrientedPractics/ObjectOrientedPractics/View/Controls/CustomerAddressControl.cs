using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class CustomerAddressControl : UserControl
    {
        private Address _address;

        /// <summary>
        /// Возвращает и задаёт адрес.
        /// </summary>
        public Address OurAddress { get { return _address; } set { _address = value; } }

        public CustomerAddressControl()
        {
            InitializeComponent();
            _address = new Address();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = Int32.Parse(PostIndexTextBox.Text);
                PostIndexTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (PostIndexTextBox.Text != "")
                {
                    PostIndexTextBox.BackColor = Color.Orange;
                }
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                CountryTextBox.BackColor = Color.Orange;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                CityTextBox.BackColor = Color.Orange;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
                
            }
            catch (Exception)
            {
                StreetTextBox.BackColor = Color.Orange;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                BuildingTextBox.BackColor = Color.Orange;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                ApartmentTextBox.BackColor = Color.Orange;
            }
        }

        /// <summary>
        /// Обновляет текстбоксы.
        /// </summary>
        public void UpdateTextBoxs()
        {
            PostIndexTextBox.Text = OurAddress.Index.ToString();
            CountryTextBox.Text = OurAddress.Country.ToString();
            CityTextBox.Text = OurAddress.City.ToString();
            StreetTextBox.Text = OurAddress.Street.ToString();
            BuildingTextBox.Text = OurAddress.Building.ToString();
            ApartmentTextBox.Text = OurAddress.Apartment.ToString();

        }

        /// <summary>
        /// Очищает текстбоксы.
        /// </summary>
        public void ClearTextBoxs()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

        }
    }
}
