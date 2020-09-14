using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop
{
    public class Book
    {
        /// <summary>
        /// Nr identyfikacyjny książki
        /// </summary>
        public int IdBook { get; set; }

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
    }
}
