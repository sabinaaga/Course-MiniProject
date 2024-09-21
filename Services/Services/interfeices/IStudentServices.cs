using Domain.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.interfeices
{
    public interface IStudentServices
    {
        public List<Student> GetAll();
        public void Create(Student student );

        public Student GetById(int id);
        public void Delete(int id);

        public List<Student> SearchByNameOrSurname(string text);

        public List<Student> GetAllStudentByAge(int age);
        public List<Student> GetAllStudentByGroupId(int id);

        public void Update(Student student);
    }
}
