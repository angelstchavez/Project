using Project.Data.Interface;
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
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return this.userRepository.GetAll();
        }

        public bool Update(User entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
