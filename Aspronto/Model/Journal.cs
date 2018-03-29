using System;
using SQLite;

namespace Aspronto.Model
{
    public class Journal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { set; get; }

        public DateTime JournalDate { set; get; }

        public string PainIndex { set; get; }

        public string MoodState { set; get; }

        public string SympResult { set; get; }

        public string DietIndex { set; get; }

        public string IntensityLevel { set; get; }
        [MaxLength(250)]
        public string AdditionComment { set; get; }


    }
}
