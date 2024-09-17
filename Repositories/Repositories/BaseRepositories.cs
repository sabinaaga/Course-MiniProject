using Domain.Common;
using Repositories.Repositories.Data;
using Repositories.Repositories.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BaseRepositories<T> : IBaseRepositories<T> where T : BaseEntity
    {
        public void Create(T data)
        {
            AppDbContext<T>.datas.Add(data);
        }

        public void Delate(T data)
        {
            AppDbContext<T>.datas.Remove(data);
        }

        public List<T> GetAll()
        {
            return AppDbContext<T>.datas;
        }

        public T GetById(int id)
        {
            return AppDbContext<T>.datas.FirstOrDefault(x => x.Id == id);

        }
    }
}
