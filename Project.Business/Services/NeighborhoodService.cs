using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Project.Business.Services
{
    public class NeighborhoodService
    {
        private readonly NeighborhoodRepository neighborhoodRepository;

        public NeighborhoodService()
        {
            neighborhoodRepository = new NeighborhoodRepository();
        }

        public IEnumerable<int> GetDistinctCommunes()
        {
            return neighborhoodRepository.GetDistinctCommunes();
        }

        public IEnumerable<Neighborhood> GetByCommune(int communeNumber)
        {
            return neighborhoodRepository.GetByCommune(communeNumber);
        }
    }
}
