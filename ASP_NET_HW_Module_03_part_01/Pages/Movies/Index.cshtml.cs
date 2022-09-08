using Microsoft.AspNetCore.Mvc.RazorPages;
using ListMovies;
using ModelMovies;

namespace ASP_NET_HW_Module_03_part_01.Movies
{
    public class IndexModel : PageModel
    {
        public FilmStorage filmStorage = new FilmStorage();
        public IEnumerable<Movie> movies { get; set; }

        public void OnGet()
        {
            movies = filmStorage.GetMovies();
        }
    }
}
