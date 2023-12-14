using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class ModuleService
    {
        private readonly ModuleRepository moduleRepository;

        public ModuleService()
        {
            this.moduleRepository = new ModuleRepository();
        }

        public bool Create(Module module)
        {
            return this.moduleRepository.Create(module);
        }

        public bool Delete(int id)
        {
            return this.moduleRepository.Delete(id);
        }

        public Module Get(int id)
        {
            return this.moduleRepository.Get(id);
        }

        public IEnumerable<Module> GetAll()
        {
            return this.moduleRepository.GetAll();
        }

        public IEnumerable<Module> GetModulesByUserId(int id)
        {
            return this.moduleRepository.GetModulesByUserId(id);
        }

        public bool Update(Module module)
        {
            return this.moduleRepository.Update(module);
        }
    }
}
