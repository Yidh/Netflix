using Netflix.Enum;

namespace Netflix.Models
{
    public class Movies
    {

        public Guid MoviesID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int    Rating {get; set; }   
        public CategoryEnum CategoryMovies { get; set; }  
        public Movies() { } 

    }
}
