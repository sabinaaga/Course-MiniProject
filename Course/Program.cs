


//using MiniProject.Controllers;

//GroupController group = new GroupController();
//group.Create();


using Course.Controllers;
using Course.Helpers.Enums;
using Course.Helpers.Extensions;
using Course.Helpers.Extensions;

GroupController groupController=new GroupController();
StudentController studentController=new StudentController();

while (true)
{
    Menu();
    Options: string optionStr = Console.ReadLine();
    bool isCorrectFormatOptions = int.TryParse(optionStr, out int option);
    if (isCorrectFormatOptions)
    {
        switch (option)
        {
            case (int)Options.CreateGroup:
                groupController.Create();
                break;
            case (int)Options.GetAllGroup:
                groupController.GetAll();
                break;
            case (int)Options.DeleteGroup:
                groupController.Delete();
                break;
            case (int)Options.GetByIdGroup:
                groupController.GetById();
                break;
                case (int)Options.SearchByName:
                    groupController.SearchByName();
                    break;
                case (int)Options.GetByNameGroup:
                    groupController.SearchByName();
                break;
            case (int)Options.GetAllGroupByTeacherName:
                groupController.GetAllGroupByTeacherName();
                break;
            case (int)Options.GetAllGroupByRoom:
                groupController.GetAllGroupByRoom();
                break;
                case (int)Options.CreateStudent:
                studentController.Create();
                break;
                case (int)Options.GetAllStudent:
                studentController.GetAll();
                break;
            case (int)Options.GetStudentsById:
                studentController.GetById();
                break;
            case (int)Options.DeleteStudent:
                studentController.Delete();
                break;
            case (int)Options.GetAllStudentsByNameOrSurname:
                studentController.SearchByNameOrSurname();
                break;
            default:
                ConsoleColor.Red.WriteConsole("Pleace select 1,2,3 or 4");
                goto Options;
        }


    }
    else
    {
        ConsoleColor.Red.WriteConsole("Options format wrong, pleace try agein");
        goto Options;
    }

}













static void Menu()
{
    ConsoleColor.Cyan.WriteConsole("Please sellect one option: 1-Create 2-GetAll  3-Delete 4-GetById,5-SearchByName, 6-GetByNameGroup, 7-GetAllGroupByTeacherName, 8-GetAllGroupByRoom, 9-CreateStudent, 10-GetAllStudent, 11-GetStudentsById, 12-DeleteStudent, 13-GetAllStudentsByNameOrSurname");

}
