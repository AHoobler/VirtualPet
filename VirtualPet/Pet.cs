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
        private bool isHungry;
        private bool isBored;
        private bool isThirsty;



        //3 properties

        public bool IsHungry

        {
            get { return this.isHungry; } //SEMI COLON INSIDE!!!!!
            set { this.isHungry = value; }
        }

        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

         public bool IsThrirsty
        {
            get { return this.isThirsty; }
            set { this.isBored = value; }
        }


        //1 constructor
        public Pet()
        {
            //DEFAULT
        }

        public Pet(bool isBored, bool isHungry, bool isThirsty)
        {
            this.isBored = isBored;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
        }


        //3 methods
        public string FeedPet()
        {
            if (isHungry == true)
            {
                Console.WriteLine("Here is some food pet");
            }
            else
            {
                Console.WriteLine("No food for you pet");
            }
        }

        public string BoredPet()
        {
            if (isBored == true)
            {
                Console.WriteLine("Fetch The toy pet");
            }
            else
            {
                Console.WriteLine("Pet ignores you");
            }
        }

        public string ThirstyPet()
        {
            if (isThirsty == true)
            {
                Console.WriteLine("Here is some water pet");
            }
            else
            {
                Console.WriteLine("Pet ignores you");
            }
        }
        //tick method

        //public void Tick()
        //{

        //}
    }
}

