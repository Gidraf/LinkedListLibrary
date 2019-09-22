using System;
using LinkedListLibrary;
using System.Collections.Generic;
namespace RunLinkedListLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> myList = new LinkedList<char>();

            myList.AddFirst('a');
            myList.AddFirst('a');
            myList.AddFirst('a');
            myList.AddFirst('a');
            myList.AddFirst('a');
            myList.AddFirst('a');
            myList.AddFirst('a');
            myList.AddFirst('a');
            foreach (char var in LinkedListLibrary.LinkedListHelpers.deletedDuplicateChar(myList)) { 
                Console.WriteLine(var); }
        }
    }
}
