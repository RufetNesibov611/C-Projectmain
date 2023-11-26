using Domain.Models;
using Repostories.Repostories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Repostories.Repositories.Interfaces
{
    public interface IGroupRepository :IBaseRepository<Group>
    {
 
        List<Group> Search(string searcText);
        List<Group> Sorting(int capacity);

    }
}
