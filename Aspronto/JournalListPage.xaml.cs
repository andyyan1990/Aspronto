using System;
using System.Collections.Generic;
using System.Linq;
using Aspronto.Model;
using SQLite;
using Xamarin.Forms;

namespace Aspronto
{
    public partial class JournalListPage : ContentPage
    {
        public JournalListPage()
        {
            InitializeComponent();

        }

		protected override void OnAppearing()
		{
            base.OnAppearing();
            //SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            //conn.CreateTable<Journal>();
            //var Journals = conn.Table<Journal>().ToList();
            //journals.ItemsSource = Journals;
            //conn.Close();


		}

		void Handle_Clicked(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();
            //Button button = (Button)sender;
            AddJournalPage newJournalPage = new AddJournalPage();
            Navigation.PushAsync(newJournalPage);
        }
    }
}
