using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiningEasy
{
	public partial class BasketPage : ContentPage
	{
        ObservableCollection<IProduct> products = new ObservableCollection<IProduct>();

        public static BasketPage Instance { get; private set; }

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

        public int Cost
        {
            get
            {
                return Model.Basket.FullCost;
            }
        }

        public BasketPage()
		{
			InitializeComponent();
            BindingContext = Instance = this;
		}

        public void Update()
        {
            Products.Clear();
            foreach (var product in Model.Basket.Get())
                Products.Add(product);
            OnPropertyChanged(nameof(Cost));
        }

        async void BuyClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Покупка", "Заказ сформирован", "OK");
        }
    }
}
