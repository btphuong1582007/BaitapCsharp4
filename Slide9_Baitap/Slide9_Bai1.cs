
// Slide 9 - Bài 1
using System;

class Slide9_Bai1
{
    static void Main()
    {
        Console.Write("Nhập số thứ nhất: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập phép toán (+, -, *, x, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;
        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*':
            case 'x': result = num1 * num2; break;
            case '/': result = num1 / num2; break;
            default: Console.WriteLine("Phép toán không hợp lệ!"); return;
        }

        Console.WriteLine($"Kết quả: {result}");
    }
}