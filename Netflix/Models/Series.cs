using Netflix.Enum;

namespace Netflix.Models
{
    public class Series
    {
        public Guid SeriesID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }
        public int Rating { get; set; }
        public CategoryEnum CategorySeries { get; set; }
        public Series() { } 


    }
}
