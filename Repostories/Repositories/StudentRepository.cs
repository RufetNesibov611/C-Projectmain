using Domain.Models;
using Repostories.Data;
using Repostories.Repositories.Interfaces;
using Repostories.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.Repositories
{
    public class StudentRepository : BaseRepository<Students>, IStudentRepository
    {
        public List<Students> Filter(int age)
        {
            return AppDbContext<Students>.Datas.Where(m=>m.Age==age).ToList();
        }

      
        public List<Students> Search(string name)
        {
            return AppDbContext<Students>.Datas.Where(m => m.FullName == name).ToList();
        }
    }
}
