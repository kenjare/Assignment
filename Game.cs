using System;

namespace HelloWorld
{
   
    class Game
    {

        private Player _player;
        bool _gameOver = false;
        string _playerName = "the player";
        private int _playerHealth = 100;
        private object Item;
        public Item[] _Inventory;
        private Item _Heklaf;
        private Item _PennyStaff;
        private Item _PencilOfTheSharpening;
        public int _damage;
        private void InitItem()
        {
            _Heklaf.name = "Heklaf";
            _Heklaf.cost = 32;
            _Heklaf._damage = 30;
            _PennyStaff.name = "PennyStaff";
            _PennyStaff.cost = 1;
            _PennyStaff._damage = 11;
            _PencilOfTheSharpening.name = "Pencil Of the Sharpening";
            _PencilOfTheSharpening.cost = 97;
            _PencilOfTheSharpening._damage = 60;

            InitItem();
            
        }
        public void PrintInventory(Item[] inventory)
        {
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + inventory[i].cost);
            }
        }
        public void Start()
        {
            
            Console.WriteLine("Welcome to my game!!!!!!!!!");
            _gameOver = false;
            _player = new Player();
            
        }
        
   
  
        void RequestName()
        {
            //Initialize input value
            char input = ' ';
            //Loop until valid input is given
            while (input != '1')
            {
                //Ask user for name
                Console.WriteLine("Please enter your name.");
                _playerName = Console.ReadLine();
                //Display username 
                Console.WriteLine("Hello " + _playerName);
                //Give the user the option to change their name
                input = GetInput("Yes", "No", "Are you sure you want the name " + _playerName + "?");
                if (input == '2')
                {
                    Console.WriteLine("Change it then");
                }
            }
        }
        
        private void OpenShopMenu()
        {
            //input from player
            char input = Console.ReadKey().KeyChar;
            //item index
            int itemIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        itemIndex = 0;
                        break;
                    }
                case '2':
                    {
                        itemIndex = 2;
                        break;
                    }
                case '3':
                    {
                        itemIndex = 2;
                        break;

                    }
                default:
                    {
                        return;
                    }
                   
            }
            input = GetInput("Heklaf", "PennyStaff", "What would you like");
            Console.WriteLine("What would you like");
            Console.ReadKey();
            Console.WriteLine("Welcome! Please selct an item.");
            PrintInventory(_Inventory);
            if (input == 'A')
            {
                Console.WriteLine("Are you Sure");
                if(input == 2)
                {
                    Console.WriteLine("What would you like");
                }
            }
        }
        void Explore()
        {
            string petname = " Hilda berg";
            char input = ' ';
            input = GetInput("Go Left", "Go right", "You came to giant cup shaped like A head with two paths around it ");
            if (input == '1')
            {
                Console.WriteLine("You Choose to go left and stumble across a giant base with auto turrets, giant sun flowers with a mysterious glow grasp you attention. " +
                    "it shoots giant sun flower seeds at you ");
                Console.WriteLine(" You quickly jump to the side but as you do the flowers roots come through the ground and pull you down suffocating you.");
                _gameOver = true;
            }
            else if (input == '2')
            {
                Console.WriteLine("You continue your journey and head towards Dejungle");
                Console.ReadKey();
            }
            Console.WriteLine("Along the trip the area you are exploring seems to start getting darker until a giant frog with 3 heads and glowing red eyes. You realize it is the fabled Mega Hypototoad.");
            int enemyhealth = 75;
            _gameOver = StartBattle(ref _playerHealth, ref enemyhealth);
            Console.WriteLine("You have gotten 200 yen would you like to visit the shop");
            input = ' ';
            input = GetInput("enter ItemShop", "Continue your journey", "you look a little weak from your last fight good luck weakling");
            if (input == '1')
            {
                Console.WriteLine("Welcome to the Weapon shop");
                Console.ReadKey();
                Console.WriteLine("Press enter to see what we have available");
                Console.ReadKey();

            };
        }


        void EnterRoom(int roomNumber)
        {
            char input = ' ';
            var exitMessage = "";
            switch (roomNumber)
            {

                case 0:
                    {
                        exitMessage = "You Leave casle Castle TamGeo";
                        Console.WriteLine("in front of you stands the entrance to Castle TamGeo");

                        break;
                    }
                case 1:
                case 2:
                    {
                        exitMessage = "You leave TamGeo";
                        Console.WriteLine("in front of you are large behemoth gates");
                        break;
                    }
                default:
                    break;
            }
            if (roomNumber == 0)
            {
                exitMessage = "you depart from castle TamGeo";
                Console.WriteLine("there is the entrace to Castle TamGeo");
            }
            else if (roomNumber == 1)
            {
                Console.WriteLine("you enter the castle's courtyard, There's Bones and stray dogs fighting");
                input = GetInput("Will you go up and see what the buzz is about?", "Or will you  continue to look around ", "theres a booth at the end that says place your bets what will you do?");
                if (input == '1')
                {
                    Console.WriteLine("you walk up to the booth and see that the people roaming the courtyard are betting on straydog fights would you like to gamble?");

                }



            }
            else if (roomNumber >= 2)
            {
                exitMessage = "you left the courtyard";
                Console.WriteLine("");
            }
            Console.WriteLine("You are in " + roomNumber);
            input = GetInput("Go Forward", "Go Back", "Which direction would you like to go?");
            if (input == '1')
            {
                EnterRoom(roomNumber + 1);
            }
            Console.WriteLine("You are leaving room " + roomNumber);

        }
        bool StartBattle(ref int playerHealth, ref int enemyHealth)
        {
            char input = ' ';
            while (playerHealth > 0 && enemyHealth > 0)
            {
                input = GetInput("Attack", "Defend", "What will you do?");
                if (input == '1')
                {
                    enemyHealth -= 10;
                    Console.WriteLine("You did 10 damage to the enemy");
                }
                else if (input == '2')
                {
                    Console.WriteLine("You blocked the enemies attack");
                    Console.ReadKey();
                    continue;
                }
                playerHealth -= 20;
                Console.WriteLine("The enemy did 20 damage to you");
                Console.ReadKey();
            }
            if (playerHealth <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void ViewStats()
        {
            //Prints player stats to screen
            Console.WriteLine(_playerName);
            Console.WriteLine("\nPress any key to continue");
            Console.Write("> ");
            Console.ReadKey();

        }

        char GetInput(string option1, string option2, string query)
        {

            //Initialize input value
            char input = ' ';
            //Loop until a valid input is received
            while (input != '1' && input != '2')
            {
                Console.WriteLine(query);
                //Display options
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. View Stats");
                Console.Write("> ");
                //Get input from user
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                //If the player input 3, call the view stats function
                if (input == '3')
                {
                    ViewStats();
                }
            }
            //return input received from user
            return input;
        }

        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        //Performed once when the game begins
        //Used for initializing variables 
        //Also used for performing start up tasks that should only be done once 

        //Repeated until the game ends
        //Used for all game logic that will repeat
        public void Update()
        {
            RequestName();
            Explore();
            OpenShopMenu();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThank you so much for to playing my game!");
        }
    }


}