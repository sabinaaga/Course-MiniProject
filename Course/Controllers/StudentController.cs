using Course.Helpers.Extensions;
using Domain.Entityes;
using Repositories.Exceptions;
using Repositories.Helpers.Constants;
using Services.Services;
using Services.Services.interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Controllers
{
    public class StudentController
    {
        private readonly GroupController _groupController;

        private readonly GroupServices _groupServices;


        private IStudentServices studentServices;

        public StudentController()
        {
            studentServices = new StudentServices();
            _groupController = new GroupController();
            _groupServices = new GroupServices();
        }

        public void GetAll()
        {
            var student = studentServices.GetAll();
            if (student.Count == 0)
            {
                ConsoleColor.Yellow.WriteConsole("Data not added, pleace add data");

            }
            var res = studentServices.GetAll();
            foreach (var item in res)
            {
                string text = $"Id: {item.Id}, Name: {item.Name}, Surname: {item.Surname},Age: {item.Age}, Email: {item.Email}, Group: {item.Group.Name} CreatDate: {item.CreatDate}";
                ConsoleColor.Cyan.WriteConsole(text);
            }
        }

        public void GetById()
        {
            ConsoleColor.Cyan.WriteConsole("Add student Id");
        StudentId: string studentId = Console.ReadLine();
            bool isCorrectFormat = int.TryParse(studentId, out int group);
            if (isCorrectFormat)
            {
                try
                {
                    var result = studentServices.GetById(group);
                    string text = $"Id: {result.Id}, Name: {result.Name.ToLower()}, Surname: {result.Surname.ToLower()},Age: {result.Age},Email: {result.Email.ToLower()}, Group:  {result.Group}, CreatDate: {result.CreatDate}";
                    ConsoleColor.Cyan.WriteConsole(text);
                }
                catch (Exception ex)
                {
                    ConsoleColor.Red.WriteConsole("Not found");
                    goto StudentId;


                }

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Add group Id again ");
                goto StudentId;
            }
        }

        public void Delete()
        {
            ConsoleColor.Cyan.WriteConsole("Add student  Id");
        StudentId: string studentId = Console.ReadLine();
            bool isCorrectFormat = int.TryParse(studentId, out int student);
            if (isCorrectFormat)
            {
                try
                {
                    studentServices.Delete(student);
                    ConsoleColor.Cyan.WriteConsole("Add Id again");
                }
                catch (Exception ex)
                {
                    ConsoleColor.Red.WriteConsole("Not found");
                    goto StudentId;


                }

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Add student Id again ");
                goto StudentId;
            }
        }

        public void SearchByNameOrSurname()
        {
            ConsoleColor.Cyan.WriteConsole("Pleace add student name or surname");
        Text: string text = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(text))
            {
                try
                {
                    var result = studentServices.SearchByNameOrSurname(text);
                    foreach (var item in result)
                    {
                        string res = $"Id: {item.Id}, Name: {item.Name.ToLower()}, Surname: {item.Surname.ToLower()},Age: {item.Age},Email: {item.Email.ToLower()}, Group:  {item.Group}, CreatDate: {item.CreatDate}";
                        ConsoleColor.Cyan.WriteConsole(res);

                    }


                }
                catch (Exception es)
                {

                    Console.WriteLine(es.Message);
                }
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Pleace add student name or surname");
                goto Text;

            }

        }

        public void Create()
        {
            ConsoleColor.Cyan.WriteConsole("Add student name ");
        AddName: string strname = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(strname))
            {
                ConsoleColor.Red.WriteConsole("Add student surname ");
                goto AddName;
            }
            ConsoleColor.Cyan.WriteConsole("Add student surname ");
        Surname: string surname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(surname))
            {

                ConsoleColor.Red.WriteConsole("Add student surname ");
                goto Surname;
            }
           
            ConsoleColor.Cyan.WriteConsole("Add student age ");
        Age: string age = Console.ReadLine();
            bool isCorrect = int.TryParse(age, out int studentAge);
            if (!isCorrect)
            {
                ConsoleColor.Red.WriteConsole("Add student age ");
                goto Age;

            }
            ConsoleColor.Cyan.WriteConsole("Add student Email ");
        Email: string email = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(email)||!email.Any(e=>e=='@'))

            {

                ConsoleColor.Red.WriteConsole("Add student Email ");
                goto Email;

            }
            ConsoleColor.Cyan.WriteConsole("Add student group ");

            var groups = _groupServices.GetAll();
            if (groups.Count == 0)
            {
                ConsoleColor.Yellow.WriteConsole("Data not added, pleace add data");
                return;



            }
            foreach (var item in groups)
            {
                string text = $"Id: {item.Id},Namee:{item.Name} Room: {item.Room}, Teacher: {item.Teacher}, CreatDate: {item.CreatDate}";
                ConsoleColor.Cyan.WriteConsole(text);
                ConsoleColor.Cyan.WriteConsole("Add student group Id ");
           
            }
        Groups: string groupId = Console.ReadLine();
            bool isCorrects = int.TryParse(groupId, out int studentGroupId);
            if (!isCorrects)
            {

                ConsoleColor.Red.WriteConsole("Add group Id Again");
                goto Groups;

            }
            try
            {
                Group group = _groupServices.GetById(studentGroupId);
                if (group == null)
                {
                    ConsoleColor.Red.WriteConsole("Group does not exist");
                    goto Groups;
                }
                studentServices.Create(new Student { Name = strname, Surname = surname, Age = studentAge, Email = email, Group = group });
                ConsoleColor.Green.WriteConsole(ValidationMessage.CreateSuccess);
            }
            catch(NotFoundexceptions ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
                goto Groups;
            }
            //NotFoundexceptions
        }

        public void GetAllStudentByAge()
        {
            ConsoleColor.Cyan.WriteConsole("Pleace add student age");
        Age: string age = Console.ReadLine();
            bool isCorrectAge=int.TryParse(age, out int studentAge);
            if (isCorrectAge)
            {
                try
                {
                    var result = studentServices.GetAllStudentByAge(studentAge);
                    foreach (var item in result)
                    {
                        string text = $"Id: {item.Id}, Name: {item.Name}, Surname: {item.Surname},Age: {item.Age}, Email: {item.Email}, Group: {item.Group} CreatDate: {item.CreatDate}";
                        ConsoleColor.Cyan.WriteConsole(text);

                    }


                }
                catch (Exception es)
                {

                    Console.WriteLine(es.Message);
                }
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Pleace add student age");
                goto Age;

            }

        }
        public void GetAllStudentByGroupId()
        {
            ConsoleColor.Cyan.WriteConsole("Pleace add student group");
        Group: string group = Console.ReadLine();
            bool isCorrectAge = int.TryParse(group, out int studentGroup);
            if (isCorrectAge)
            {
                try
                {
                    var result = studentServices.GetAllStudentByAge(studentGroup);
                    foreach (var item in result)
                    {
                        string text = $"Id: {item.Id}, Name: {item.Name}, Surname: {item.Surname},Age: {item.Age}, Email: {item.Email}, Group: {item.Group} CreatDate: {item.CreatDate}";
                        ConsoleColor.Cyan.WriteConsole(text);

                    }


                }
                catch (Exception es)
                {

                    Console.WriteLine(es.Message);
                }
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Pleace add student group");
                goto Group;

            }
        }
    }
    
}




               
          



