/******************************************************************************
* Filename    = AcRooms.cs
*
* Author      = Manikanta Gudipudi
*
* Product     = SoftwareDesignPatterns
* 
* Project     = FacadeDesignPattern
*
* Description = Ac rooms available for stay in the hotel
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    /// <summary>
    /// Inherited from rooms Interface and contains details about vacent and filled ac rooms
    /// </summary>
    internal class AcRooms : Rooms
    {
        private int _vacentRooms; //No of vacent ac rooms
        private readonly int _totalRooms;  //Total no of ac rooms
        /// <summary>
        /// Creates an instance of the ac room class.
        /// </summary>
        /// <param name="totalRooms">The number of ac rooms in the hotel.</param>
        public AcRooms(int totalRooms)
        {
            _totalRooms = totalRooms;
            _vacentRooms = totalRooms;
        }
        /// <summary>
        /// Allocates an ac room to the customer.
        /// </summary>
        public string AllocateRoom()
        {
            if (_vacentRooms == 0)
            {
                return "No vacent Ac Rooms available\n";
            }
            else
            {
                _vacentRooms--;
                return "Ac Room has been allocated\n";
            }
        }
        /// <summary>
        /// Deallocates an ac room and adds it to vacent rooms.
        /// </summary>
        public string CheckoutRoom()
        {
            if (_vacentRooms == _totalRooms)
            {
                return "All Ac Rooms are vacent\n";
            }
            else
            {
                _vacentRooms++;
                return "Ac Room is vacated and available for allocation\n";
            }
        }
    }
}
