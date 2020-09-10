﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop
{
    public class BookService
    {
        public List<Book> Books { get; set; }

        public BookService()
        {
            Books = new List<Book>();
        }

        public ConsoleKeyInfo AddNewBookView(MenuActionServices actionServices)
        {
            var addNewBookMenu = actionServices.GetMenuActionsByMenuName("AddNewBookMenu");
            Console.WriteLine("Wybierz kategorię książki:");
            for (int i = 0; i < addNewBookMenu.Count; i++)
            {
                Console.WriteLine($"{addNewBookMenu[i].Id}. {addNewBookMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            return operation;
        }

        public int AddNewBook(char bookType)
        {
            int bookTypeId;
            Int32.TryParse(bookType.ToString(), out bookTypeId);
            Book book = new Book();
            book.TypeId = bookTypeId;

            Console.WriteLine("Podaj Id nowej książki:");
            var id = Console.ReadLine();
            int bookId;
            Int32.TryParse(id, out bookId);

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

            book.Title = title;
            book.Author = author;
            book.Description = description;
            book.Edition = edition;
          

            Books.Add(book);
            return bookId;
        }


        public int RemoveBookView()
        {
            Console.WriteLine("Podaj id książki, którą chcesz usunąć: ");
            var bookId = Console.ReadLine();
            int id;
            Int32.TryParse(bookId, out id);
            return id;
        }

        public void RemoveBook(int removeId)
        {
            Book bookToRemove = new Book();
            foreach (var book in Books)
            {
                if (book.IdBook == removeId)
                {
                    bookToRemove = book;
                    break;
                }
            }
            Books.Remove(bookToRemove);
        }

        public int BookDetailSelectionView()
        {
            Console.WriteLine("Podaj id książki, którą chcesz zobaczyć: ");
            var bookId = Console.ReadLine();
            int id;
            Int32.TryParse(bookId, out id);
            return id;
        }

        public void BookDetailView(int detailId)
        {
            Book bookToShow = new Book();
            foreach (var book in Books)
            {
                if (book.IdBook == detailId)
                {
                    bookToShow = book;
                    break;
                }
            }

            Console.WriteLine($"Id Książki: {bookToShow.IdBook}");
            Console.WriteLine($"Tytuł Książki: {bookToShow.Title}");
            Console.WriteLine($"Autor Książki: {bookToShow.Author}");
            Console.WriteLine($"Rok wydania Książki: {bookToShow.Edition}");
            Console.WriteLine($"Opis Książki: {bookToShow.Description}");
            Console.WriteLine($"Gatunek Książki: {bookToShow.TypeId}");


        }
    }
}



