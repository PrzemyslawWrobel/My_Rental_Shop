using MyRentalShop.App.Common;
using MyRentalShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop.App
{
    public class BookService : BaseService<Book>
    {
        public List<Book> Books { get; set; }

        public BookService()
        {
            Books = new List<Book>();
        }





    //    public int BookDetailSelectionView()
    //    {
    //        Console.WriteLine("Podaj id książki, którą chcesz zobaczyć: ");
    //        var bookId = Console.ReadLine();
    //        int id;
    //        Int32.TryParse(bookId, out id);
    //        return id;
    //    }

    //    public void BookDetailView(int detailId)
    //    {
    //        Book bookToShow = new Book();
    //        foreach (var book in Books)
    //        {
    //            if (book.IdBook == detailId)
    //            {
    //                bookToShow = book;
    //                break;
    //            }
    //        }

    //        Console.WriteLine($"Id Książki: {bookToShow.IdBook}");
    //        Console.WriteLine($"Tytuł Książki: {bookToShow.Title}");
    //        Console.WriteLine($"Autor Książki: {bookToShow.Author}");
    //        Console.WriteLine($"Rok wydania Książki: {bookToShow.Edition}");
    //        Console.WriteLine($"Opis Książki: {bookToShow.Description}");
    //        Console.WriteLine($"Gatunek Książki: {bookToShow.TypeId}");


    //    }

    //    public int BookTypeSelectionView()
    //    {
    //        Console.WriteLine("Jaki gatunek książek chcesz zobaczyć. Podaj gatunek: ");
    //        var typeId = Console.ReadLine();
    //        int id;
    //        Int32.TryParse(typeId, out id);
    //        return id;
    //    }

    //    public void BookByTypeId(int typeId)
    //    {
    //        List<Book> booksToShow = new List<Book>();
    //        foreach (var book in Books)
    //        {
    //            if(book.TypeId == typeId)
    //            {
    //                booksToShow.Add(book);
    //            }
    //        }


    //        for (int i = 0; i < booksToShow.Count ; i++)
    //        {
    //            Console.WriteLine($"Id Książki: {booksToShow[i].IdBook} Tytuł Książki: { booksToShow[i].Title} Autor Książki: {booksToShow[i].Author} Rok wydania Książki: {booksToShow[i].Edition}");
    //            Console.WriteLine(" ");
    //        }

    //    }
    }
}



