namespace MoviesAPI.DTOs
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Synopsis { get; set; } = string.Empty;

        public int Runtime { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
    }
}