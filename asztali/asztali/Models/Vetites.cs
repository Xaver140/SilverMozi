using System;

namespace asztali.Models
{
    public class Vetites
    {
        public int VetitesId { get; set; }
        public int FilmId { get; set; }
        public int TeremId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal BasePrice { get; set; }
    }
}