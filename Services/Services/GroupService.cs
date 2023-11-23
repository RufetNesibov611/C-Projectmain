using Repostories.Repositories;
using Repostories.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GroupService : IGroupService
    {

        private readonly IGroupRepository _groupRepo;

        public GroupService()
        {
            _groupRepo = new GroupRepository();
        }
        public void Create(Group group)
        {
            _groupRepo.Create(group);
        }

        public void Delete(Group group)
        {
            _groupRepo.Delete(group);
        }

        public void Edit(Group group)
        {
            _groupRepo.Edit(group);
        }

        public List<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        public Group GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Group> Search(string searcText)
        {
            throw new NotImplementedException();
        }

        public List<Group> Sorting(int capacity)
        {
            throw new NotImplementedException();
        }
    }
}
