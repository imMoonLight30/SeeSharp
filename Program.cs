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
            list.Add("five");
            Console.WriteLine(list.ToString());
            list.Remove("three");
            Console.WriteLine(list.ToString());
            list.Name = "MyLinkedList";
            Console.WriteLine("Name and Count "+list.Name+" and "+list.Count);
            Console.WriteLine("First and Last in list "+list.First()+" ,and "+list.Last());

            //Indexer(treat collection class as array)
            list[3]="nine";
            Console.WriteLine("3rd element "+list[2].ToString());
            Console.WriteLine("list -\n"+list.ToString());
            //overloading of the function
            list.Remove(2);
            Console.WriteLine(list.ToString());

        }
    }
}