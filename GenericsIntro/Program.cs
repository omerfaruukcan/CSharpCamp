using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Omer Faruk");
            Console.WriteLine(isimler.Length);

            isimler.Add("Busra");
            Console.WriteLine(isimler.Length);

            isimler.Add("Hatice");
            isimler.Add("Mahmut");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            
        }
    }
}
