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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        private Address _address;

        public Address OurAddress
        {
            get
            {
                return _address;

            }
            set
            {
                _address = value;
            }
        }

        public void UpdateAddressData()
        {
            IndexTextBox.Text = OurAddress.Index.ToString();
            CountryTextBox.Text = OurAddress.Country.ToString();
            StreetTextBox.Text = OurAddress.Street.ToString();
            BuildingTextBox.Text = OurAddress.Building.ToString();
            CityTextBox.Text = OurAddress.City.ToString();
            ApartmentTextBox.Text = OurAddress.Apartment.ToString();
        }
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = Int32.Parse(IndexTextBox.Text);
                IndexTextBox.BackColor = SystemColors.Window;
            }
            catch (Exception)
            {
                if (IndexTextBox.Text != "")
                {
                    IndexTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        public void ClearTextBoxs()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

        }
    }
}
