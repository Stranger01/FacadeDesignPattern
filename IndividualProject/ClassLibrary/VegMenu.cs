/******************************************************************************
* Filename    = VegMenu.cs
*
* Author      = Manikanta Gudipudi
*
* Product     = SoftwareDesignPatterns
* 
* Project     = FacadeDesignPattern
*
* Description = veg menu available in a hotel
*****************************************************************************/
using System;

namespace Hotel
{
    /// <summary>
    /// Inherited from menu Interface and contains details about veg food items available in the hotel
    /// </summary>
    internal class VegMenu : Menu
    {
        private string[] _menu = { "Idly", "Dosa", "Paneer Butter Masala"}; // list that contains veg food items in the menu
        /// <summary>
        /// Displays the items in the menu.
        /// </summary>
        public string ShowMenu()
        {
            string items="";
            foreach(string item in _menu)
            {
                items += item;
                items += "\n";
            }
            return items;
        }
        /// <summary>
        /// adds new veg items into the menu
        /// </summary>
        /// <param name="item">new veg food item to be added.</param>
        public string AddItem(string item)
        {
            if(_menu.Contains(item))
            {
                return "Item already exists in the Menu\n";
            }
            else
            {
                _menu = _menu.Append(item).ToArray();
                return "Item successfully added to menu\n";
            }
        }
        /// <summary>
        /// removes the exisisting veg food item from the menu
        /// </summary>
        /// <param name="item">veg food item to be removed.</param>
        public string RemoveItem(string item)
        {
            if(_menu.Contains(item))
            {
                int index = Array.IndexOf(_menu, item);
                _menu = _menu.Where((e, i) => i != index).ToArray();
                return "Item removed successfully\n";
            }
            else
            {
                return "Item is not there in the menu\n";
            }
        }
    }
}
