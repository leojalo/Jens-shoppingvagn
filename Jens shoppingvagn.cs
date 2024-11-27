
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> matlista = new List<string>();
        string input;

        Console.WriteLine("Skriv vad du lägga till i matlistan (skriv 'slut' för att avsluta):");

        while (true)
        {
            input = Console.ReadLine();

            if (input.ToLower() == "slut")
            {
                break;
            }

            matlista.Add(input);
        }

        Console.WriteLine("\nDin matlista:");
        for (int i = 0; i < matlista.Count; i++)
        {
            Console.WriteLine(matlista[i]);
        }

        Console.ReadLine();
    }
}
