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
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public List<Group> Search(string searcText)
        {
           return AppDbContext<Group>.Datas.Where(m=>m.Name == searcText).ToList();
        }

        public List<Group> Sorting(int capacity)
        {
            return AppDbContext<Group>.Datas.Where(m=>m.Capacity == capacity).ToList();
        }
    }
}
