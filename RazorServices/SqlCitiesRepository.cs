using System;
using RazorModels;

namespace RazorServices
{
	public class SqlCitiesRepository : ICitiesRepository
	{
        private AppDbContext __db;

		public SqlCitiesRepository(AppDbContext db)
		{
            __db = db;
		}

        public City Add(City city)
        {
            __db.City.Add(city);
            __db.SaveChanges();
            return city;
        }

        public City Delete(int id)
        {
            var passToDel = __db.City.Find(id);

            if (passToDel != null)
            {
                __db.City.Remove(passToDel);
                __db.SaveChanges();
            }
            return passToDel;
        }

        public IEnumerable<City> GetAllCities()
        {
            return __db.City;
        }

        public IEnumerable<City> GetAllCity()
        {
            throw new NotImplementedException();
        }

        public City? GetCity(int id)
        {
            return __db.City.Find(id);
        }

        public City Update(City uCity)
        {
            var pass = __db.City.Attach(uCity);
            pass.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            __db.SaveChanges();
            return uCity;
        }
    }
}

