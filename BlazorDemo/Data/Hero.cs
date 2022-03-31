using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Data
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string HeroName { get; set; } = string.Empty;
        public string Powers { get; set; } = string.Empty;

        public static Hero CopyHero(Hero hero)
        {
            var heroCopy = new Hero();
            heroCopy.Name = hero.Name;
            heroCopy.HeroName = hero.HeroName;
            heroCopy.Powers = hero.Powers;
            return heroCopy;
        }
    }
}
