using System.Runtime.CompilerServices;

namespace BlazorDemo.Data
{
    public class HeroRepository
    {
        private readonly HeroContext _heroContext;

        public HeroRepository(HeroContext heroContext)
        {
            _heroContext = heroContext;
        }

        public bool CreateHero(Hero hero)
        {
            if (GetHero(hero.Id) is not null)
                return false;
            _heroContext.Heroes.Add(hero);
            _heroContext.SaveChanges();
            return true;
        }

        public ICollection<Hero> GetAllHeroes()
        {
            return _heroContext.Heroes.ToList();
        }

        public Hero? GetHero(int id)
        {
            return _heroContext.Heroes.FirstOrDefault(h => h.Id == id);
        }

        //public bool UpdateHero(int id, Hero hero)
        //{
        //    if (!_heroes.Keys.Contains(id))
        //    {
        //        return false;
        //    }

        //    _heroes[id] = hero;

        //    return true;
        //}

        //public bool UpdateHeroName(int id, string name)
        //{
        //    if (!_heroes.Keys.Contains(id))
        //    {
        //        return false;
        //    }

        //    _heroes[id].Name = name;

        //    return true;
        //}

        public bool DeleteHero(int id)
        {
            var heroToDelete = GetHero(id);
            if (heroToDelete is null)
            {
                return false;
            }

            _heroContext.Heroes.Remove(heroToDelete);
            _heroContext.SaveChanges();
            return true;
        }
    }
}