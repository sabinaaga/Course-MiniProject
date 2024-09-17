using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.Data
{
    public class AppDbContext<T>
    {
        public static List<T> datas;

        public AppDbContext()
        {
            datas = new List<T>();
        }

        public List<T> GetAll()
        {
            return datas;

        }
    }
}
