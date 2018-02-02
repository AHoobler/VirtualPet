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
        private int isAngry;



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

        public int IsAngry
        {
            get { return this.isAngry; }
            set { this.isAngry = value; }
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
            isHungry--;
            isThirsty++;
            Console.WriteLine("You fed PET.");
        }

        public void BoredPet()
        {
            isBored--;
            Console.WriteLine("You played with PET.");
        }

        public void ThirstyPet()
        {
            isThirsty--;
            isHungry++;
            Console.WriteLine("You gave PET water.");
        }
        //tick method

        public void Tick()
        {
            isAngry = (isAngry +10);
            Console.WriteLine("Pet is Angry");
           
         
        }
    }
}

