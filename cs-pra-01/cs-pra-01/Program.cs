using System;
namespace cs_pra_01
{
    class Program
    {
        public string name;
        public int age;

        static void Main(string[] args)
        {
            Program test = new Program();
            test.setAge(1999);
            test.setName("aaaa");
            firstFunc();
            Console.WriteLine(test.getName() + "Hello World!" + test.getAge());
            Class1.classFunc();
        }

        public static int firstFunc()
        {   
            Console.WriteLine("firstFunc");
            return 0;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
