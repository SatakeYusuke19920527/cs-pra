using System;
using System.Collections.Generic;
using System.Text;

namespace cs_pra_01
{
    class SuperCar : Car
    {
        public int maxSpeed;
        public SuperCar(string name, int speed, int maxSpeed): base(name, speed)
        {
            this.maxSpeed = maxSpeed;
        }

        public void ShowProp()
        {
            Console.WriteLine("name: " + this.name + " speed : " + speed + " maxSpeed : " + maxSpeed);
        }
    }
}
