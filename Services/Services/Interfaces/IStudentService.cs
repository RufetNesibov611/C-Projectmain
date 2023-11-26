using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        void Create(Students students);
        void Delete(Students students);
        void Edit(Students students);
        Students GetById(int id);
        List<Students> GetAll();
        List<Students> Search(string name);
        List<Students> Filter(int age);


    }
}
