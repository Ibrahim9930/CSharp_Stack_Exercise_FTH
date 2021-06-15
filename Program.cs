using System;
using Collections;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> container = new Stack<string>();

            container.Push("element a");
            container.Push("element b");
            container.Push("element c");
            container.Push("element d");

            Console.Write("Elements order in reverse: -\n");
            container.Print();

            Console.Write($"Current Stack size is {container.Size}\n");
            Console.Write($"Poping the last added element {container.Peak()}\n");
            container.Pop();
            Console.Write("Current stack elements are: -\n");
            container.Print();
            container.Pop();
            container.Pop();
            container.Push("element x");
            Console.Write("Stack elements after poping twice and push an element: -\n");
            container.Print();
            container.Clear();
            Console.Write($"Stack size after a clear operation : {container.Size}\n");


        }
    }
}
