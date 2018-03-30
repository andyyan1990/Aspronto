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
            try{
                if (String.IsNullOrEmpty(painSlider.Value.ToString())
               || String.IsNullOrEmpty(moodPicker.SelectedItem.ToString())
               || String.IsNullOrEmpty(SympPicker.SelectedItem.ToString())
               || String.IsNullOrEmpty(dietSlider.Value.ToString())
               || String.IsNullOrEmpty(IntensityPicker.SelectedItem.ToString()))
                {

                    DisplayAlert("Incompele", "Please Fill in all fields", "Okay");

                }
                else
                {

                    DateTime journalDate = JournalDate.Date;
                    string painIndex = painSlider.Value.ToString();
                    string moodState = moodPicker.SelectedItem.ToString();
                    string sympResult = SympPicker.SelectedItem.ToString();
                    string dietIndex = dietSlider.Value.ToString();
                    string intensityLevel = IntensityPicker.SelectedItem.ToString();
                    string additionaCom = String.Empty;

                    if (String.IsNullOrEmpty(additionalComment.Text)
                       || String.IsNullOrWhiteSpace(additionalComment.Text))
                    {

                    }
                    else
                    {
                        additionaCom = additionalComment.Text;
                    }

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
                        Navigation.PopModalAsync();
                    }
                    else
                    {
                        DisplayAlert("Failure", "Journal not Added.", "Okay");
                    }


                }
            }catch(NullReferenceException ex){
                DisplayAlert("Incompele", "Please Fill in all fields", "Okay");
                Console.WriteLine(ex.Message);
                
            }

        }

        void Cancel_Button_Clicked(object sender, EventArgs e)
        { 
            Navigation.PopModalAsync();
        }
    }
}
