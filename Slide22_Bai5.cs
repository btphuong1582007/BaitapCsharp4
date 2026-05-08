class Slide22_Bai5
{
    static void Main()
    {
        Console.Write("Nhập số n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        Console.Write("Dãy harmonic: ");
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
            Console.Write("1/{0} ", i);
        }
        Console.WriteLine("\nTổng = " + sum);
    }
}
