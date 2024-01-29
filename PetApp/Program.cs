using System;

namespace PetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Please choose a type of pet: ");
            Console.WriteLine("1. Cat \n2. Dog\n3. Rabbit \n");
            Console.Write("User Input :");
            int petType = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(userInput);

            while (petType <= 0 || petType >= 4) {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("\nYou have chose invalid input!");
                Console.WriteLine("Please choose a type of pet: ");
                Console.WriteLine("1. Cat \n2. Dog\n3. Rabbit \n");
                Console.Write("User Input :");
                int petTypeNew = Convert.ToInt32(Console.ReadLine());
                petType = petTypeNew;
            }


            if(petType == 1) {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
            }
            else if(petType == 2) {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("You've chosen a Dog. What would you like to name your pet?");
            }
            else if(petType == 3) {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("You've chosen a Rabbit. What would you like to name your pet?");
            }
            else if(petType == 4) {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("You've chosen a Horse. What would you like to name your pet?");
            }

            Console.Write("User Input : ");
            string petName = Console.ReadLine();
            
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("Welcome, {0}! Lets take good care of him", petName); 
            Console.WriteLine("--------------------------------------------");


            int exit = 1;
             int hunger = 0, happiness = 10, health = 10;
            while (exit != 0)
            {

                Console.WriteLine("\nMain Menu:\n 1.Feed Buddy\n 2.Play With Buddy\n 3.Let Buddy Rest\n 4.Check Buddy's Status\n 5.Exit");
                Console.Write("\n>>> User Input : ");
                int userMenu = Convert.ToInt32(Console.ReadLine());

                if (userMenu == 1) { 
                    Console.WriteLine("He is Feeding....");
                    if (hunger >= 2 && hunger <= 10)
                    {
                        hunger -= 2;
                    }
                    if(hunger < 0)
                    {
                        health -= 1;
                    }
                }
                else if (userMenu == 2)
                {
                    if(hunger >= 8 || health <=8)
                    {
                        Console.WriteLine("Cannot play!");
                        if(hunger >=8) {
                        Console.WriteLine("He is hungry Feed him first!");

                        }else if (health <=8)
                        {
                            Console.WriteLine("His health is not so good");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n--------------------------------------------");
                        Console.WriteLine("Play....");
                        Console.WriteLine("--------------------------------------------");

                        if (hunger>=1 && hunger<=10) { 
                    hunger += 2;
                    }
                    if (health >= 1 && health <= 10)
                    {
                        hunger += 1;
                    }
                    }
                    
                    //hunger = hunger - 1;
                }
                else if(userMenu == 3)
                {
                    Console.WriteLine("\n--------------------------------------------");
                    Console.WriteLine("Rest.....");
                    Console.WriteLine("--------------------------------------------");

                    if (hunger >= 1 && hunger <= 10)
                    {
                        hunger -= 1;
                    }
                    if (hunger >= 1 && hunger <= 10)
                    {
                        hunger += 2;
                    }

                }
                else if(userMenu == 4){
                    Console.WriteLine("\n--------------------------------------------");
                    Console.WriteLine("Pet's Status\n1) Hunger: {0}\n2) Happiness: {1}\n3) Health: {2}", hunger, happiness, health);
                    Console.WriteLine("--------------------------------------------\n");
                }
                else
                {
                    exit = 0;
                }
            }
            Console.WriteLine("Thanks....");
            
            /* switch (userInput)
             {
                 case 1: 
                     Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
                     break;
                 case 2:
                     Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
                     break;
                 case 3:
                     Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
                     break;
                 default:
                     Console.WriteLine();
                     break;
             }*/
        }
    }
}
