class Slide22_Bai8
{
    static void Main()
    {
        Console.Write("Nhập giới hạn trên: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Các số nguyên tố:");
        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
                if (i % j == 0) { isPrime = false; break; }

            if (isPrime) Console.Write(i + " ");
        }
    }
}
