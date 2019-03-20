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
        public IProduct currentProduct;

        public IProduct CurrentProduct
        {
            get
            {
                return currentProduct;
            }
            set
            {
                if (currentProduct != value)
                {
                    currentProduct = value;
                    OnPropertyChanged(nameof(CurrentProduct));
                }
            }
        }

		public ProductPage (IProduct product)
		{
			InitializeComponent ();
            CurrentProduct = product;

            BindingContext = this;
		}

        void AddToBusket(object sender, EventArgs e)
        {
            Model.Basket.Add(CurrentProduct);
            BasketPage.Instance.Update();
        }
    }
}