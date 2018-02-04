using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            int ownerChoice;
            Pet ownerPet = new Pet();
            ownerPet.IsBored = 10;
            ownerPet.IsHungry = 10;
            ownerPet.IsThirsty = 10;
            ownerPet.IsAngry = 50; 

            do
            {

                Console.WriteLine("Jasper the grumpy dog");
                Console.WriteLine("Jasper's Hunger level is: " + ownerPet.IsHungry);
                Console.WriteLine("Jasper's Thirst level is: " + ownerPet.IsThirsty);
                Console.WriteLine("Jasper's Boredom level is: " + ownerPet.IsBored);
                Console.WriteLine("Jasper's Anger level is: " + ownerPet.IsAngry);
                Console.WriteLine();
                
                //Must show stats for pet

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Press 1 to feed Jasper");
                Console.WriteLine("Press 2 to give Jasper water");
                Console.WriteLine("Press 3 to play with Jasper");
                Console.WriteLine("Press 5 to abandon Japer");
                ownerChoice = int.Parse(Console.ReadLine());

                switch (ownerChoice)
                {
                    case 1:
                        ownerPet.FeedPet();
                        break;
                    case 2:
                        ownerPet.ThirstyPet();
                        break;
                    case 3:
                        ownerPet.BoredPet();
                        break;
                }
                Console.WriteLine();
                ownerPet.Tick();
                
            } while (ownerChoice != 5);
            Console.WriteLine("Jasper is sad");
        }
    }
}
