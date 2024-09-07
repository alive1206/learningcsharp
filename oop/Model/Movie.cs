
namespace MovieObject
{
    class Movie
    {
        public Guid id {get;set;}
        public string title {get;set;}        
        public string description {get;set;}
        public int release {get;set;}
        public string country {get;set;}
    }

    class MovieDto : Movie
    {
        public string[] genre {get;set;}
    }
}