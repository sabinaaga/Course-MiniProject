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

        public List<Group> GetAll()
        {
            return groupRepositories.GetAll();
        }
    }
}
