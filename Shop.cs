using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {

        private Item[] _shopInventory;
        private int _yen;
        

        public Shop(Item[] shopInventory)
        {
            _shopInventory = shopInventory;
            _shopInventory = new Item[3];

        }
        public int GetYen()
        {
            return _yen;
        }
        public Item[] GetInventory()
        {
            return _shopInventory;
        }
    }
}
