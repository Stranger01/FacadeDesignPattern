/******************************************************************************
* Filename    = Rooms.cs
*
* Author      = Manikanta Gudipudi
*
* Product     = SoftwareDesignPatterns
* 
* Project     = FacadeDesignPattern
*
* Description = Contract for rooms in a hotel
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    /// <summary>
    /// Interface for rooms that can be allocated and vacated.
    /// </summary>
    internal interface Rooms
    {
        /// <summary>
        /// Called when a room has to be allocated.
        /// </summary>
        string AllocateRoom();
        /// <summary>
        /// Called when a room has to be vacated.
        /// </summary>
        string CheckoutRoom();
    }
}
