using System;
using RazorModels;

namespace RazorServices
{
	public interface IHotelsRepository
	{
		public IEnumerable<Hotel> GetAllHotels();
        public Hotel? GetHotel(int id);
        public Hotel Add(Hotel hotel);
        public Hotel Update(Hotel uHotel);
        public Hotel Delete(int id);
    }
}

