using Repositories.Repositories.Interfeices;
using Repositories.Repositories;
using Services.Services.interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entityes;
using Repositories.Exceptions;
using Repositories.Helpers.Constants;
using Repositories.Repositories.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Services.Services
{
    public class GroupServices : IGroupServices
    {
        private readonly IGroupRepositories groupRepositories;


       

        public GroupServices()
        {
            groupRepositories = new GroupRepositories();
        }
        public void Create(Group group)
        {
            groupRepositories.Create(group);
        }

        public void Delete(int id)
        {
            Group group = groupRepositories.GetById(id);

            groupRepositories.Delate(group);
        }

        public List<Group> GetAll()
        {
            return groupRepositories.GetAll();
        }

        public List<Group> GetAllGroupByTeacherName(string name)
        {
            return groupRepositories.GetAllGroup(name).Where(m => m.Name.Contains(name)).ToList() ?? throw new NotFoundexceptions(ExceptionMessages.NotFound);
        }
        public Group GetById(int id)
        {
           return groupRepositories.GetById(id);
        }

        public List<Group> SearchByName(string text)
        {
            //var datas= groupRepositories.Search(text);
            return groupRepositories.Search(text).Where(m=>m.Name.Contains(text)).ToList() ?? throw new NotFoundexceptions(ExceptionMessages.NotFound);
        }

        public List<Group> GetAllGroupByRoom(string room)
        {
            return groupRepositories.GetAllGroup(room).Where(m => m.Room.Contains(room)).ToList() ?? throw new NotFoundexceptions(ExceptionMessages.NotFound);
        }

        public void Update(Group group)
        {
            groupRepositories.Update(group);
        }
    }
}
