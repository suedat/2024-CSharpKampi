namespace Conditionals
{
    class Program
    {
        static async void Main(string[] args)
        {
            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }

            //Single Line If
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }
            Console.ReadLine();
        }
    }
}
