using Project.Data.Interface;
using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class PrintingAreaService : IPrintingAreaRepository
    {
        private readonly PrintingAreaRepository printingAreaRepository;

        public PrintingAreaService()
        {
            this.printingAreaRepository = new PrintingAreaRepository();
        }

        public bool Create(PrintingArea entity)
        {
            return printingAreaRepository.Create(entity);
        }

        public bool Delete(int id)
        {
            return printingAreaRepository.Delete(id);
        }

        public PrintingArea Get(int id)
        {
            return printingAreaRepository.Get(id);
        }

        public IEnumerable<PrintingArea> GetAll()
        {
            return printingAreaRepository.GetAll();
        }

        public bool Update(PrintingArea entity)
        {
            return printingAreaRepository.Update(entity);
        }
    }
}