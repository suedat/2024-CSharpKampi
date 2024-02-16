namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Value Types

            double number5 = 10.4; //64bit.
            decimal number6 = 10.4m; //decimal daha hassas değerler için virgülden sonra daha fazla değer tutabiliyor 
            char charachter = 'A';
            bool condition = true;
            byte number4 = 0; // sınırı [0,255] 8bit
            short number3 = -32768; // sınırı [32767,-32768] 16bit
            int number1 = 10; //sınırı [2147483847, -2147483548)] 32bit
            long number2 = 2147483647; //long daha çok yer kaplar 64bit. sınırı [9223372036854775807, -9223372036854775808]
            var number7 = 10; //var hangi değer tipini adadıysa değişken öyle algılanır
                              //number7 = 'A';

            //{}virgülden sonraki ilk değeri yazdırır
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Charachter is {0}", (int)charachter); //charlar kolaylıkla integera çevrilebilir. Ascii değerini verir
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday); //Enum sabitleri 0dan başlar

            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}