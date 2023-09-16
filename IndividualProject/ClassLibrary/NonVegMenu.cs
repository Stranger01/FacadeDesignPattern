/******************************************************************************
* Filename    = NonVegMenu.cs
*
* Author      = Manikanta Gudipudi
*
* Product     = SoftwareDesignPatterns
* 
* Project     = FacadeDesignPattern
*
* Description = Non veg menu available in a hotel
*****************************************************************************/
namespace Hotel
{
    /// <summary>
    /// Inherited from menu Interface and contains details about Non veg food items available in the hotel
    /// </summary>
    internal class NonVegMenu : Menu
    {
        private string[] _menu = { "Chicken Curry", "Chicken Biryani", "Omelette" }; // list that contains non veg food items in the menu
        /// <summary>
        /// Displays the items in the menu.
        /// </summary>
        public string ShowMenu()
        {
            string items = "";
            foreach (string item in _menu)
            {
                items += item;
                items += "\n";
            }
            return items;
        }
        /// <summary>
        /// adds new non veg items into the menu
        /// </summary>
        /// <param name="item">new non veg food item to be added.</param>
        public string AddItem(string item)
        {
            if (_menu.Contains(item))
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
        /// removes the exisisting non veg item from the menu
        /// </summary>
        /// <param name="item">non veg food item to be removed.</param>
        public string RemoveItem(string item)
        {
            if (_menu.Contains(item))
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
