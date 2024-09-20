using Domain.Entityes;
using Repositories.Repositories;
using Repositories.Repositories.Interfeices;
using Services.Services.interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepositories studentRepositories;

        public StudentServices()
        {
            studentRepositories=new StudentRepositories();
        }

        public void Create(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return studentRepositories.GetAll();
        }

        public List<Group> GetAllStudentByAge(string name)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAllStudentByGroupId(string room)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchByNameOrSurname(string text)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
