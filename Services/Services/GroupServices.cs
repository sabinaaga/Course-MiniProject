using Repositories.Repositories.Interfeices;
using Repositories.Repositories;
using Services.Services.interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entityes;

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

        public Group GetById(int id)
        {
           return groupRepositories.GetById(id);
        }

        public List<Group> SearchByName(string text)
        {
            //var datas= groupRepositories.Search(text);
            return groupRepositories.Search(text).Where(m=>m.Name.Contains(text)).ToList();
        }
    }
}
