using System;
using RazorModels;

namespace RazorServices
{
	public interface ISightsRepository
	{
		public IEnumerable<Sight> GetAllSights();
        public Sight? GetSight(int id);
        public Sight Add(Sight sight);
        public Sight Update(Sight uSight);
        public Sight Delete(int id);
    }
}

