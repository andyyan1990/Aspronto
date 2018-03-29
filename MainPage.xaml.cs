using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aspronto
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            moodPicker.Item.Add(Bad);
            moodPicker.Item.Add(Okay);
            moodPicker.Item.Add(Good);
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            dateEntry.Text;
            painResult.Text;
            
            moodPicker.Text;
            symptomResult.isTogged.ToString();

            dietresult.Text;
            changeResult.isTogged.ToString();

            additionalComment.Text;
        }

	}
}
