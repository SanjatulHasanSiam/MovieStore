using MovieStore.Models.Domain;

namespace MovieStore.Models.DTO
{
    public class MovieListVM
    {
        public IQueryable<Movie> MovieList {  get; set; }
        public int PageSize { get; set; }
        public int Currentpage { get; set; }
        public int Totalpages { get; set; }
        public string? Term { get;set; }
    }
}
