using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player : Character
    {
        private int _yen = 47;
        public int _potion = 5;
        public int _weaponValue = 1;
        private Item[] _inventory;

        public Player() : base()
        {
            _yen = 66;
            _inventory = new Item[3];
        }
        public Item[] GetInventory()
        {
            return _inventory;
        }
        public void AddItemToInventory(Item item, int index)
        {
            _inventory[index] = item;
        }
        public bool Contains(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;

        }
        private void Buy(Item item, int inventoryIndex)
        {
            // checks if player has enough
            if (_yen >= item.cost)
            {
                //pay for it 
                _yen -= item.cost;
                //place item in inventory
                _inventory[inventoryIndex] = item;
               

            }
            
            
        }

    }


}