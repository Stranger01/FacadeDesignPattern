/******************************************************************************
* Filename    = NonAcRooms.cs
*
* Author      = Manikanta Gudipudi
*
* Product     = SoftwareDesignPatterns
* 
* Project     = FacadeDesignPattern
*
* Description = Non Ac rooms available for stay in the hotel
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    /// <summary>
    /// This is a facade class that connects the user to all the other classes it maintains all 
    /// the functionalities in the hotel just like the hotel manager
    /// </summary>
    public class HotelManager
    {
        private readonly VegMenu _vegMenu; // veg menu available in the hotel
        private readonly NonVegMenu _nonVegMenu;  //non veg menu available in the hotel
        private readonly AcRooms _acRooms; //ac rooms in the hotel 
        private readonly NonAcRooms _nonAcRooms; //non ac rooms in the hotel
        /// <summary>
        /// Instantiates new object of hotel manager class
        /// </summary>
        /// <param name="totAcRooms">Total ac rooms in the hotel that are for stay.</param>
        /// <param name="totNonAcRooms">Total ac rooms in the hotel that are for stay.</param>
        public HotelManager(int totAcRooms, int totNonAcRooms) 
        {
            if(totAcRooms <= 0 || totNonAcRooms <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Input");
            }
            _vegMenu = new VegMenu();
            _nonVegMenu = new NonVegMenu();
            _acRooms = new AcRooms(totAcRooms);
            _nonAcRooms = new NonAcRooms(totNonAcRooms);
        }
        /// <summary>
        /// Allocates ac rooms to the customer.
        /// </summary>
        public string AllocateAcRoom()
        {
            return _acRooms.AllocateRoom();
        }
        /// <summary>
        /// Allocates non ac rooms to the customer.
        /// </summary>
        public string AllocateNonAcRoom()
        {
            return _nonAcRooms.AllocateRoom();
        }
        /// <summary>
        /// Allocates any available rooms to the customer with ac rooms as first priority.
        /// </summary>
        public string AllocateRoom()
        {
            string status = _acRooms.AllocateRoom();
            if (status != "No vacent Ac Rooms available\n")
            {
                return status;
            }
            else
            {
                status = _nonAcRooms.AllocateRoom();
                if(status != "No vacent Ac Rooms available\n")
                {
                    return status;
                }
                else
                {
                    return "No vacent Rooms available\n";
                }
            }
        }
        /// <summary>
        /// To vacate an ac room when customer checksout.
        /// </summary>
        public string CheckoutAcRoom()
        {
            return _acRooms.CheckoutRoom();
        }
        /// <summary>
        /// To vacate an non ac room when customer checksout.
        /// </summary>
        public string CheckoutNonAcRoom()
        {
            return _nonAcRooms.CheckoutRoom();
        }
        /// <summary>
        /// Displays veg menu.
        /// </summary>
        public string ShowVegMenu()
        {
            return _vegMenu.ShowMenu();
        }
        /// <summary>
        /// Displays non veg menu.
        /// </summary>
        public string ShowNonVegMenu()
        {
            return _nonVegMenu.ShowMenu();
        }   
        /// <summary>
        /// Displays both veg and non veg menu.
        /// </summary>
        public string ShowVegAndNonVegMenu()
        {
            string vegMenu=_vegMenu.ShowMenu();
            return vegMenu+_nonVegMenu.ShowMenu();
        }
        /// <summary>
        /// adds an item to the veg menu.
        /// </summary>
        public string AddItemToVegMenu(string item)
        {
            return _vegMenu.AddItem(item);
        }
        /// <summary>
        /// adds an item to the non veg menu.
        /// </summary>
        public string AddItemToNonVegMenu(string item)
        {
            return _nonVegMenu.AddItem(item);
        }
        /// <summary>
        /// Removes an item from the veg menu.
        /// </summary>
        public string RemoveItemFromVegMenu(string item)
        {
            return _vegMenu.RemoveItem(item);
        }
        /// <summary>
        /// Removes an item form non veg menu.
        /// </summary>
        public string RemoveItemFromNonVegMenu(string item)
        {
            return _nonVegMenu.RemoveItem(item);
        }
    }
}
