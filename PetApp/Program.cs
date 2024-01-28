using System;

namespace PetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type of pet: ");
            Console.WriteLine("1. Cat \n2. Dog\n3. Rabbit \n");
            Console.Write("User Input :");
            int petType = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(userInput);

            while (petType <= 0 || petType >= 4) {
                Console.WriteLine("You have chose invalid input!");
                Console.WriteLine("Please choose a type of pet: ");
                Console.WriteLine("1. Cat \n2. Dog\n3. Rabbit \n");
                Console.Write("User Input :");
                int petTypeNew = Convert.ToInt32(Console.ReadLine());
                petType = petTypeNew;
            }


            if(petType == 1) {
                Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
            }
            else if(petType == 2) {
                Console.WriteLine("You've chosen a Dog. What would you like to name your pet?");
            }
            else if(petType == 3) { 
                    Console.WriteLine("You've chosen a Rabbit. What would you like to name your pet?");
            }
            else if(petType == 4) {
                Console.WriteLine("You've chosen a Horse. What would you like to name your pet?");
            }

            Console.Write("User Input : ");
            string petName = Console.ReadLine();

            Console.WriteLine("\nWelcome, {0}! Lets take good care of him", petName);
            int exit = 1;
            while (exit != 0)
            {
                Console.WriteLine("Main Menu:\n 1.Feed Buddy\n 2.Play With Buddy\n 3.Let Buddy Rest\n 4.Check Buddy's Status\n 5.Exit");
                Console.WriteLine("User Input : ");
                int userMenu = Convert.ToInt32(Console.ReadLine());

                if (userMenu == 1) { 
                    Console.WriteLine("Feed...."); 
                }else if (userMenu == 2)
                {
                    Console.WriteLine("Play....");
                }else if(userMenu == 3)
                {
                    Console.WriteLine("Rest.....");
                }else if(userMenu == 4){
                    Console.WriteLine("Status is...");
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
