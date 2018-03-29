using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aspronto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class journalPage : ContentPage
	{
		public journalPage ()
		{
			InitializeComponent ();
		}
        private void addContent(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
	}
}