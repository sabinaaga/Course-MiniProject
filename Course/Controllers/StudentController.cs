using Course.Helpers.Extensions;
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
        private IStudentServices studentServices;

        public StudentController()
        {
            studentServices=new StudentServices();
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
                string text = $"Id: {item.Id}, Name: {item.Name}, Surname: {item.Surname},Age: {item.Age}, Email: {item.Email}, Group: {item.Group} CreatDate: {item.CreatDate}";
                ConsoleColor.Cyan.WriteConsole(text);
            }
        }
    }
}
