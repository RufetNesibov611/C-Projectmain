using Domain.Models;
using Repostories.Data;
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
    public class GroupService : IGroupService 
    {

        private readonly IGroupRepository _groupRepo;

        public GroupService()
        {
            _groupRepo = new GroupRepository();
        }

        public Group CheckByName(string name)
        {
          return AppDbContext<Group>.Datas.FirstOrDefault( m => m.Name == name);
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
             return _groupRepo.GetAll();
        }

        public Group GetById(int id)
        {
            return _groupRepo.GetById(id);
        }

        public List<Group> Search(string name)
        {
            return _groupRepo.Search(name);
        }

        public List<Group> Sorting(int capacity)
        {
            return _groupRepo.Sorting(capacity);
        }

    }
}
