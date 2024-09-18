using Course.Helpers.Extensions;
using Domain.Entityes;
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
        AddName: string strname = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(strname))
            {
                ConsoleColor.Cyan.WriteConsole("Add group room name ");
            room: string room = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(room))
                {

                    ConsoleColor.Cyan.WriteConsole("Add group teacher name ");
                teacher: string teacher = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(teacher))
                    {
                        groupServices.Create(new Group { Name = strname, Room = room, Teacher = teacher });
                        ConsoleColor.Green.WriteConsole("Group created ");

                    }
                    else
                    {
                        ConsoleColor.Red.WriteConsole("Add group teacher name again ");
                        goto teacher;
                    }

                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Add group room name again ");
                    goto room;

                }


            }
            else
            {
                ConsoleColor.Red.WriteConsole("Add group name again ");
                goto AddName;
            }


        }

        public void GetAll()
        {
            var res= groupServices.GetAll();
            foreach (var group in res)
            {
                string text=$"Id: {group.Id}, Room: {group.Room}, Teacher: {group.Teacher}";
                ConsoleColor.Cyan.WriteConsole(text);
            }
        }

        public void GetById()

        {
            ConsoleColor.Cyan.WriteConsole("Add group Id");
            GroupId: string groupstr =Console.ReadLine();
            bool isCorrectFormat = int.TryParse(groupstr, out int group);
            if (isCorrectFormat)
            {
                try
                {
                    var result = groupServices.GetById(group);
                    string text = $"Id: {result.Id}, Room: {result.Room}, Teacher: {result.Teacher}";
                    ConsoleColor.Cyan.WriteConsole(text);
                }
                catch (Exception ex)
                {
                    ConsoleColor.Red.WriteConsole("Add group Id again, because Id not found ");
                    goto GroupId;


                }

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Add group Id again ");
                goto GroupId;
            }
        }


    }
}
