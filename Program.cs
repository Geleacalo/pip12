namespace ConsoleAppGitEdukov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d =0;
            Console.WriteLine("Введите A");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выполнить +,-,*,:");
            char c = Convert.ToChar(Console.ReadLine());
            if(c == '+')
            {
                Console.WriteLine(C1(z,x));

            }
            else if(c == '-')
            {
                Console.WriteLine(C2(z, x));
            }



        }
        private static double C1(double z, double x)
        {
            double d = z + x;
            return d;
        }

        private static double C2(double z, double x)
        {
            double d = z - x;
            return d;
        }

    }
}