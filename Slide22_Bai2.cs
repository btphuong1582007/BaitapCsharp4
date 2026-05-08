class Slide22_Bai2
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Nhập số thứ {i}: ");
            int x = int.Parse(Console.ReadLine());
            sum += x;
        }

        double avg = sum / 10.0;
        Console.WriteLine($"Tổng = {sum}");
        Console.WriteLine($"Trung bình = {avg}");
    }
}
