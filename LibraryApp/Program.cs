

using LibraryApp.Controllers;
using Service.Helpers;
using System.Runtime.InteropServices;

LibraryController libraryController = new();


while (true)
{
    ConsoleColor.Blue.WriteConsole("Select one option");
    ConsoleColor.Blue.WriteConsole("Library options: 1 - Create, 2 - Get by id, 3 - Delete");

    SelectOption:  string option = Console.ReadLine();

    int selectOption;

    bool isParseOption = int.TryParse(option, out selectOption);

    if (isParseOption)
    {
        switch (selectOption)
        {
            case 1:
                libraryController.Create();
                break;
            case 2:
                libraryController.GetById();
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                Console.WriteLine("Select again true option");
                goto SelectOption;

        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Select again true option");
        goto SelectOption;
    }





}