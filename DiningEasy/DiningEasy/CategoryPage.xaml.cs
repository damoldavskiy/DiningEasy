using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace DiningEasy
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoryPage : ContentView
	{
        ObservableCollection<IProduct> products = new ObservableCollection<IProduct>();

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
        public CategoryPage ()
		{
            InitializeComponent();
            BindingContext = this;

            Load();
        }
        void Load()
        {
            foreach (var prodact in Model.Manager.CurrentCanteen.Categories)
                Products.Add(prodact);
        }
    }
}