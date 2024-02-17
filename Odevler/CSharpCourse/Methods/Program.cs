namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20, 10);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2); // ref yerine out'da kullanabiliriz
            //out kullandığımızda number1 = 20; ataması yapmamıza da gerek kalmaz ama metodun için set edilmezse out hata verir
            
            Console.WriteLine(result2);
            Console.WriteLine(number1); //ref number1 yaptığımız için 30 oldu
            Console.WriteLine(Add4(1,2,3,4,5)); //params keywordü kullandığımız için istediğimiz kadar int yollayabiliriz
            Console.ReadLine();
        }
        //void: git bir şey yap demek için kullanıyoruz   
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        //dönmesini istediğimiz bir veri varsa direkt yazarız bu nedenle burada void yerine int yazıcağız
        static int Add2(int number1, int number2=30)//parametre
        {                            //default parametre. default değerler hep metoun en sonunda olması gerek

           //return number1 + number2;
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1,  int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //Farklı parametre ile aynı ad kullanılabilir buna method ıverloading denir
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
                        //buradaki int ilk değeri alacağı için girilen ilk int değeri sumda hesaplanmayacak
        static int Add4(int number,params int[] numbers) //params parametrelerde sonda yazılmak zorunda
        {
            return numbers.Sum();
        }
    }
}