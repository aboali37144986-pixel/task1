namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your favorite number (1-100)");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"no really!! {x} is my favorite too!");
        }
    }
}
