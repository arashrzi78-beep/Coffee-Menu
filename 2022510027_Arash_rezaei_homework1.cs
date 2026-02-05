using System;

namespace HomeWorkI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = 100;
            int coffeeBox = 0;
            int kruvasanPackage = 0;
            int readyCoffeeShots = 0;
            int kruvasan = 0;
            int freshCoffee = 0;
            int orderCounter = 0;
            int day = 1;
            bool myMenu = true;
            do 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("WELCOME TO COFFEE SHOP! \n");
                Console.ResetColor();
                Console.WriteLine("Your current capital is " + budget + "Z\n");
                Console.WriteLine("The number of working days is " + day + "\n");

                Console.WriteLine("Please select the option you want to apply:\n");
                Console.WriteLine("1. Buy coffee package");
                Console.WriteLine("2. Brew coffee");
                Console.WriteLine("3. Sell cup(s) of coffee");
                Console.WriteLine("4. Buy kruvasan packages");
                Console.WriteLine("5. Open 1 kruvasan package");
                Console.WriteLine("6. Sell kruvasan(k)");
                Console.WriteLine("7. End of the Day >");
                Console.WriteLine("8. Quit Game\n");

                bool autoEnd = false;
                int user;
                Console.Write("CHOOSE ONE OF THEM : ");
                while (!int.TryParse(Console.ReadLine(), out user) || user < 1 || user > 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WARNING");
                    Console.ResetColor();
                    Console.Write("Choose a number between (1 - 8)");
                }

                if (orderCounter >= 6 && user != 8)
                {
                    autoEnd = true;
                    user = 7;
                }

                switch (user)
                {
                    case 1:
                        Console.WriteLine("Choice: " + user + "\n");
                        int chooseCoffee;
                        Console.Write("Operation is processed ! Enter number of coffee packages to buy: ");
                        while (!int.TryParse(Console.ReadLine(), out chooseCoffee) || chooseCoffee < 0 || chooseCoffee * 5 > budget)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("WARNING");
                            Console.ResetColor();
                            Console.Write("Re-enter number of coffee packages: ");
                        }
                        budget -= chooseCoffee * 5;
                        coffeeBox += chooseCoffee;
                        readyCoffeeShots += chooseCoffee * 3;
                        Console.WriteLine("Operation is processed! Now, you have " + readyCoffeeShots + " shots of coffee to brew.\n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("<---------------------------------------------------------------------->");
                        Console.ResetColor();
                        
                        break;
                    case 2:
                        Console.WriteLine("Choice: " + user);
                        if (readyCoffeeShots == 0)
                        {
                            if (coffeeBox <= 0)
                            {
                                Console.WriteLine("No coffee packages left. Buy packages first.");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("<---------------------------------------------------------------------->");
                                Console.ResetColor();
                                break;
                            }
                            coffeeBox--;
                            readyCoffeeShots += 3;
                        }


                        readyCoffeeShots--;
                        freshCoffee += 5;
                        Console.WriteLine("Operation is processed ! Now, there are " + freshCoffee + " fresh cups of coffee " );
                        Console.WriteLine("The remaining number of shots of coffee to brew is  " + readyCoffeeShots);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("<---------------------------------------------------------------------->");
                        Console.ResetColor(); 
                        break;
                    case 3:
                        orderCounter++;
                        Console.WriteLine("Choice: " + user);
                        Console.WriteLine("Operation is processed ! The current number of order is  " + orderCounter);
                        if (freshCoffee == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("SORRY :(");
                            Console.ResetColor();
                            Console.WriteLine("There is no fresh coffee to sell.");
                            break;
                        }
                        int cupsForSale;
                        Console.Write("Please Enter the number of cups to sell: ");
                        while (!int.TryParse(Console.ReadLine(), out cupsForSale) || cupsForSale < 0 || cupsForSale > freshCoffee)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Warning.");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("There are only 5 fresh cups of coffee to sell");
                            Console.ResetColor();
                            Console.Write("Re-enter number of cups to sell: ");
                        }
                        freshCoffee -= cupsForSale;
                        budget += cupsForSale * 2;
                        Console.WriteLine("Operation is processed ! the remaining fresh sups of coffee to brew is " + freshCoffee);
                        Console.WriteLine("the remaining number of shots of coffee to brew is " + readyCoffeeShots);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("<---------------------------------------------------------------------->");
                        Console.ResetColor();
                        orderCounter++;
                        break;
                    case 4:
                        Console.WriteLine("Choice: " + user);
                        int pickKruvasanPack;
                        Console.Write("Operartion is processed ! please Enter the number of packages to buy: ");
                        while (!int.TryParse(Console.ReadLine(), out pickKruvasanPack) || pickKruvasanPack < 0 || pickKruvasanPack * 10 > budget)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("WARNING");
                            Console.ResetColor();

                            Console.WriteLine("Invalid amount or insufficient balance.");
                           
                            Console.Write("Re-enter number of kruvasan packages: ");
                        }
                        kruvasanPackage += pickKruvasanPack;
                        budget -= pickKruvasanPack * 10;
                       
                        Console.WriteLine("Operartion is processed ! there are currently  " + kruvasanPackage +" packages of kruvasan to sell");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("<---------------------------------------------------------------------->");
                        Console.ResetColor(); break;
                    case 5:
                        Console.WriteLine("Choice: " + user);
                        if (kruvasanPackage > 0)
                        {
                            kruvasanPackage = kruvasanPackage - 1;
                            kruvasan += 5;
                            Console.WriteLine("Operartion is processed ! there are " + kruvasan + " kruvasan on the tray" );
                            Console.WriteLine("the remaining number of packages of kurusan to sell is " + kruvasanPackage);
                            
                        }
                        else
                        {
                            Console.WriteLine("There is no kruvasan package.");
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("<---------------------------------------------------------------------->");
                        Console.ResetColor(); break;
                    case 6:
                        orderCounter++;
                        Console.WriteLine("Choice: " + user);
                        Console.WriteLine("Operation is processed ! the current number of orders is " + orderCounter);
                        int sellCro;
                        Console.Write("Enter number of kruvasan to sell: ");
                        while (!int.TryParse(Console.ReadLine(), out sellCro) || sellCro < 0 || sellCro > kruvasan)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Habibi number is not true ! ");
                            Console.ResetColor();
                            Console.Write("Re-enter number of kruvasan to sell: ");
                        }
                        kruvasan -= sellCro;
                        budget += sellCro * 3;
                        Console.WriteLine("operation is processed ! there are currently  " + kruvasan + " kruvasan on the tray");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("<---------------------------------------------------------------------->");
                        Console.ResetColor(); orderCounter++;
                        break;
                    case 7:
                        Console.WriteLine("Choice: " + user);
                        if (!autoEnd && orderCounter < 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("WARRNING!!!");
                            Console.ResetColor();
                            Console.WriteLine(" The 'End of the Day >  ' will not be functional before 3 (worked) orders in a day .\n");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("<---------------------------------------------------------------------->");
                            Console.ResetColor();
                            break;
                        }
                        Console.WriteLine("<---------------------------------------------------------------------->");
                        Console.WriteLine("IT IS THE END OF THE DAY !!!");
                        Console.WriteLine("The current budget is " + budget + " Z");
                        Console.WriteLine("The remaining number of full packages of coffee is  " + coffeeBox);
                        Console.WriteLine("The remaining number of shots of coffee is " + readyCoffeeShots);
                        Console.WriteLine("The remaining number of packages of kruvasan is " + kruvasanPackage);
                        Console.WriteLine("The remaining number of kruvasan on the tray is " + kruvasan);
                        Console.WriteLine("<---------------------------------------------------------------------->");
                        freshCoffee = 0;
                        if (day % 2 == 0)
                        {
                            kruvasan = 0;
                            Console.WriteLine("krusan yok");
                        }
                        day++;
                        orderCounter = 0;
                        break;
                    case 8:
                        myMenu = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("THANK YOU FOR CHOOSING US . WE LOOK FORWARD TO SEEING YOU AGAIN!!!");
                        Console.ResetColor();
                        break;
                }
               

            }while(myMenu);
            Console.ReadLine();
        }
    }
}