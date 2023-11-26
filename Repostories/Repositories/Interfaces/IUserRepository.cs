using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool Login(User user);
        void Register(User user);

    }
}
