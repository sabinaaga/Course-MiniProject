using Domain.Entityes;
using Repositories.Repositories.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class StudentRepositories:BaseRepositories<Student>,IStudentRepositories
    {
    }
}
