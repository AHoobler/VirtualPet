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
            //ownerPet.IsBored = 10;
            //ownerPet.IsHungry = 10;
            //ownerPet.IsThirsty = 10;

            do
            {

                Console.WriteLine("PET the PET");
                Console.WriteLine("PET's Hunger level is: " + ownerPet.IsHungry);
                Console.WriteLine("PET's Thirst level is: " + ownerPet.IsThirsty);
                Console.WriteLine("PET's Boredom level is: " + ownerPet.IsBored);
                //Must show stats for pet

                Console.WriteLine("What do?");
                Console.WriteLine("Press 1 to feed PET");
                Console.WriteLine("Press 2 to give PET water");
                Console.WriteLine("Press 3 to play with PET");
                Console.WriteLine("Press 5 to abandon PET");

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
            } while (ownerChoice != 5);
            Console.WriteLine("PET is sad");
        }
    }
}
