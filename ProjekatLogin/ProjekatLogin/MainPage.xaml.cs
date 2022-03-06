using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace ProjekatLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int moze = 0;
        protected override void OnAppearing()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                labela1.Text = "Povezani ste sa internetom.";
                moze = 1;
                
            }
            else
            {
                labela1.Text = "Niste povezani sa internetom.";
                moze = 0;
            }

            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromHex("#174545");
        }

        private async void NavigateSignIn(object sender, EventArgs e)
        {
            if(moze==1)
            {
                await Navigation.PushAsync(new SignInPage());
            }
            

        }
    }
}
