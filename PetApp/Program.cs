using System;

namespace PetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int petType = 0;
            //*******************************************************
            while (petType <= 0 || petType >= 4)
            {
                Console.WriteLine("Please choose a type of pet: ");
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("1. Cat \n2. Dog\n3. Rabbit \n");
                Console.Write("User Input: ");

                // Attempt to convert user input to an integer
                if (!int.TryParse(Console.ReadLine(), out petType))
                {
                    Console.WriteLine("[ALERT] - Invalid input! Please enter a valid integer.");
                    // Optionally, you can handle this by taking appropriate action.
                    // For simplicity, in this example, the loop will continue, and the user will be prompted again.
                }
                else if (petType <= 0 || petType >= 4)
                {
                    Console.WriteLine("[ALERT] - You have chosen an invalid input!");
                }
            }

            //Showing the message to user which pet he/she selected
            if (petType == 1)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
            }
            else if (petType == 2)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("You've chosen a Dog. What would you like to name your pet?");
            }
            else if (petType == 3)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("You've chosen a Rabbit. What would you like to name your pet?");
            }
            else if (petType == 4)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("You've chosen a Horse. What would you like to name your pet?");
            }

            //Getting the name of the pet from user and store into variable
            Console.Write("User Input : ");
            string petName = Console.ReadLine();

            //Showing message to user "pet name"
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("Welcome, {0}! Lets take good care of him", petName);
            Console.WriteLine("--------------------------------------------");


            //assigning variables for the functionality for Main Menu and Pet's Status
            int exit = 1;
            int hunger = 5, happiness = 5, health = 5;

            //Loop runs untill user select exit
            while (exit != 0)
            {
                //Main Menu options
                Console.WriteLine("\nMain Menu:\n 1.Feed Buddy\n 2.Play With Buddy\n 3.Let Buddy Rest\n 4.Check Buddy's Status\n 5.Exit");
                Console.Write("\n>>> User Input : ");
                //storing user input into userMrnu Variable
                int userMenu = Convert.ToInt32(Console.ReadLine());

                //1 - for Feeding
                if (userMenu == 1)
                {
                    Console.WriteLine("You Fed {0}...., {0}'s hunger decreses, and health improves slightly\n", petName);
                    //if pet's hunger is between 2 to 10 then and then hunger decreases
                    if (hunger >= 2 && hunger <= 10)
                    {
                        //hunger = hunger - 2;
                        hunger -= 2;
                        //if pet's health is between 0 to 9
                        if (health >= 0 && health <= 9)
                        {
                            //health = health + 1;
                            health += 1;
                        }
                    }
                    //if pet's hunger is 0 __OVER FEEDING
                    if (hunger <= 0)
                    {
                        //health = health - 1;
                        health -= 1;
                    }
                }
                //For Playing with Pet
                else if (userMenu == 2)
                {
                    //if pet's hunger is greaten than 8 OR Health is less than 2
                    if (hunger >= 8 || health <= 1)
                    {
                        //can't play cause he is either too hungry or health is very low
                        Console.WriteLine("{0} Cannot play!", petName);
                        if (hunger >= 8)
                        {
                            Console.WriteLine("{0} is hungry Feed him first!", petName);

                        }
                        else if (health <= 1)
                        {
                            Console.WriteLine("{0}'s health is not so good", petName);
                        }
                    }
                    else
                    {
                        //if health and hunger is not an issue then play 
                        Console.WriteLine("\n--------------------------------------------");
                        Console.WriteLine("{0} played, his happiness increases, but he is hungry little bit", petName);
                        Console.WriteLine("--------------------------------------------");

                        if (hunger >= 1 && hunger <= 10)
                        {
                            hunger += 2;
                        }
                        if (happiness >= 1 && happiness <= 10)
                        {
                            happiness += 1;
                        }
                    }

                }
                //For Resting
                else if (userMenu == 3)
                {
                    Console.WriteLine("\n--------------------------------------------");
                    Console.WriteLine("{0} Rested.....", petName);
                    Console.WriteLine("--------------------------------------------");

                    //if hunger is between 1 to 10 
                    if (hunger >= 1 && hunger <= 10)
                    {
                        hunger -= 1;
                    }
                    //if health is greater than equal to 8
                    if (health >= 8)
                    {
                        //health reduce by 2
                        health -= 2;
                    }
                    //if happiness is  between 1 to 10
                    if (happiness <= 1 && happiness >= 10)
                    {
                        //happiness reducec by 1
                        happiness -= 1;
                    }

                }
                //For Checking pet's status
                else if (userMenu == 4)
                {
                    Console.WriteLine("\n--------------------------------------------");
                    Console.WriteLine("{0}'s Status\n1) Hunger: {1}\n2) Happiness: {2}\n3) Health: {3}", petName, hunger, happiness, health);
                    Console.WriteLine("--------------------------------------------\n");
                }
                else if (userMenu == 5)
                {
                    //this will end the loop
                    exit = 0;
                }
                else
                {
                    //controlling inavalid inputs
                    Console.WriteLine("\n[ALERT] - You have entered incorrect input, please select from following....");
                }
            }
            Console.WriteLine("Thank you for spending time with {0}", petName);

        }
    }
}
