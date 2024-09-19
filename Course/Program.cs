


//using MiniProject.Controllers;

//GroupController group = new GroupController();
//group.Create();


using Course.Controllers;
using Course.Helpers.Enums;
using Course.Helpers.Extensions;
using Course.Helpers.Extensions;

GroupController groupController=new GroupController();

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
    ConsoleColor.Cyan.WriteConsole("Please sellect one option: 1-Create 2-GetAll  3-Delete 4-GetById");

}
