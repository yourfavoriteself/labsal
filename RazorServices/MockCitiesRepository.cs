using System;
using RazorModels;

namespace RazorServices
{
	public class MockCitiesRepository : ICitiesRepository
	{
        private List<City> __cities;

		public MockCitiesRepository()
		{
            __cities = new List<City>()
            {
                new City()
                {
                    CityId = 0,
                    Name = "Milano",
                    IP = "6787"
                },
                new City()
                {
                    CityId = 1,
                    Name = "Paris",
                    IP = "9878"
                },
                new City()
                {
                    CityId = 2,
                    Name = "New York",
                    IP = "5434"
                }
            };
		}

        public City Add(City city)
        {
            city.CityId = __cities.Max(x => x.CityId) + 1;
            __cities.Add(city);
            return city;
        }

        public City Delete(int id)
        {
            var city = __cities.FirstOrDefault(p => p.CityId == id);
            if (city != null)
            {
                __cities.Remove(city);
            }
            return city;
        }

        public IEnumerable<City> GetAllCities()
        {
            return __cities;
        }

        public IEnumerable<City> GetAllCity()
        {
            throw new NotImplementedException();
        }

        public City? GetCity(int id)
        {
            return __cities.FirstOrDefault(p => p.CityId == id);
        }

        public City Update(City uCity)
        {
            City pass = __cities.FirstOrDefault(p => p.CityId == uCity.CityId);
            if (pass != null)
            {
                pass.Name = uCity.Name;
                pass.IP = uCity.IP;
            }
            return pass;
        }
    }
}

