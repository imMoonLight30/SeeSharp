using System;

namespace SeeSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List with input 1,2,3,4,5");
            LinkedList list = new();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            Console.WriteLine(list.ToString());
            list.Remove("three");
            Console.WriteLine(list.ToString());
        }
    }
}