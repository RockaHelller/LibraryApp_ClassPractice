using Domain.Entities;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Controllers
{
    public class LibraryController
    {
        private readonly LibraryService _libraryService;
        public LibraryController()
        {
            _libraryService= new LibraryService();
        }


        public void Create()
        {
            try
            {
                ConsoleColor.Yellow.WriteConsole("Add library name:");

                string name = Console.ReadLine();

                ConsoleColor.Yellow.WriteConsole("Add library seat count:");

            SeatCount: string seatCountStr = Console.ReadLine();

                int seatCount;

                bool isParseSeatCount = int.TryParse(seatCountStr, out seatCount);

                if (isParseSeatCount)
                {
                    Library library = new()
                    {
                        Name = name,
                        SeatCount = seatCount
                    };

                    var result = _libraryService.Create(library);

                    ConsoleColor.Green.WriteConsole($"id: {result.Id}, Name: {result.Name}, Seat count: {result.SeatCount}");


                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct seat count:");
                    goto SeatCount;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            



        }

        public void GetById() 
        {
            try
            {
                ConsoleColor.DarkMagenta.WriteConsole("Write id:");

                id: string idStr = Console.ReadLine();

                int id;

                bool isParseId = int.TryParse(idStr, out id);
                if (isParseId) 
                {
                    var result = _libraryService.GetById(id);
                    ConsoleColor.Green.WriteConsole($"id: {result.Id}, Name: {result.Name}, Seat count: {result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct id:");
                    goto id;
                }



            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
            }
        }
    }
}
