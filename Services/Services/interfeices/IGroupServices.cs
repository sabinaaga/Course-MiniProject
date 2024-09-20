using Domain.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.interfeices
{
    public interface IGroupServices
    {
        public List<Group> GetAll();
        public void Create(Group group);

        public Group GetById(int id);
            public void Delete(int id);

        public List<Group> SearchByName(string text);

        public List<Group> GetAllGroupByTeacherName(string name);
        public List<Group> GetAllGroupByRoom(string room);

        public void Update(Group group);



    }
}
