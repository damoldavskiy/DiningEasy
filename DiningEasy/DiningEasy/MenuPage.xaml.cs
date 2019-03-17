using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiningEasy
{
	public partial class MenuPage : ContentPage
	{
        public string[] Phones { get; set; }

        public MenuPage()
		{
            InitializeComponent();
            Phones = new string[] { "iPhone 8", "Samsung Galaxy S9", "Huawei P10", "LG G6" };
            this.BindingContext = this;
        }
	}
}
