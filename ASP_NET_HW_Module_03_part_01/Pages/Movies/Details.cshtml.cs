using ListMovies;
using ModelMovies;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HW_Module_03_part_01.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        public FilmStorage filmStorage = new FilmStorage();
        public Movie movie = new Movie();
        public void OnGet(int id)
        {
            movie = filmStorage.GetById(id);
        }
    }
}
