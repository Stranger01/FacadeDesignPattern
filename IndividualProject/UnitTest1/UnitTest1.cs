/******************************************************************************
* Filename    = UnitTest1.cs
*
* Author      = Manikanta Gudipudi
*
* Product     = SoftwareDesignPatterns
* 
* Project     = FacadeDesignPattern
*
* Description = Test cases to validate the code working
*****************************************************************************/
using Hotel ;
namespace UnitTest1
{
    /// <summary>
    /// Unit tests for the facade pattern.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests to validate view menus.
        /// </summary>
        [TestMethod]
        public void MenuViewTestCase()
        {
            HotelManager hotelManager= new (2,3);
            string? ans = hotelManager.ShowVegMenu();
            ans += hotelManager.ShowVegAndNonVegMenu();
            ans += hotelManager.ShowNonVegMenu();
            Assert.AreEqual("Idly\nDosa\nPaneer Butter Masala\nIdly\nDosa\nPaneer Butter Masala\nChicken Curry\nChicken Biryani\nOmelette\nChicken Curry\nChicken Biryani\nOmelette\n", ans);
        }
        /// <summary>
        /// Test to validate room allocation.
        /// </summary>
        [TestMethod]
        public void RoomAllocationTestCase()
        {
            HotelManager hotelManager = new (2, 3);
            string? ans = hotelManager.AllocateAcRoom();
            ans += hotelManager.AllocateNonAcRoom();
            ans += hotelManager.AllocateRoom();
            ans += hotelManager.AllocateRoom();
            ans += hotelManager.CheckoutAcRoom();
            ans += hotelManager.AllocateAcRoom();
            ans += hotelManager.AllocateAcRoom();
            ans += hotelManager.AllocateNonAcRoom();
            ans += hotelManager.CheckoutNonAcRoom();
            ans += hotelManager.AllocateNonAcRoom();
            ans += hotelManager.AllocateNonAcRoom();
            Assert.AreEqual("Ac Room has been allocated\nNon Ac Room has been allocated\nAc Room has been allocated\nNon Ac Room has been allocated\nAc Room is vacated and available for allocation\nAc Room has been allocated\nNo vacent Ac Rooms available\nNon Ac Room has been allocated\nNon Ac Room is vacated and available for allocation\nNon Ac Room has been allocated\nNo vacent Non Ac Rooms available\n", ans);
        }
        /// <summary>
        /// tests to validate Menu edits.
        /// </summary>
        [TestMethod]
        public void MenuEditTestCase()
        {
            HotelManager hotelManager = new (2, 3);
            string? ans = hotelManager.ShowVegMenu();
            ans += hotelManager.AddItemToVegMenu("Vada");
            ans += hotelManager.ShowVegMenu();
            ans += hotelManager.RemoveItemFromVegMenu("Dosa");
            ans += hotelManager.RemoveItemFromVegMenu("Chapathi");
            Assert.AreEqual("Idly\nDosa\nPaneer Butter Masala\nItem successfully added to menu\nIdly\nDosa\nPaneer Butter Masala\nVada\nItem removed successfully\nItem is not there in the menu\n", ans);
            ans = hotelManager.ShowNonVegMenu();
            ans += hotelManager.AddItemToNonVegMenu("Mutton Curry");
            ans += hotelManager.ShowNonVegMenu();
            ans += hotelManager.RemoveItemFromNonVegMenu("Chicken Curry");
            ans += hotelManager.RemoveItemFromNonVegMenu("Fish Curry");
            Assert.AreEqual("Chicken Curry\nChicken Biryani\nOmelette\nItem successfully added to menu\nChicken Curry\nChicken Biryani\nOmelette\nMutton Curry\nItem removed successfully\nItem is not there in the menu\n", ans);
            ans = hotelManager.ShowVegAndNonVegMenu();
            Assert.AreEqual("Idly\nPaneer Butter Masala\nVada\nChicken Biryani\nOmelette\nMutton Curry\n", ans);
        }
    }
}
