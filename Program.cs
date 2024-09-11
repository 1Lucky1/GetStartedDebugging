using System;

namespace GetStartedDebugging;

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'g', 'a', 'p', 'u', ' ', 'z', 'm', 'k' };
        string name = "";
        int[] a = new int[10];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Hello, " + name + "! Count to " + msg);
        }
    }
}
