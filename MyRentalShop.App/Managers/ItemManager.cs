using MyRentalShop.App.Concrete;
using MyRentalShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop.App.Managers
{
    public class ItemManager
    {
        private readonly MenuActionServices _actionServices;
        private BookService _bookService;

        public ItemManager(MenuActionServices actionServices)
        {
            _bookService = new BookService();
            _actionServices = actionServices;
        }
        public ConsoleKeyInfo AddNewBookView(MenuActionServices actionServices)
        {
            var addNewBookMenu = _actionServices.GetMenuActionsByMenuName("AddNewBookMenu");
            Console.WriteLine("Wybierz kategorię książki:");
            for (int i = 0; i < addNewBookMenu.Count; i++)
            {
                Console.WriteLine($"{addNewBookMenu[i].Id}. {addNewBookMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            return operation;
        }
    }
}
