namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        //veri kümlerini dolaşmak için kullandığımız yapılara döngü denir.

        //ForLoop(); //extract method ile for döngüsünü otomatik olarak metoda çevirdim
        //WhileLoop();
        //DoLoop();
        //ForEachLoop(); //dizi temelli dataların tolaşılması için kullanılır

        if (IsPrimeNumber(6))
        {
            Console.WriteLine("This is a prime number");
        }
        else
        {
            Console.WriteLine("This is not a prime number");
        }
        Console.ReadLine();
    }

    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        if (number < 2)
        {
            result = false;
        }
        else
        {
            for (int i = 02; i < number; i++)
            {

                if (number % i == 0)
                {
                    result = false;
                    number = i;
                }

            }
        }
        return result;
    }

    private static void ForEachLoop()
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number <= 11);
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}", number);
    }

    private static void ForLoop()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }
    }
}

