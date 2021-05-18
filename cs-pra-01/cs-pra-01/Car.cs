using System;
using System.Collections.Generic;
using System.Text;

namespace cs_pra_01
{
    class Car
    {
        protected string name;
        protected int speed;

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public int MyProperty { get; set; }

        public void ShowNameAndSpeed()
        {
            Console.WriteLine("name: " + this.name + " speed : " + this.speed);
        }
    }
}
