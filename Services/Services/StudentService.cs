using Domain.Models;
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
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentService;

        public StudentService()
        {
           _studentService = new StudentRepository();
        }
        public void Create(Students students)
        {
            _studentService.Create(students);
        }

        public void Delete(Students students)
        {
            _studentService.Delete(students);
        }

        public void Edit(Students students)
        {
            _studentService.Edit(students);
        }

        public List<Students> Filter(int age)
        {
            return _studentService.Filter(age);
        }

        public List<Students> GetAll()
        {
            return _studentService.GetAll();
        }

        public Students GetById(int id)
        {
            return _studentService.GetById(id);
        }

        public List<Students> Search(string name)
        {
            return _studentService.Search(name);
        }
    }
}

