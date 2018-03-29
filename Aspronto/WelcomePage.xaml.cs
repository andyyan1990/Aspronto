using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Aspronto
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();

            var image = new Image { Source = "App_logo.jpg" };
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            AsprontoPage newAsprontoPage = new AsprontoPage();

            Navigation.PushAsync(newAsprontoPage);
            Application.Current.MainPage = new NavigationPage(newAsprontoPage);
            //throw new NotImplementedException();

        }
    }
}
