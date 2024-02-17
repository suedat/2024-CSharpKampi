namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        string[] students = new string[3];
        students[0] = "Engin";
        students[1] = "Derin";
        students[2] = "Salih";

        string[] students2 = { "Engin", "Derin", "Salih"};

        foreach (var student in students2)
        {
            Console.WriteLine(student);
        }

        //Çok Boyutlu Diziler
        string[,] regions = new string[5, 3]
        {
            {"İstanbul", "İzmit", "Balıkesir"},
            {"Ankara", "Konya","Kırıkkale"},
            {"Antalya", "Adana","Mersin"},
            {"Rize", "Trabzon","Samsun"},
            {"İzmir", "Muğla","Manisa"},
        }; // buraya da ; konulur

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("*************");
        }
        Console.ReadLine();
    } 
}

