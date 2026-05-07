
// Slide 9 - Bài 5
using System;

class Slide9_Bai5
{
    static void Main()
    {
        Console.Write("Nhập một ký tự: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if ("aeiouAEIOU".IndexOf(ch) >= 0)
        {
            Console.WriteLine("Đây là nguyên âm.");
        }
        else if (char.IsDigit(ch))
        {
            Console.WriteLine("Đây là chữ số.");
        }
        else
        {
            Console.WriteLine("Đây là ký tự khác.");
        }
    }
}