using Super_Movie_Store.Models;
using Super_Movie_Store.Models.ViewModel;

namespace Super_Movie_Store.Interface
{
    public interface IMovieService
    {

        bool Add(Movie model);
        bool Update(Movie model);
        Movie GetById(int id);
        bool Delete(int id);
        MovieListVm List(string term = "", bool paging = false, int currentPage = 0);
        List<int> GetGenreByMovieId(int movieId);
    }
}
