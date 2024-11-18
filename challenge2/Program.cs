using System;
using System.Collections.Generic;

public class ElementFinder<T> where T : IEquatable<T>
{
    public void FindElementsInCollection(List<T> collectionToCheck, List<T> collectionToSearch)
    {
        Dictionary<T, bool> elementPresence = new Dictionary<T, bool>();

        foreach (T element in collectionToCheck)
        {
            elementPresence[element] = true;
        }

        foreach (T element in collectionToSearch)
        {
            bool found = elementPresence.ContainsKey(element);
            Console.WriteLine($"{element}:{found.ToString().ToLower()}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<int> collectionA = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        List<int> collectionS = new List<int> { 5, 15, 3, 19, 35, 50, -1, 0 };

        ElementFinder<int> finder = new ElementFinder<int>();
        finder.FindElementsInCollection(collectionA, collectionS);
    }
}
