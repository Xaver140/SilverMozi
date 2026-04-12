namespace asztali.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DurationMinutes { get; set; }
        public int? ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string FilmImg { get; set; }
        public bool IsActive { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Producer { get; set; }
        public int? AgeLimit { get; set; }

        public override string ToString()
        {
            if (ReleaseYear.HasValue)
                return $"{Title} ({ReleaseYear.Value})";

            return Title;
        }
    }
}