using System;
using System.Collections.Generic;
using System.Text;

namespace cs_pra_01
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int MyProperty { get; set; }

    }
}
