using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Player 
    {
        private int _yen = 47;
        public int _potion = 5;
        public int _weaponValue = 1;
        private Item[] _inventory;

        public Player()
        {
            _yen = 66;
            _inventory = new Item[3];
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