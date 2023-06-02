using MovieStore.Models.Domain;

namespace MovieStore.Models.DTO
{
    public class MovieListVM
    {
        public IQueryable<Movie> MovieList {  get; set; }
    }
}
