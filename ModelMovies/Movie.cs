using System.ComponentModel.DataAnnotations;

namespace ModelMovies
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30,MinimumLength = 3)]
        [Display(Name = "Название")]
        public string Title { get; set; }
        [Display(Name = "Режиссёр")]
        public string Producer { get; set; }
        [Display(Name = "Жанр")]
        public string Genre { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Сеансы")]
        public List<DateTime> Sessions { get; set; }
    }
}