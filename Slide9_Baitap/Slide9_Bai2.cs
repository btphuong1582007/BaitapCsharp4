
// Slide 9 - Bài 2
using System;

class Slide9_Bai2
{
    static void Main()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }
    }
}