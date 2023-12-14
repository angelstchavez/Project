using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository;

        public UserService()
        {
            this.userRepository = new UserRepository();
        }

        public bool Create(User user)
        {
            return this.userRepository.Create(user);
        }

        public bool Delete(int id)
        {
            return this.userRepository.Delete(id);
        }

        public User Get(int id)
        {
            return this.userRepository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return this.userRepository.GetAll();
        }

        public bool Update(User user)
        {
            return this.userRepository.Update(user);
        }
    }
}
