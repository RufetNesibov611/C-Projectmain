using Service.Helpers.Extension;
using Service.Services;
using Service.Services.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Cache;
using System.Threading.Channels;
using Repostories.Repositories.Interfaces;

namespace C_Project.Controllers
{
    public  class StudentController
    {
        private readonly IStudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }
        public void Create()
        {
            ConsoleColor.Green.WriteConsole("Add fullname : ");
        FullName: string fullname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(fullname))
            {
                ConsoleColor.Red.WriteConsole("Enter the fullname");
                goto FullName;
            }


            ConsoleColor.Green.WriteConsole("Add address : ");
           Address: string address = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(address))
            {
                ConsoleColor.Red.WriteConsole("Enter the address");
                goto Address;
            }


            ConsoleColor.Green.WriteConsole("Add phone number : ");
        Phone: string phone = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(phone))
            {
                ConsoleColor.Red.WriteConsole("Enter the phone number");
                goto Phone;
            }



            ConsoleColor.Green.WriteConsole("Add age : ");
        Age : string ageStr = Console.ReadLine();

            int age;

            bool isCorrectAge = int.TryParse(ageStr, out age);
            if (isCorrectAge)
            {

                _studentService.Create(new Students { FullName = fullname, Age = age, Address = address, Phone = phone });
                ConsoleColor.Green.WriteConsole("Student create successed");

            }
            

        }

        public void Delete()
        {
        Id: Console.WriteLine(" Enter Id :");
            string idStr = Console.ReadLine();
            int id;

            bool isTrueId = int.TryParse(idStr, out id);
            if (isTrueId)
            {
                var result = _studentService.GetById(id);

                if (idStr == null)
                {
                    Console.WriteLine("This id not exist.");
                    goto Id;
                }
                else
                {
                    _studentService.Delete(result);
                }

            }
            else
            {
                Console.WriteLine("Id format wrong");
            }

        }
        public void Edit()
        {

        }
        public void GetById()
        {
            Console.WriteLine("Enter id :");
            string IdStr = Console.ReadLine();

            int Id;

            bool IsTrueId = int.TryParse(IdStr, out Id);

            if (!IsTrueId)
            {
                ConsoleColor.Red.WriteConsole("id format is wrong");

            }

            var res = _studentService.GetById(Id);
            Console.WriteLine($"{res.Id} - {res.FullName} - {res.Address}");

        }

        public void GetAll()
        {
            var result = _studentService.GetAll();
            foreach (var students in result)
            {
                string res = $"{students.FullName} - {students.Address} - {students.Phone} - {students.Age}";
                ConsoleColor.Yellow.WriteConsole(res);
            }

        }

        public void Search()
        {

            Console.WriteLine("Add student fullname :");
        Search: string fullname = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(fullname))
            {
                ConsoleColor.Cyan.WriteConsole("Please fill search input");
                goto Search;
            }
            else
            {
                var result = _studentService.Search(fullname);
                foreach (var students in result)
                {
                    Console.WriteLine($"{students.Id} - {students.FullName} - {students.Phone} - {students.Address} - {students.Age} - {students.Group}");
                }
            }
        }

        public void Filter()
        {

            Console.WriteLine(" Select typ : (1) ASC, (2) DSC");
        Filter: string filterStr = Console.ReadLine();
            int filter;
            bool IsTrueTypeFilter = int.TryParse(filterStr, out filter);

            if (!IsTrueTypeFilter)
            {
                Console.WriteLine("Filter type is wrong");
                goto Filter;

            }
            else
            {

                switch (filter)
                {
                    case 1:
                        var res = _studentService.Filter(filter);
                        foreach (var students in res)
                        {
                            Console.WriteLine($"{students.Id} - {students.FullName} - {students.Address} - {students.Phone} - {students.Age}");
                        }
                        break;

                    case 2:
                        var resDsc = _studentService.Filter(filter);
                        foreach (var students in resDsc)
                        {
                            Console.WriteLine($"{students.Id} - {students.FullName} - {students.Address} - {students.Phone} - {students.Age}");
                        }
                        break;

                    default:
                        Console.WriteLine("Filter type not found.");
                        break;
                }
            }

        }
    }
}
