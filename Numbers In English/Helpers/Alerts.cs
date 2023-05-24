using System.Threading.Tasks;
using Xamarin.Forms;

namespace NumbersInEnglish.Helpers
{
    public static class Alerts
    {
        public static async Task LoadAlert(string info, string message, string ok)
        {
            await Application.Current.MainPage.DisplayAlert(info, message, ok);
        }
    }
}