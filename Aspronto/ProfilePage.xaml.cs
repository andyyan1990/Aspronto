using System;
using System.Collections.Generic;
using Aspronto.Model;
using SQLite;
using Xamarin.Forms;

namespace Aspronto
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            GenderPicker.Items.Add("Male");
            GenderPicker.Items.Add("Female");
            GenderPicker.Items.Add("Prefer not to say");

            SuburbPicker.Items.Add("City of Melbourne");
            SuburbPicker.Items.Add("City of Port Phillip");
            SuburbPicker.Items.Add("City of Yarra");
            SuburbPicker.Items.Add("City of Banyule");
            SuburbPicker.Items.Add("City of Darebin");
            SuburbPicker.Items.Add("City of Hume");
            SuburbPicker.Items.Add("City of Moonee Valley");
            SuburbPicker.Items.Add("Shire of Nillumbik");
            SuburbPicker.Items.Add("City of Whittlesea");
            SuburbPicker.Items.Add("City of Boroondara");
            SuburbPicker.Items.Add("City of Manningham");
            SuburbPicker.Items.Add("City of Maroondah");
            SuburbPicker.Items.Add("City of Whitehorse");
            SuburbPicker.Items.Add("Shire of Yarra Ranges");
            SuburbPicker.Items.Add("City of Bayside");
            SuburbPicker.Items.Add("Shire of Cardinia");
            SuburbPicker.Items.Add("City of Casey");
            SuburbPicker.Items.Add("City of Greater Dandenong");
            SuburbPicker.Items.Add("City of Frankston");
            SuburbPicker.Items.Add("City of Glen Eira");
            SuburbPicker.Items.Add("City of Kingston");
            SuburbPicker.Items.Add("City of Monash");
            SuburbPicker.Items.Add("Shire of Mornington Peninsula");
            SuburbPicker.Items.Add("City of Stonnington");
            SuburbPicker.Items.Add("City of Brimbank");
            SuburbPicker.Items.Add("City of Hobsons Bay");
            SuburbPicker.Items.Add("City of Maribyrnong");
            SuburbPicker.Items.Add("City of Melton");
            SuburbPicker.Items.Add("City of Wyndham");

        }

        void Add_Clicked(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(userName.Text) || String.IsNullOrWhiteSpace(userName.Text))
            {

            }
            else
            {
                Profile newProfile = new Profile()
                {
                    Name = userName.Text,
                    DateOfBirth = dobPicker.Date,
                    Gender = GenderPicker.SelectedItem.ToString(),
                    Suburb = SuburbPicker.SelectedItem.ToString()

                };

                SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
                conn.CreateTable<Profile>();
                int indicator = conn.Insert(newProfile);
                conn.Close();

                if (indicator > 0)
                {
                    DisplayAlert("Success", "Profile Added.", "Okay");
                }
                else
                {
                    DisplayAlert("Failure", "Profile not Added.", "Okay");
                }

            }
        }
    }
}
