using System;

namespace MyNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            int result = myClass.Add(2, 3);
            Console.WriteLine($"The result is {result}");
        }
    }

    public class MyClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
