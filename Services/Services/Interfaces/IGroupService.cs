using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IGroupService
    {
        void Create(Group group);
        void Delete(Group group);
        void Edit(Group group);
        Group GetById(int id);
        List<Group> GetAll();
        List<Group> Search(string searcText);
        List<Group> Sorting(int capacity);
    }
}
