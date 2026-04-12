using System;

namespace asztali.Models
{
    public class VetitesListItem
    {
        public int VetitesId { get; set; }
        public int FilmId { get; set; }
        public int TeremId { get; set; }

        public string FilmTitle { get; set; }
        public string FilmImg { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes { get; set; }
        public int? AgeLimit { get; set; }

        public string TeremName { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal BasePrice { get; set; }

        public override string ToString()
        {
            return $"{StartTime:yyyy.MM.dd HH:mm} - {FilmTitle} - {TeremName}";
        }
    }
}