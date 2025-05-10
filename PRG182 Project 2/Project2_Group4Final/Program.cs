using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Group5
{

    internal class Program
    {
        public static List<string> MenuItems = new List<string>();
        public static float Total=0;
        enum Menu
        {
            Breakfast=1,
            Combos,
            
            Burgers,                            //Bianca assisted with the creation of the Enum Menu
            Drinks,

            Checkout
        }
        public static void Breakfast()
        {
           // float Total = 0;
            
            Console.WriteLine("1.Breakfast special: R40");
            Console.WriteLine("2.Hashbrown and egg: R20");
            Console.WriteLine("3.Sunday Special   : R60");
            Console.WriteLine("4.Back");
            Console.WriteLine(  );
            Console.WriteLine("Please make a choice");

            int BreakfastChoice = Convert.ToInt32(Console.ReadLine());
            switch (BreakfastChoice)
            {
                case 1:
                    MenuItems.Add("Breakfast special                \tR40");
                    Total = Total+40;
                    break;
                case 2:
                    MenuItems.Add("Hashbrown and egg                \tR20");
                    Total = Total+20;
                    break;
                case 3:
                    MenuItems.Add("Sunday Special                   \tR60");
                    Total = Total+60;
                    break;
                case 4:
                    //show main menu
                   
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice, 1 to 4 ");
                    break;
            }

        }
        static void Drinks()
        {
            Console.WriteLine("1.Soft Drinks");
            Console.WriteLine("2.Milkshake");
            Console.WriteLine("3.Juice");
            Console.WriteLine("4.HotDrinks");
            Console.WriteLine("5.Back");
            Console.WriteLine();
            Console.WriteLine("Please make a choice");

            int Drink = Convert.ToInt32(Console.ReadLine());
            switch (Drink)
            {
                case 1:
                    SoftDrinks();
                    break;
                case 2:
                    Milkshake();
                    break;
                case 3:
                    Juice();
                    break;
                case 4:
                    HotDrinks();
                    break;
                case 5:
                    //back to main menu
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    break;
            }






        }
        static void SoftDrinks()
        {
            Console.WriteLine("1.Fanta         :R15");
            Console.WriteLine("2.Cream Soda    :R15");
            Console.WriteLine("3.Sprite        :R15");
            Console.WriteLine("4.Please make a choice: R15");

            int ComboChoice = Convert.ToInt32(Console.ReadLine());
            switch (ComboChoice)
            {
                case 1:
                    MenuItems.Add("Fanta                     \tR15");
                    Total = Total + 15;
                    break;
                case 2:
                    MenuItems.Add("Crem Soda                   \tR15");
                    Total = Total + 15;
                    break;
                case 3:
                    MenuItems.Add("Sprite                       \tR15");
                    Total = Total + 15;
                    break;
             
                case 5:
                    //back to menu
                    break;
                default:
                    Console.WriteLine("Enter valid choice 1 to 3");
                    break;
            }
        }






    
        static void Milkshake()
        {
            Console.WriteLine("1.Chocolate Milkshake: R25");
            Console.WriteLine("2.Vanilla Milkshake : R25" );
            Console.WriteLine("3.Caramel Milkshake   : R25");
            Console.WriteLine("Please make a choice");

            int ShakeChoice = Convert.ToInt32(Console.ReadLine());
            switch (ShakeChoice)
            {
                case 1:
                    MenuItems.Add("Chocolate Milkshake          \tR25");
                    Total = Total + 25;
                    break;
                case 2:
                    MenuItems.Add("Vanilla Milkshake             \tR25");
                    Total = Total + 25;
                    break;
                case 3:
                    MenuItems.Add("Caramel Milkshake             \tR25");
                    Total = Total + 25;
                    break;
     
                default:
                    Console.WriteLine("Enter valid choice, 1 to 3");
                    break;
            }
        }





    
        static void Juice()
        {
            Console.WriteLine("1.Blueberry Juice: R10");
            Console.WriteLine("2.Blue Dog  Juice: R10");
            Console.WriteLine("3.Super Punch    : R10");
            Console.WriteLine();
            Console.WriteLine("Please make a choice");

            int juiceChoice = Convert.ToInt32(Console.ReadLine());
            switch (juiceChoice)
            {
                case 1:
                    MenuItems.Add("Blueberry Juice          \tR10");
                    Total = Total + 10;
                    break;
                case 2:
                    MenuItems.Add("Blue Dog  Juice           \tR10");
                    Total = Total + 10;
                    break;
                case 3:
                    MenuItems.Add("Super Punch                \tR10");
                    Total = Total + 10;
                    break;

                default:
                    Console.WriteLine("Enter valid choice 1 to 3");
                    break;
            }
        }
    
        static void HotDrinks()
        {
            Console.WriteLine("1.Cappuchino:R25");
            Console.WriteLine("2.Hot Chocolate:R20");
            Console.WriteLine("3.Coffee:R15");
            Console.WriteLine("4.Tea:R15");
            Console.WriteLine();
            Console.WriteLine("Please make a choice");

            int ComboChoice = Convert.ToInt32(Console.ReadLine());
            switch (ComboChoice)
            {
                case 1:
                    MenuItems.Add("Cappuchino                 \tR25");
                    Total = Total + 25;
                    break;
                case 2:
                    MenuItems.Add("Hot Chocolate              \tR20");
                    Total = Total + 20;
                    break;
                case 3:
                    MenuItems.Add("Coffee                     \tR15");
                    Total = Total + 15;
                    break;
                case 4:
                    MenuItems.Add("Tea                        \tR15");
                    Total = Total + 15;
                    break;
                default:
                    Console.WriteLine("Enter valid choice, 1 to 4");
                    break;
            }
        }
    
        static void Combos()
        {
            Console.WriteLine("1.Hash Brown Milkshake Combo:R50");
            Console.WriteLine("2.Bacon Egg and Tea Combo:R75");
            Console.WriteLine("3.Cheese Toast and Juice :R60");
            Console.WriteLine("4.Bread and Amaasi       :R100");

            int ComboChoice = Convert.ToInt32(Console.ReadLine());
            switch (ComboChoice)
            {
                case 1:
                    MenuItems.Add("Hash Brown Milkshake Combo \tR50");
                    Total = Total + 50;
                    break;
                case 2:
                    MenuItems.Add("Bacon Egg and Tea Combo    \tR75");
                    Total = Total + 75;
                    break;
                case 3:
                    MenuItems.Add("Cheese Toast and Juice     \tR60");
                    Total = Total + 60;
                    break;
                case 4:
                    MenuItems.Add("Bread and Amaasi           \tR100");
                    Total = Total + 100;
                     break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        }
        static void YourOrder()
        {
            Console.WriteLine("You have ordered the following: ");
            foreach (var item in MenuItems)
            {
                Console.WriteLine( item);

            }
            int itemNum=  MenuItems.Count();
            Console.WriteLine("Your total for your "+itemNum +" items order is     R"+Total+",00");
        }
        static void Burger()
        {
            Console.WriteLine("1.Chicken:  R50");//Food choices were created by Norman
            Console.WriteLine("2.Beef:     R50");
            Console.WriteLine("3.Vegan:    R50");
            Console.WriteLine("4.Please make a choice");

            int ComboChoice = Convert.ToInt32(Console.ReadLine());
            switch (ComboChoice)//                                              Switch case and code execution was created by Sfiso
            {
                case 1:
                    MenuItems.Add("Hash Brown Milkshake Combo   \tR50");
                    Total = Total + 50;
                    break;
                case 2:
                    MenuItems.Add("Bacon Egg and Tea Combo    \tR50");
                    Total = Total + 50;
                    break;
                case 3:
                    MenuItems.Add("Cheese Toast and Juice     \tR50");
                    Total = Total + 50;
                    break;
               
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        }
    
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit) //The while true loop was created by Jason
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("            FOOD MENU                   ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1.BREAKFAST");
                Console.WriteLine("2. COMBOS");
                
                Console.WriteLine("3. BURGERS");
                Console.WriteLine("4. DRINKS");       //Norman created the menu interface and menu food choices
                Console.WriteLine("5. CHECKOUT");
                Console.WriteLine();
                Console.WriteLine("Kindly make a choice");

                if (Enum.TryParse(Console.ReadLine(), out Menu option)) //Allows you to Parse a menu option. This was successfully executed by Mananga.
                {
                    switch (option)
                    {
                        case Menu.Breakfast:
                            Console.Clear();
                            Breakfast(); //The various methods were created by Mananga
                            
                       break;




                       
                       case Menu.Combos:
                            Console.Clear();
                            Combos();


                            break;

                        case Menu.Burgers:
                            Console.Clear();
                            Burger();
                            break;


                        case Menu.Drinks:
                            Console.Clear();
                            Drinks();
                            break;

                        case Menu.Checkout:
                            Console.Clear();
                            YourOrder();
                            Console.WriteLine(  "");
                            Console.WriteLine("Do you want to check out order? Y/N:(Yes or No)");
                            string checkout= Console.ReadLine();

                           checkout= checkout.ToUpper();
                            if (checkout=="Y")
                            {
                                exit = true;
                                Console.WriteLine("Order Confirmed, have a good day");    //The checkout method was created by Sfiso.
                                System.Environment.Exit(0);
                            }

                            else if (checkout=="N")
                            {
                                exit = false;
                            }
                   

                            break;









                    }

                   
                       
                   

                  
                  

                    Console.ReadKey();









                }





































            }



        }
    }
}
