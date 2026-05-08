class Slide22_Bai1
{
    static void Main()
    {
        Console.Write("Nhập cạnh a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh c: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Tam giác đều");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Tam giác cân");
        else
            Console.WriteLine("Tam giác thường");
    }
}
