class Slide22_Bai4
{
    static void Main()
    {
        Console.Write("Nhập số dòng: ");
        int n = int.Parse(Console.ReadLine());

        // Pattern 1
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }

        Console.WriteLine();

        // Pattern 2
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(num++ + " ");
            Console.WriteLine();
        }
    }
}
