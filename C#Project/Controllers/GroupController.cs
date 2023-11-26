using Service.Helpers.Extension;
using Service.Services;
using Service.Services.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Repostories.Repositories.Interfaces;

namespace C_Project.Controllers
{
    public class GroupController
    {
        private readonly IGroupService _groupService;

        public GroupController()
        {
            _groupService = new GroupService();
        }
        public void Create()
        {
            ConsoleColor.Green.WriteConsole("Add name : ");
        Group: string nameStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameStr))
            {
                ConsoleColor.Red.WriteConsole("Enter the information");
                goto Group;
            }
            var checkName = _groupService.CheckByName(nameStr.ToLower());

            if (checkName != null)
            {
                ConsoleColor.Red.WriteConsole("This group already exists ");
                goto Group;
            }
            ConsoleColor.Green.WriteConsole("Add capacity : ");
            Capacity: string capacityStr = Console.ReadLine();

            int capacity;

            bool isCorrectCapacity = int.TryParse(capacityStr, out capacity);
            if (isCorrectCapacity )
            {
                 
                _groupService.Create(new Group { Name = nameStr, Capacity = capacity });
                ConsoleColor.Green.WriteConsole("Group create successed");

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Capacity is wrong, please try again");
                goto Capacity;
            }
            
            
            
        }
        public void Delete()
        {
            Id: Console.WriteLine(" Enter Id :");
            string idStr = Console.ReadLine();
            int id;

            bool isTrueId = int.TryParse(idStr, out id);
          if (isTrueId )
            {
                var result = _groupService.GetById(id);

                if (idStr == null )
                {
                    Console.WriteLine("This id not exist.");
                }
                else
                {
                    _groupService.Delete(result);
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

            var res = _groupService.GetById(Id);
            Console.WriteLine($"{res.Id} - {res.Name} - {res.Capacity}");


        }
        public void GetAll()
        {
            var result = _groupService.GetAll();
            foreach ( var group in result )
            {
                string res = $"{group.Id} - {group.Name} - {group.Capacity}";
                ConsoleColor.Yellow.WriteConsole(res);
            }

        }
        public void Search()
        {
            Console.WriteLine("Add group name :");
            Search: string name = Console.ReadLine();
         
            
            if(string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Cyan.WriteConsole("Please fill search input");
                goto Search;
            }
            else
            {
                var result = _groupService.Search(name);
                foreach ( var group in result)
                {
                    Console.WriteLine($"{group.Id} - {group.Name} - {group.Capacity}");
                }
            }
          
        }
        public void Sorting()
        {

            Console.WriteLine(" Select typ : (1) ASC, (2) DSC");
            Sorting: string sortingStr = Console.ReadLine(); 
            int sorting;
            bool IsTrueTypeSorting = int.TryParse(sortingStr, out sorting);

            if (!IsTrueTypeSorting)
            {
                Console.WriteLine("Sorting type is wrong");
                goto Sorting;

            }
            else
            {
                
                switch (sorting)
                {
                    case 1:
                        var res = _groupService.Sorting(sorting);
                        foreach ( var group in res)
                        {
                            Console.WriteLine($"{group.Id} - {group.Name} - {group.Capacity}");
                        }
                        break;

                        case 2:
                        var resDsc = _groupService.Sorting(sorting);
                        foreach( var group in resDsc)
                        {
                            Console.WriteLine($"{group.Id} - {group.Name} - {group.Capacity}");
                        }
                        break;

                    default:
                        Console.WriteLine("Sort type not found.");
                        break;
                }
            }

        }

    }
}
