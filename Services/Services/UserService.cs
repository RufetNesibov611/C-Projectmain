using Domain.Models;
using Repostories.Repositories;
using Repostories.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public bool Login(User user)
        {
            return _userRepository.Login(user);
        }

        public void Register(User user)
        {
            _userRepository.Register(user);
        }
    }
}
