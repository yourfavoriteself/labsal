using System;
using RazorModels;

namespace RazorServices
{
	public class SqlHotelsRepository : IHotelsRepository
	{
        private AppDbContext __db;

        public SqlHotelsRepository(AppDbContext db)
		{
            __db = db;
		}

        public Hotel Add(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Hotel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            throw new NotImplementedException();
        }

        public Hotel? GetHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Hotel Update(Hotel uHotel)
        {
            throw new NotImplementedException();
        }
    }

    /*public interface IHotelsRepository
    {
        Hotel Delete(int hotelId);
        IEnumerable<Hotel> GetAllHotels();
        Hotel GetHotel(int value);
        Hotel Update(Hotel hotel);
    }*/
}

