using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop
{
    public class MenuActionServices
    {
        private List<MenuAction> menuActions;

        public MenuActionServices()
        {
            menuActions = new List<MenuAction>();
        }
        /// <summary>
        /// Metoda służy do tworzenia menu
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="menuName"></param>
        public void AddNewAction(int id, string name, string menuName)
        {
            MenuAction menuAction = new MenuAction() { Id = id, Name = name, MenuName = menuName };
            menuActions.Add(menuAction);
        }
        /// <summary>
        /// Metoda służy do wyświetlania listy akcji w zależności od poziomu menu
        /// </summary>
        /// <param name="menuName"></param>
        /// <returns></returns>
        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in menuActions)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }  
            } 
            return result;
        }
    }
}
