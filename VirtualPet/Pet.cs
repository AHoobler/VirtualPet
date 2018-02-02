using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Pet
    {
        //3 fields
        private int isHungry;
        private int isBored;
        private int isThirsty;



        //3 properties

        public int IsHungry

        {
            get { return this.isHungry; } //SEMI COLON INSIDE!!!!!
            set { this.isHungry = value; }
        }

        public int IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

         public int IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }


        //1 constructor
        public Pet()
        {
            //DEFAULT
        }

        public Pet(int isBored, int isHungry, int isThirsty)
        {
            this.isBored = isBored;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
        }


        //3 methods
        public void FeedPet()
        {
            Console.WriteLine("You fed PET. Hunger level is now: " + (isHungry--));
        }

        public void BoredPet()
        {
            Console.WriteLine("You played with PET. Boredom level is now: " + (isBored--));
        }

        public void ThirstyPet()
        {
            Console.WriteLine("You gave PET water. Thirst level  is now: " + (isThirsty--));
        }
        //tick method

        //public void Tick()
        //{

        //}
    }
}

