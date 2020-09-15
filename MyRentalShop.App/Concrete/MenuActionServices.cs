using MyRentalShop.App.Common;
using MyRentalShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop.App.Concrete

{
    public class MenuActionServices : BaseService<MenuAction>
    {
        public MenuActionServices()
        {
            Initialize();
        }
        /// <summary>
        /// Metoda służy do wyświetlania listy akcji w zależności od poziomu menu
        /// </summary>
        /// <param name="menuName"></param>
        /// <returns></returns>
        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }

        private void Initialize()
        {
            AddItem(new MenuAction(1, "Dodaj książkę", "Main"));
            AddItem(new MenuAction(2, "Usuń książkę", "Main"));
            AddItem(new MenuAction(3, "Pokaż szczegółowe informacje o książce", "Main"));
            AddItem(new MenuAction(4, "Pokaż listę książek", "Main"));
            AddItem(new MenuAction(5, "Kończymy na dziś", "Main"));

            AddItem(new MenuAction(1, "DlaDzieci", "AddNewBookMenu"));
            AddItem(new MenuAction(2, "Przygodowa", "AddNewBookMenu"));
            AddItem(new MenuAction(3, "Sensacyjna", "AddNewBookMenu"));
            AddItem(new MenuAction(4, "Horror", "AddNewBookMenu"));
            AddItem(new MenuAction(5, "Romans", "AddNewBookMenu"));
            AddItem(new MenuAction(6, "Naukowa", "AddNewBookMenu"));
            
        }
    }
}