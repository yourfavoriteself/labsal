using System;
using RazorModels;

namespace RazorServices
{
	public class SqlSightsRepository : ISightsRepository
	{
        private AppDbContext __db;

        public SqlSightsRepository(AppDbContext db)
		{
            __db = db;
		}

        public Sight Add(Sight sight)
        {
            throw new NotImplementedException();
        }

        public Sight Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sight> GetAllSights()
        {
            throw new NotImplementedException();
        }

        public Sight? GetSight(int id)
        {
            throw new NotImplementedException();
        }

        public Sight Update(Sight uSight)
        {
            throw new NotImplementedException();
        }
    }
}

