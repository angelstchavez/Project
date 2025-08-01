﻿using Project.Data.Interface;
using Project.Data.Repository;
using Project.Entity;
using System;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class ExpeditureService : IExpeditureRepository
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

        public IEnumerable<Expenditure> GetAllExpensesByDate(DateTime date)
        {
            return expeditureRepository.GetAllExpensesByDate(date);
        }

        public IEnumerable<Expenditure> GetBySpecificDate(DateTime date)
        {
            return expeditureRepository.GetBySpecificDate(date);
        }

        public IEnumerable<Expenditure> GetExpenditureByMonth(int month, int year)
        {
            return expeditureRepository.GetExpenditureByMonth(month, year);
        }

        public int GetExpenditureCount()
        {
            return expeditureRepository.GetExpenditureCount();
        }

        public IEnumerable<SpendingByCategory> GetMonthlyExpenditureByCategory()
        {
            return expeditureRepository.GetMonthlyExpenditureByCategory();
        }

        public decimal GetTotalExpenditureAmount()
        {
            return expeditureRepository.GetTotalExpenditureAmount();
        }

        public IEnumerable<SpendingByCategory> GetTotalExpenditureByCategory()
        {
            return expeditureRepository.GetTotalExpenditureByCategory();
        }

        public decimal GetTotalExpendituresForToday()
        {
            return expeditureRepository.GetTotalExpendituresForToday();
        }

        public IEnumerable<ExpenditureDay> GetTotalExpensesPerDay()
        {
            return this.expeditureRepository.GetTotalExpensesPerDay();
        }

        public bool Update(Expenditure expenditure)
        {
            return expeditureRepository.Update(expenditure);
        }
    }
}
