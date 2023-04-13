
using Super_Movie_Store.Models;

namespace Super_Movie_Store.Interface
{
    
   
        public interface IGenreService
        {
            bool Add(Genre model);
            bool Update(Genre model);
            Genre GetById(int id);
            bool Delete(int id);
            IQueryable<Genre> List();

        }
    
}
