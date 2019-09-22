using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LinkedListLibrary;
namespace LinkedListLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLinkedListContainsTheCorrectLengthof2()
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
            Assert.AreEqual(2, LinkedListHelpers.deletedDuplicateChar(myList).Count);
		}

        [TestMethod]
        public void TestLinkedListContainsTheCorrectLengthof4()
        {
            LinkedList<char> myList = new LinkedList<char>();
            myList.AddFirst('a');
            myList.AddFirst('c');
            myList.AddFirst('a');
            myList.AddFirst('a');
            myList.AddFirst('c');
            myList.AddFirst('a');
            myList.AddFirst('a');
            myList.AddFirst('a');
            Assert.AreEqual(4, LinkedListHelpers.deletedDuplicateChar(myList).Count);
        }
    }
}
