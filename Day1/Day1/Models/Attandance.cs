using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    public class Attandance
    {
        public int ID { get; set; }
        public int NoOFAbs { get; set; }
        public int NoOFAttend { get; set; }
        [ForeignKey("std")]
        public int std_id { get; set; }
        public Student std { get; set; }
    }
}
