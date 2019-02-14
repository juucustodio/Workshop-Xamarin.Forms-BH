using Demo.ViewModels;
using Xamarin.Forms;

namespace Demo.Views
{
    public partial class HomePage : ContentPage
    {
         public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }
    }
}
