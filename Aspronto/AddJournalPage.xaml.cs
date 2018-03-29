using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Aspronto.Model;
using SQLite;

namespace Aspronto
{
    public partial class AddJournalPage : ContentPage
    {
        public AddJournalPage()
        {
            InitializeComponent();

            moodPicker.Items.Add("Bad");
            moodPicker.Items.Add("Okay");
            moodPicker.Items.Add("Good");

            SympPicker.Items.Add("Chest Tightness");
            SympPicker.Items.Add("Coughing");
            SympPicker.Items.Add("nasal congestion");
            SympPicker.Items.Add("phlegam production");
            SympPicker.Items.Add("shortness of breath");
            SympPicker.Items.Add("shortness of breath on excretion");
            SympPicker.Items.Add("Wheezing");

            IntensityPicker.Items.Add("Nil");
            IntensityPicker.Items.Add("Slight");
            IntensityPicker.Items.Add("Medium");
            IntensityPicker.Items.Add("Intense");
            IntensityPicker.Items.Add("Crazy");

        }


        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();

        }

        void Handle_DateSelected(object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            //this is for journal date
            //throw new NotImplementedException();
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            //this is for PainSlider
            //throw new NotImplementedException();
        }

        void Handle_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {
            //This is for SymptPicker
            //throw new NotImplementedException();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            //Save data to local DB

            DateTime journalDate = JournalDate.Date;
            String painIndex = painSlider.Value.ToString();
            String moodState = moodPicker.SelectedItem.ToString();
            String sympResult = SympPicker.SelectedItem.ToString();
            String dietIndex = dietSlider.Value.ToString();
            String intensityLevel = IntensityPicker.SelectedItem.ToString();
            String additionaCom = additionalComment.Text;

            Journal newJournal = new Journal()
            {
                JournalDate = journalDate,
                PainIndex = painIndex,
                MoodState = moodState,
                SympResult = sympResult,
                DietIndex = dietIndex,
                IntensityLevel = intensityLevel,
                AdditionComment = additionaCom
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Journal>();
            int indicator = conn.Insert(newJournal);
            conn.Close();

            if (indicator > 0)
            {
                DisplayAlert("Success", "Journal Added.", "Okay");
            }
            else
            {
                DisplayAlert("Failure", "Journal not Added.", "Okay");
            }
        }
    }
}
