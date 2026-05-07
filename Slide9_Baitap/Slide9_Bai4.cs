
// Slide 9 - Bài 4
using System;

class Slide9_Bai4
{
    static void Main()
    {
        Console.Write("Nhập bán kính hình cầu: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

        Console.WriteLine($"Diện tích mặt cầu: {surface:F2}");
        Console.WriteLine($"Thể tích hình cầu: {volume:F2}");
    }
}