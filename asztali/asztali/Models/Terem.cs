namespace asztali.Models
{
    public class Terem
    {
        public int TeremId { get; set; }
        public string Name { get; set; }
        public int TotalRows { get; set; }
        public int SeatsPerRow { get; set; }

        public int Capacity => TotalRows * SeatsPerRow;

        public override string ToString()
        {
            return $"{Name} ({Capacity} fő)";
        }
    }
}