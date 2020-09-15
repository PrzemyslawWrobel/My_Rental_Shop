
using MyRentalShop.App;
using MyRentalShop.App.Abstract;
using MyRentalShop.App.Concrete;
using MyRentalShop.App.Managers;
using MyRentalShop.Domain.Entity;
using System;
using System.ComponentModel.Design;
using System.Linq;

namespace MyRentalShop
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionServices actionServices = new MenuActionServices();
            ItemManager itemManager = new ItemManager(actionServices);

            Console.WriteLine("Witaj w mojej wypożyczalni!");

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Powiedz mi co chcesz zrobić?");

                var mainMenu = actionServices.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                var operation = Console.ReadKey();
                switch (operation.KeyChar)
                {
                    case '1':
                        var keyInfo = bookService.AddNewBookView(actionServices);
                        var id = bookService.AddNewBook(keyInfo.KeyChar);
                        break;
                    case '2':
                        var removeId = bookService.RemoveBookView();
                        bookService.RemoveBook(removeId);
                        break;
                    case '3':
                        var detailId = bookService.BookDetailSelectionView();
                        bookService.BookDetailView(detailId);
                        break;
                    case '4':
                        var typeId = bookService.BookTypeSelectionView();
                        bookService.BookByTypeId(typeId);
                        break;
                    case '5':
                        exit = false;
                        break;
                 
                    default:
                        Console.WriteLine("Nie ma takiej pozycji w menu.");
                        break;
                }
            }

        }
        #region Metody prywatne

        #endregion
    }
}
