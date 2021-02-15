using System.Collections.Generic;

namespace Pluralsight.AdvCShColls.TourBooker.Logic
{
    public static class LinkedListExtension
	{
		public static LinkedListNode<T> GetNthNode<T>(this LinkedList<T> lst, int n)
		{
			LinkedListNode<T> currentNode = lst.First;
			for (int i = 0; i < n; i++)
				currentNode = currentNode.Next;
			return currentNode;
		}
	}
}
