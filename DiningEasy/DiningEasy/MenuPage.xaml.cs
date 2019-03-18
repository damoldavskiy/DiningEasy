using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiningEasy
{
	public partial class MenuPage : ContentPage
	{
        ObservableCollection<ICategory> categories = new ObservableCollection<ICategory>();

        public ObservableCollection<ICategory> Categories
        {
            get
            {
                return categories;
            }
            set
            {
                if (categories != value)
                {
                    categories = value;
                    OnPropertyChanged(nameof(Categories));
                }
            }
        }

		public MenuPage()
		{
			InitializeComponent();
            BindingContext = this;

            Load();
		}

        void Load()
        {
            foreach (var category in Model.Manager.CurrentCanteen.Categories)
                Categories.Add(category);
        }

        void CategorySelected(object sender, ItemTappedEventArgs e)
        {
            var item = (ICategory)e.Item;
            if (item is null)
                return;

            DisplayAlert("Selected", item.Name, "OK");
        }
    }
}
