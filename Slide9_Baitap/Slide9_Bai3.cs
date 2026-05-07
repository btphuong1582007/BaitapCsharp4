
// Slide 9 - Bài 3
using System;

class Slide9_Bai3
{
    static void Main()
    {
        Console.Write("Nhập quãng đường (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập giờ: ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập phút: ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập giây: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        double timeHours = hours + minutes / 60.0 + seconds / 3600.0;

        double speedKmH = distance / timeHours;
        double speedMilesH = speedKmH / 1.609;

        Console.WriteLine($"Tốc độ: {speedKmH:F2} km/h");
        Console.WriteLine($"Tốc độ: {speedMilesH:F2} miles/h");
    }
}