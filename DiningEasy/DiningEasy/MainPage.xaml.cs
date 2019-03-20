using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DiningEasy
{
    public partial class MainPage : MasterDetailPage
    {
        public class MenuItem
        {
            public string Title { get; set; }
            public MenuItemType Type { get; set; }
        }

        public enum MenuItemType
        {
            Menu,
            Canteens
        }

        public IEnumerable<MenuItem> MenuItems
        {
            get
            {
                return new[]
                {
                    new MenuItem { Title = "Меню", Type = MenuItemType.Menu },
                    new MenuItem { Title = "Столовые", Type = MenuItemType.Canteens },
                };
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void MenuItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (MenuItem)e.Item;
            if (item is null)
                return;

            switch (item.Type)
            {
                case MenuItemType.Menu:
                    Detail = new NavigationPage(new MenuBasketPage());
                    IsPresented = false;
                    break;
                case MenuItemType.Canteens:
                    Detail = new NavigationPage(new CanteenPage());
                    IsPresented = false;
                    break;
            }
        }
    }
}
