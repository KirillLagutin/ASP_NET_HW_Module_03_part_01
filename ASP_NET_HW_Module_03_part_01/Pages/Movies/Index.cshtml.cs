using ASP_NET_HW_Module_03_part_01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HW_Module_03_part_01.Movies
{
    public class IndexModel : PageModel
    {
        public List<Movie> movies { get; set; }

        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Title = "Вышка",
                    Producer = "Скотт Манн",
                    Genre = "Триллер",
                    Description = "Вышка...",
                    Sessions = new List<string> {"10:00", "14:30", "19:45" }
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Проклятый остров",
                    Producer = "Расселл Оуэн",
                    Genre = "Ужасы",
                    Description = "Проклятый остров...",
                    Sessions = new List<string> {"11:00", "15:30", "21:00" }
                },
                new Movie()
                {
                    Id = 3,
                    Title = "Гостья из космоса",
                    Producer = "Амалия Несбю Фик",
                    Genre = "Мультфильм",
                    Description = "Гостья из космоса...",
                    Sessions = new List<string> {"10:15", "14:00", "18:00" }
                }
            };
        }

        public void OnGet()
        {
            movies = GetMovies();
        }
    }
}
