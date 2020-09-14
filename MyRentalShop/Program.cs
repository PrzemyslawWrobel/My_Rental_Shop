
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
            BookService bookService = new BookService();
            actionServices = Initialize(actionServices);

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
        private static MenuActionServices Initialize(MenuActionServices actionServices)
        {
            actionServices.AddNewAction(1, "Dodaj książkę", "Main");
            actionServices.AddNewAction(2, "Usuń książkę", "Main");
            actionServices.AddNewAction(3, "Pokaż szczegółowe informacje o książce", "Main");
            actionServices.AddNewAction(4, "Pokaż listę książek", "Main");
            actionServices.AddNewAction(5, "Kończymy na dziś", "Main");

            actionServices.AddNewAction(1, "DlaDzieci", "AddNewBookMenu");
            actionServices.AddNewAction(2, "Przygodowa", "AddNewBookMenu");
            actionServices.AddNewAction(3, "Sensacyjna", "AddNewBookMenu");
            actionServices.AddNewAction(4, "Horror", "AddNewBookMenu");
            actionServices.AddNewAction(5, "Romans", "AddNewBookMenu");
            actionServices.AddNewAction(6, "Naukowa", "AddNewBookMenu");
            return actionServices;
        }
        #endregion
    }
}
