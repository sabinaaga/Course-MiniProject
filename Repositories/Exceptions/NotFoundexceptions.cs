using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Exceptions
{
    public class NotFoundexceptions:Exception
    {
        public NotFoundexceptions(string message):base(message) { }
        
    }
}
