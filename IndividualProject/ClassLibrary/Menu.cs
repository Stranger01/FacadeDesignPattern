/******************************************************************************
* Filename    = Menu.cs
*
* Author      = Manikanta Gudipudi
*
* Product     = SoftwareDesignPatterns
* 
* Project     = FacadeDesignPattern
*
* Description = Contract for menu in a hotel
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    /// <summary>
    /// Interface for menu that are available in the hotel.
    /// </summary>
    internal interface Menu
    {
        /// <summary>
        /// Called to display the menu.
        /// </summary>
        string ShowMenu();
        /// <summary>
        /// Called to add a new item to the menu.
        /// </summary>
        string AddItem(string item);
        /// <summary>
        /// Called to remove an item from the menu.
        /// </summary>
        string RemoveItem(string item);
    }
}
