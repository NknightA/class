class Program
{
    public static void Main()
    {
        int i = 10000;
        int c = 0;
        while (true)
        {
            i /= 2;
            c++;
            if(i <= 100) break;
        }
        Console.WriteLine(c);
    }
}
