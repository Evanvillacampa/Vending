using System;
namespace VendingMachine{
    class Program{
        static void Main(){
            
            
            int loop = 0;
            int totalPrice;
            int Cocacola = 48;
            int Pepsi = 45;
            int Royal = 46;
            int Sprite = 43;
            int Lemonade = 20;
            int Mug_Rootbeer = 49;
            int Yakult = 36;
            int Mountain_Dew = 43;
            
            
            
            
            
            
            do {
                Console.WriteLine("-----------Vending Machine-----------");
                Console.WriteLine("-----------Choose a drink------------");
                Console.WriteLine("           1. Cocacola               ");
                Console.WriteLine("           2. Pepsi                  ");
                Console.WriteLine("           3. Royal                  ");
                Console.WriteLine("           4. Sprite                 ");
                Console.WriteLine("           5. Lemonade               ");
                Console.WriteLine("           6. Mug Rootbeer           ");
                Console.WriteLine("           7. YaKult                 ");
                Console.WriteLine("           8. Mountain Dew           ");
                Console.WriteLine("___________PRESS 0 TO EXIT___________");
                
                Console.WriteLine("         ENTER YOUR CHOICE           ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                
                if (userInput == 1){
                    Console.WriteLine("         You Selected Cocacola       ");
                    Console.WriteLine("          Cocacola = P48             ");
                    
                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());
                    
                    totalPrice = Cocacola * amountOfdrinks;
                    
                    Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " Cocacola Yes or No");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes"){
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Cocacola = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower()== "no"){
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue; // pag pinili yung no ibabalik sya sa choose a drink
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    
                    
                    
                }
                else if (userInput == 2){
                    Console.WriteLine("          You Selected Pepsi         ");
                    Console.WriteLine("             Pepsi = P45             ");
                    
                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());
                    
                    totalPrice = Pepsi * amountOfdrinks;
                    
                    Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " Pepsi Yes or NO");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes"){
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Pepsi = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower()== "no"){
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue; 
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 3){
                    Console.WriteLine("          You Selected Royal         ");
                    Console.WriteLine("              Royal = P46            ");
                    
                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());
                    
                    totalPrice = Royal * amountOfdrinks;
                    
                    Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " Royal Yes or No");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes"){
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Royal = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower()== "no"){
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    
                    
                }
                else if (userInput == 4){
                    Console.WriteLine("          You Selected Sprite        ");
                    Console.WriteLine("             Sprite = P43            ");
                    
                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());
                    
                    totalPrice = Sprite * amountOfdrinks;
                    
                    Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " Sprite Yes or No");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes"){
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks +  " Sprite = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower()== "no"){
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 5){
                    Console.WriteLine("       You Selected Lemonade         ");
                    Console.WriteLine("           Lemonade = P20            ");
                    
                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());
                    
                    totalPrice = Lemonade * amountOfdrinks;
                    
                    Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " Lemonade Yes or No");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes"){
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks +  " Lemonade = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower()== "no"){
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 6){
                    Console.WriteLine("       You Selected Mug Rootbeer     ");
                    Console.WriteLine("          Mug Rootbeer = P49         ");
                    
                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());
                    
                    totalPrice = Mug_Rootbeer * amountOfdrinks;
                    
                    Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " Mug Rootbeer Yes or No");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes"){
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks +  " Mug Rootbeer = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower()== "no"){
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 7){
                    Console.WriteLine("          You Selected YaKult        ");
                    Console.WriteLine("             YaKult = P36            ");
                    
                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());
                    
                    totalPrice = Yakult * amountOfdrinks;
                    Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " Yakult Yes or No");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes"){
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks +  " YaKult = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower()== "no"){
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 8){
                    Console.WriteLine("       You Selected Mountain Dew     ");
                    Console.WriteLine("          Mountain Dew = P43         ");
                    
                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());
                    
                    totalPrice = Mountain_Dew * amountOfdrinks;
                    Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " Mountain Dew Yes or No");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes"){
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks +  " Mountain Dew = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower()== "no"){
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    
                }
                else if (userInput == 0){
                    Console.WriteLine("EXITING THE PROGRAM");
                    
                    break; // Pang stop nung program
                }
                else
                {
                    Console.WriteLine("");
                }
            }while(loop == 0);
            
        }
    }
}





