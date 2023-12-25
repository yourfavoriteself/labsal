using System;
using RazorModels;

namespace RazorServices
{
    public interface ICitiesRepository
    {
        public IEnumerable<City> GetAllCity();
        public City? GetCity(int id);
        public City Add(City city);
        public City Update(City ucity);
        public City Delete(int id);
        IEnumerable<City> GetAllCities();
    }
}

