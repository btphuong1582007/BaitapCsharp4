class Slide22_Bai3
{
    static void Main()
    {
        Console.Write("Nhập số n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");
    }
}
