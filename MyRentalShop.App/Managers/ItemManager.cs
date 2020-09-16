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
        public int AddNewBook()
        {
            var addNewBookMenu = _actionServices.GetMenuActionsByMenuName("AddNewBookMenu");
            Console.WriteLine("Wybierz kategorię książki:");
            for (int i = 0; i < addNewBookMenu.Count; i++)
            {
                Console.WriteLine($"{addNewBookMenu[i].Id}. {addNewBookMenu[i].Name}");
            }

            var lastId = _actionServices.GetLastId();
            var newId = lastId + 1;

            var operation = Console.ReadKey();
            int bookTypeId;
            Int32.TryParse(operation.KeyChar.ToString(), out bookTypeId);

            
            Console.WriteLine("Podaj tytuł książki:");
            var title = Console.ReadLine();

            Console.WriteLine("Podaj autora książki:");
            var author = Console.ReadLine();

            Console.WriteLine("Podaj krótki opis książki:");
            var description = Console.ReadLine();

            Console.WriteLine("Podaj rok wydania książki:");
            var tmp = Console.ReadLine();
            int edition;
            Int32.TryParse(tmp, out edition);


            Book book = new Book(newId, bookTypeId, title, author, description, edition);
            _bookService.AddItem(book);
            return book.Id;
        }
    }
}
