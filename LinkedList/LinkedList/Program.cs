using System;

namespace LinkedList
{
     class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list1 = new LinkedList<string>();
            list1.AddFirst("Hello");
            list1.AddFirst("How");
            list1.AddFirst("Are");
            list1.AddFirst("You");
            foreach(string element in list1)
            {
                Console.WriteLine(element);
            }

             
        
        {
            Console.WriteLine("Hello World!");
        }
    }
}
