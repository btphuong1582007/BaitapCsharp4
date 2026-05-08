class Slide22_Bai6
{
    static void Main()
    {
        Console.Write("Nhập giới hạn trên: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Các số hoàn hảo:");
        for (int i = 2; i <= n; i++)
        {
            int sum = 0;
            for (int j = 1; j < i; j++)
                if (i % j == 0) sum += j;

            if (sum == i)
                Console.WriteLine(i);
        }
    }
}
