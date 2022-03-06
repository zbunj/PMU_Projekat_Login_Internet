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
    public partial class ProfilePage : ContentPage
    {
        public SignInResponse SessionData { get; set; }
        public ProfilePage(SignInResponse data)
        {
            InitializeComponent();
            SessionData = data;
            BindingContext = this;
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }


        private async void CloseApp(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();

        }
    }
}