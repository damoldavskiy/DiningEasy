using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DiningEasy
{
    public partial class CanteenPage : ContentView
    {
        public IEnumerable<ICanteen> Canteens
        {
            get
            {
                return Model.Manager.Storage.GetCanteens();
            }
        }

		public CanteenPage()
		{
			InitializeComponent();
            BindingContext = this;
		}

        void CanteenSelected(object sender, ItemTappedEventArgs e)
        {
            var item = (ICanteen)e.Item;
            if (item is null)
                return;

            Model.Manager.CurrentCanteen = item;
        }
    }
}