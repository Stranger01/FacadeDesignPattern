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
    /// Inherited from rooms Interface and contains details about vacent and filled non ac rooms
    /// </summary>
    internal class NonAcRooms : Rooms
    {
        private int _vacentRooms; //No of vacent non ac rooms
        private readonly int _totalRooms;  //Total no of non ac rooms
        /// <summary>
        /// Creates an instance of the non ac room class.
        /// </summary>
        /// <param name="totalRooms">The number of non ac rooms in the hotel.</param>
        public NonAcRooms(int totalRooms)
        {
            _totalRooms = totalRooms;
            _vacentRooms = totalRooms;
        }
        /// <summary>
        /// Allocates a non ac room to the customer.
        /// </summary>
        public string AllocateRoom()
        {
            if (_vacentRooms == 0)
            {
                return "No vacent Non Ac Rooms available\n";
            }
            else
            {
                _vacentRooms--;
                return "Non Ac Room has been allocated\n";
            }
        }
        /// <summary>
        /// Deallocates a non ac room and adds it to vacent rooms.
        /// </summary>
        public string CheckoutRoom()
        {
            if (_vacentRooms == _totalRooms)
            {
                return "All Non Ac Rooms are vacent!\n";
            }
            else
            {
                _vacentRooms++;
                return "Non Ac Room is vacated and available for allocation\n";
            }
        }
    }
}
