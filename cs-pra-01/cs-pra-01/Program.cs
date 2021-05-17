using System;
namespace cs_pra_01
{
    class Program
    {
        public string name = "";
        public int age = 0;

        static void Main(string[] args)
        {
            Person yusuke = new Person("yusuke", 28);
            Console.WriteLine("name: " + yusuke.name);
            Console.WriteLine("age: " + yusuke.age);
        }
    }
}
