using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DiningEasy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Model.Manager.CurrentCanteen = Model.Manager.Storage.GetCanteens().First();
            MainPage =new NavigationPage(new MainPage());
        }
    }
}
