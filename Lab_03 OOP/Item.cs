using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_03_OOP
{
    internal class Item
    {
        private int Item_Code;
        private string Item_Name;
        private int Stock_Quantity;

        // Constructor
        public Item(int Item_Code, string Item_Name, int Stock_Quantity)
        {
            Item_Code = Item_Code;
            Item_Name = Item_Name;
            Stock_Quantity = Stock_Quantity;
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Supermarket Inventory:");
            Console.WriteLine($"Item_Code: {Item_Code}");
            Console.WriteLine($"Item_Name: {Item_Name}");
            Console.WriteLine($"Stock_Quantity: {Stock_Quantity}");
        }
    }
}
