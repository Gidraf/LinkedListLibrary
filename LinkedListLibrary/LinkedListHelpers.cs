using System;

using System.Collections.Generic;

namespace LinkedListLibrary
{

    public static class LinkedListHelpers
    {
        public static LinkedList<char> deletedDuplicateChar(LinkedList<char> list)
        {
            LinkedList<char> newList = new LinkedList<char>();
            LinkedList<char> previousValues = new LinkedList<char>();
            LinkedList<char> nexValues = new LinkedList<char>();
            char current;
            foreach (char node in list)
            {
                if (newList.Count == 0)
                {
                    newList.AddLast(node);
                    previousValues.AddFirst(node);
                    current = node;
                }
                else if (previousValues.Find(node) == null){
                    newList.AddLast(node);
                    previousValues.AddFirst(node);
                  
                }
                else if (nexValues.Find(node) == null)
                {
                    newList.AddLast(node);
                    nexValues.AddFirst(node);
                }
                current = node;
            }
            return newList;
        }
    }
}
