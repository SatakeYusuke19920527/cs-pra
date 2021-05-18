using System;
using System.Collections.Generic;
using System.Text;

namespace cs_pra_01
{
    class Person
    {
        public string name;
        public int age;
        public static string hello = "hello";

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        ~Person()
        {
            Console.WriteLine("Hello world");
        }

        public int MyProperty { get; set; }

        public void ShowNameAndAge()
        {
            Console.WriteLine("name:" + this.name + " age: " + this.age);
        }

    }
}
