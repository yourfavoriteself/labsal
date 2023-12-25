using System;
using RazorModels;

namespace RazorServices
{
	public class MockHotelsRepository : IHotelsRepository
	{
        List<Hotel> __hotels { get; set; }
		public MockHotelsRepository()
		{
            __hotels = new List<Hotel>()
            {
                new Hotel()
                {
                    HotelId = 0,
                    CityId = 0,
                    Price = 50
                },
                new Hotel()
                {
                    HotelId = 1,
                    CityId = 1,
                    Price = 100
                },
                new Hotel()
                {
                    HotelId = 2,
                    CityId = 2,
                    Price = 1000
                }
            };
		}

        public Hotel Add(Hotel hotel)
        {
            hotel.CityId = __hotels.Max(x => x.HotelId) + 1;
            __hotels.Add(hotel);
            return hotel;
        }

        public Hotel Delete(int id)
        {
            var hotel = __hotels.FirstOrDefault(p => p.THotelId == id);
            if (hotel != null)
            {
                __hotels.Remove(hotel);
            }
            return hotel;
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            return __hotels;
        }

        public Hotel? GetHotel(int id)
        {
            return __hotels.FirstOrDefault(p => p.HotelId == id);
        }

        public Hotel Update(Hotel uHotel)
        {
            Hotel hotel = __hotels.FirstOrDefault(t => t.HotelId == uHotel.HotelId);
            if (hotel != null)
            {
                hotel.Price = uHotel.Price;
            }
            return hotel;
        }

        public Hotel? Gethotel(int id)
        {
            throw new NotImplementedException();
        }
    }
}

