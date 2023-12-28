using Project.Data.Repository;
using Project.Entity;
using System;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class ExpeditureService
    {
        private readonly ExpeditureRepository expeditureRepository;

        public ExpeditureService()
        {
            this.expeditureRepository = new ExpeditureRepository();
        }

        public bool Create(Expenditure entity)
        {
            return expeditureRepository.Create(entity);
        }

        public bool Delete(int id)
        {
            return expeditureRepository.Delete(id);
        }

        public Expenditure Get(int id)
        {
            return expeditureRepository.Get(id);
        }

        public IEnumerable<Expenditure> GetAll()
        {
            return expeditureRepository.GetAll();
        }

        public IEnumerable<Expenditure> GetBySpecificDate(DateTime date)
        {
            return expeditureRepository.GetBySpecificDate(date);
        }

        public bool Update(Expenditure entity)
        {
            return expeditureRepository.Update(entity);
        }
    }
}
