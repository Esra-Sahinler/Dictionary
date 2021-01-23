using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dictonary = new MyDictionary<string, int>();

            dictonary.Add("Esra", 1);
            dictonary.Add("Ceren", 2);
            dictonary.Add("Mehtap", 3);
            Console.WriteLine(dictonary.Count);
            Console.ReadKey();
        }
    }
}
