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
        public IProduct CurrentProduct;
		public ProductPage (IProduct product)
		{
			InitializeComponent ();
            CurrentProduct = product;
            BindingContext = this;
		}
        
    }
}