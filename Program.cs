namespace ConsoleAppGitEdukov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            Console.WriteLine("Введите A");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выполнить +,-,*,:");
            char c = Convert.ToChar(Console.ReadLine());
            if(c == '+')
            {
                d = z + x;
                Console.WriteLine(d);

            }
            else if(c == '-')
            {
                d = z - x;
                Console.WriteLine(d);
            }
            else if(c == '*')
            {
                d = z * x;
                Console.WriteLine(d);
            }
            else if(c == ':')
            {
                d = z / x;
                Console.WriteLine(d);
            }
            
           
           


        }
    }
}