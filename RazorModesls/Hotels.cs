using System;
namespace RazorModels
{
	public class Hotel
	{
		public int HotelId { get; set; }
		public int CityId { get; set; }
		public float Price { get; set; }
        public int THotelId { get; set; }

        public Hotel()
		{
		}
	}
}

