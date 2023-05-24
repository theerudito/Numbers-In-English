using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NumbersInEnglish.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Info : ContentPage
    {
        public Page_Info()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void instagram_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/theerudito/"));
        }

        private void github_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://github.com/theerudito?tab=repositories"));
        }

        private void web_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://byerudito.web.app/"));
        }

        private void linkedin_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.linkedin.com/in/theerudito/"));
        }
    }
}