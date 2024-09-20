using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.Interfeices
{
    public interface IBaseRepositories<T> where T : BaseEntity
    {
        public void Create(T data);


        public List<T> GetAll();
        public void Delate(T data);
        public T GetById(int id);
        public List<T> Search(string text);
        public List<T> GetAllGroup(string text);

        public void Update(T data);



    }
}
