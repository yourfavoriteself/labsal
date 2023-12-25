using System;
using RazorModels;

namespace RazorServices
{
	public class MockSightsRepository : ISightsRepository
	{
		List<Sight> __sights;

		public MockSightsRepository()
		{
			__sights = new List<Sight>()
			{
				new Sight()
				{
					SightId = 0
				},
				new Sight()
				{
					SightId = 1
				},
				new Sight()
				{
					SightId = 2
				}
			};
		}

        public Sight Add(Sight sight)
        {
            sight.SightId = __sights.Max(x => x.SightId) + 1;
            __sights.Add(sight);
            return sight;
        }

        public Sight Delete(int id)
        {
            var sight = __sights.FirstOrDefault(p => p.SightId == id);
            if (sight != null)
            {
                __sights.Remove(sight);
            }
            return sight;
        }

        public IEnumerable<Sight> GetAllSights()
        {
			return __sights;
        }

        public Sight? GetSight(int id)
        {
            return __sights.FirstOrDefault(p => p.SightId == id);
        }

        public Sight Update(Sight uSight)
        {
            Sight sight = __sights.FirstOrDefault(p => p.SightId == uSight.SightId);
            if (sight != null)
            {
				sight.SightId = uSight.SightId;
            }
            return sight;
        }
    }
}

