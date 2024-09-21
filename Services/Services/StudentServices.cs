﻿using Domain.Entityes;
using Repositories.Exceptions;
using Repositories.Helpers.Constants;
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
            studentRepositories.Create(student);

        }

        public void Delete(int id)
        {

            Student student = studentRepositories.GetById(id);
            studentRepositories.Delate(student);
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
            return studentRepositories.GetById(id);
        }


        public List<Student> SearchByNameOrSurname(string text)
        {
            {
                return studentRepositories.Search(text.ToLower()).Where(m => m.Name.ToLower().Contains(text) || m.Surname.ToLower().Contains(text)).ToList() ?? throw new NotFoundexceptions(ExceptionMessages.NotFound);
            }
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
