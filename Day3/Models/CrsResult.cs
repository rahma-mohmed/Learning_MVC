using System.ComponentModel.DataAnnotations.Schema;

namespace Day3.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Course")]
        public int Crs_id { get; set; }
        [ForeignKey("Trainee")]
        public int Trainee_id { get; set; }
    }
}
