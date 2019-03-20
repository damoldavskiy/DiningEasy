using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiningEasy
{
	public partial class ProductPage : ContentPage
	{
        public IProduct product;

        public IProduct Product
        {
            get
            {
                return product;
            }
            set
            {
                if (product != value)
                {
                    product = value;
                    OnPropertyChanged(nameof(Product));
                }
            }
        }

		public ProductPage (IProduct product)
		{
			InitializeComponent ();
            BindingContext = this;

            Product = product;
		}

        void AddToBusket(object sender, EventArgs e)
        {
            Model.Basket.Add(Product);
            BasketPage.Instance.Update();
        }
    }
}