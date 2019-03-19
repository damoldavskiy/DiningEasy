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
        ObservableCollection<IProduct> products = new ObservableCollection<IProduct>();
        static ICategory CurrentCategory;

        public ObservableCollection<IProduct> Products
        {
            get
            {
                return products;
            }
            set
            {
                if (products != value)
                {
                    products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }
        public CategoryPage (ICategory currentCategory)
		{
            InitializeComponent();
            BindingContext = this;
            CurrentCategory = currentCategory;

            Load();
        }
        void Load()
        {
            foreach(IProduct product in CurrentCategory.Products)
            {
                Products.Add(product);
            }
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