namespace GIK299_Ahmad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ange namn på familjemedlem 1:");
            string name1 = Console.ReadLine();
            Console.WriteLine("ange ålder på familjemedlem 1:");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ange namn på familjemedlem 2:");
            string name2 = Console.ReadLine();
            Console.WriteLine("ange ålder på familjemedlem 2:");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ange namn på familjemedlem 3:");
            string name3 = Console.ReadLine();
            Console.WriteLine("ange ålder på familjemedlem 3:");
            int age3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ange namn på familjemedlem 4:");
            string name4 = Console.ReadLine();
            Console.WriteLine("ange ålder på familjemedlem 4:");
            int age4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name1 + " är " + age1 + " år gammal. ");
            Console.WriteLine(name2 + " är " + age2 + " år gammal. ");
            Console.WriteLine(name3 + " är " + age3 + " år gammal. ");
            Console.WriteLine(name4 + " är " + age4 + " år gammal. ");

            double totalAge = age1 + age2 + age3 + age4;
            double averageAge = totalAge / 4;
            Console.WriteLine("totalålder " + "är: " + totalAge);
            Console.WriteLine("medelålder " + "är: " + averageAge.ToString("0.00"));  










        }
    }
}
