using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int Z = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(Z) ? "Prime" : "Not prime");
        }
        Console.ReadKey();

    }
    private static Boolean Calculate(int z)
    {
        if (z < 2) return false;
        if (z == 2) return true;
        if (z % 2 == 0) return false;
        int curr = (int)Math.Floor(Math.Sqrt(z));
        for (int i = 3; i <= curr; i += 2)
        {
            if (z % i == 0) { return false; }
        }
        return true;
    }
}