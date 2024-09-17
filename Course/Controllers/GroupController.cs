using Course.Helpers.Extensions;
using Services.Services;
using Services.Services.interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Controllers
{
    internal class GroupController
    {
        private readonly IGroupServices groupServices;

        public GroupController()
        {
            groupServices = new GroupServices();
        }

        public void Create()
        {
         ConsoleColor.Red.WriteConsole("Add group name ");
            AddName: string str = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(str))
            {
                ConsoleColor.Red.WriteConsole("Add group room name ");
                room: string room = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(room))
                {


                }
                else
                {


                }
                goto room;


            }
            else
            {
                ConsoleColor.Red.WriteConsole("Add group name again ");
            }
            goto AddName;


        }
    }
}
