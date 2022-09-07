namespace ASP_NET_HW_Module_03_part_01.Models
{
    public class Movie
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public List<string> Sessions { get; set; }
    }
}
