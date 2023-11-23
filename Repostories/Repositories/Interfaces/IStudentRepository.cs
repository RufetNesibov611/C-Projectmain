using Domain.Models;
using Repostories.Repostories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.Repositories.Interfaces
{
     public interface IStudentRepository : IBaseRepository<Students>
    {
        List<Students> Search(string name);
        List<Students> Filter(int age);
    }
}
