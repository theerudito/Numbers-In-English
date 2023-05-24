using NumbersInEnglish.ViewsModes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NumbersInEnglish.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Home : ContentPage
    {
        public Page_Home()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new VM_PageHome(Navigation);
        }
    }
}