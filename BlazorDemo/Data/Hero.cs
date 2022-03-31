namespace BlazorDemo.Data
{
    public class Hero
    {
        public string Name { get; set; } = string.Empty;
        public string HeroName { get; set; } = string.Empty;
        public ICollection<string> Powers { get; set; } = new List<string>();
    }
}
