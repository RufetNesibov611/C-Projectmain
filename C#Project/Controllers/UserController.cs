using Service.Helpers.Extension;
using Service.Services;
using Service.Services.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Project.Controllers
{
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public void Register()
        {
            Console.WriteLine("Add name:");
            string name = Console.ReadLine();

            Console.WriteLine("Add surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Add age:");
            Age : string ageStr = Console.ReadLine();

            int age;
            bool isTrueAge = int.TryParse(ageStr, out age);
            if (isTrueAge)
            {
                Console.WriteLine("Age format is wrong, please try again");
                goto Age;
            }

            Console.WriteLine("Add email ;");
            Mail: string email = Console.ReadLine();

            var res = Regex.IsMatch(email, "@");
            if (!res)
            {
                Console.WriteLine("Email format is wrong, try again:");
                goto Mail;
            }
            Console.WriteLine("Add password:");
            Password: string password = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(password))
            {
                ConsoleColor.Red.WriteConsole("Please enter password : ");
                goto Password;
            }
            Console.WriteLine("Enter your password again :");
            ConfirmPassword: string confirmPassword = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                ConsoleColor.Red.WriteConsole("Please fill input : ");
                goto ConfirmPassword;
            }

            if(password != confirmPassword)
            {
                Console.WriteLine("Please enter same password :");
                goto Password;
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Register successed.");
            }

            _userService.Register(new User { Name = name, Surname = surname, Age = age, Email = email, Password = password });


        }
        public void Login()
        {
            Mail: Console.WriteLine("Add email:");
            string mail  = Console.ReadLine();
            
            var res = Regex.IsMatch(mail, "@");
            if (!res)
            {
                ConsoleColor.Red.WriteConsole("Email format is wrong :");

            }
            Console.WriteLine("Add password :");
            Password: string password = Console.ReadLine();

            if (password == null)
            {
                ConsoleColor.Red.WriteConsole("Please enter password");
                goto Password;
            }
            var users = _userService.Login(new User { Email = mail, Password = password });


            if (users == true)
            {
                ConsoleColor.Blue.WriteConsole("Login success :");

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Email or password is wrong.");
                goto Mail;
            }
        }

        

    }
}
