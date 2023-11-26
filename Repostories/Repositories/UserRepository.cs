using Domain.Models;
using Repostories.Data;
using Repostories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool Login(User user)
        {
            foreach(var item in AppDbContext<User>.Datas)
            {
                if(item.Email == user.Email && item.Password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public void Register(User user)
        {
            AppDbContext<User>.Datas.Add(user);
        }
    }
}
