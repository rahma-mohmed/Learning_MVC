namespace Fayroz.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public List<string> ingredients { get; set; }
        public string? instructions { get; set; }
        public string? image { get; set; }
    }
}
