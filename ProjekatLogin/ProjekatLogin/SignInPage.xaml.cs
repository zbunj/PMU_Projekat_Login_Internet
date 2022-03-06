using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjekatLogin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private async void HandleSignIn(object sender, EventArgs e)
        {
            var request = new SignInRequest()
            {
                username = txtUsername.Text,
                password = txtPassword.Text,
            };

            var response = await SignInService.SignIn(request);

            if (response != null)
            {
                await Navigation.PushAsync(new ProfilePage(response));
            }
            else
            {
                lblInfo.Text = "Neuspesan login";
            }



        }
    }
}