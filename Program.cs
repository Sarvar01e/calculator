namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number a");

            int a =int.Parse(Console.ReadLine());

            Console.WriteLine("enter number b");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Chose operation \n1\t + \n2 \t - \n3 \t * \n4 \t/");

            string operatition = Console.ReadLine();

            switch (operatition)
            {
                case "1":
                    Console.WriteLine(a + b);
                    break;
                case "2":
                    Console.WriteLine(a - b);
                    break;
                case "3":
                    Console.WriteLine(a * b);
                    break;
                case "4":
                    Console.WriteLine(a / b);
                    break;

                default:
                    Console.WriteLine("you entered incorrect data");
                    break;
            }




        }
    }
}