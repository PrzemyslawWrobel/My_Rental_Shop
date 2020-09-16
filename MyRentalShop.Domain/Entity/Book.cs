using MyRentalShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop.Domain.Entity
{
    public class Book : BaseEntity
    {
   

        /// <summary>
        /// Tytuł skiążki
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Pełna nazwa autora książki
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Opis książki.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Rok wydania książki
        /// </summary>
        public int Edition { get; set; }

        /// <summary>
        /// Gatunek książki(np dla dzieci, sensacyjna)
        /// </summary>
        public int TypeId { get; set; }

        public Book(int id, int typeId, string title, string author, string description, int edition )
        {
            Id = id;
            Title = title;
            Author = author;
            Description = description;
            Edition = edition;
            TypeId = typeId;
        }
    }
}
