using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DiningEasy
{
	public partial class CategoryPage : ContentPage
	{
        ICategory category;

        public ICategory Category
        {
            get
            {
                return category;
            }
            set
            {
                if (category != value)
                {
                    category = value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }

        public CategoryPage(ICategory category)
		{
            InitializeComponent();
            BindingContext = this;

            Category = category;
        }

        async void ProductSelected(object sender, ItemTappedEventArgs e)
        {
            var item = (IProduct)e.Item;
            if (item is null)
                return;

            await Navigation.PushAsync(new ProductPage(item));
        }
    }
}