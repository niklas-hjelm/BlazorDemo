using System.Runtime.CompilerServices;

namespace BlazorDemo.Data
{
    public class HeroRepository
    {
        private readonly IDictionary<int, Hero> _heroes;

        private int _id;

        public HeroRepository()
        {
            _heroes = new Dictionary<int, Hero>();
            _heroes.Add(_id++, new Hero()
            {
                HeroName = "Spider Man", 
                Name = "Peter Parker", 
                Powers = new List<string>(){"Agility", "Web shooting", "Spider Sense"}
            });
            _heroes.Add(_id++, new Hero()
            {
                HeroName = "Captain America",
                Name = "Steve Rogers",
                Powers = new List<string>() { "Agility", "Inspiring", "Strong" }
            });
        }

        public bool CreateHero(Hero hero)
        {
            if (_heroes.Values.Contains(hero))
                return false;
            _heroes.Add(_id++, hero);
            return true;
        }

        public ICollection<Hero> GetAllHeroes()
        {
            return _heroes.Values;
        }

        public Hero? GetHero(int id)
        {
            if (!_heroes.Keys.Contains(id))
                return null;
            return _heroes[id];
        }

        public bool UpdateHero(int id, Hero hero)
        {
            if (!_heroes.Keys.Contains(id))
            {
                return false;
            }

            _heroes[id] = hero;

            return true;
        }

        public bool UpdateHeroName(int id, string name)
        {
            if (!_heroes.Keys.Contains(id))
            {
                return false;
            }

            _heroes[id].Name = name;

            return true;
        }

        public bool DeleteHero(int id)
        {
            if (!_heroes.Keys.Contains(id))
            {
                return false;
            }

            _heroes.Remove(id);

            return true;
        }
    }
}