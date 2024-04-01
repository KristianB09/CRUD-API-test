using WebAPITest.Model;

namespace WebAPITest.Services
{
    public interface IOurHeroService
    {
        List<OurHero> GetAllHeroes(bool? isActive);

        OurHero? GetHeroesByID(int id);

        OurHero AddOurHero(AddUpdateOurHero obj);

        OurHero? UpdateOurHero(int id, AddUpdateOurHero obj);

        bool DeleteHerosByID(int id);
    }
}
