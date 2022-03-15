using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Karpuz";
            product1.Price = 15;
            product1.Descpription = "Diyarbakir Karpuzu";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Elma";
            product2.Price = 10;
            product2.Descpription = "Amasya Elmasi";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + " Fiyati : " + product.Price);
            }

            Console.WriteLine("--------------- Methods ----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Update(product2);
            sepetManager.Delete(product1);
        }
    }
}


// Dont Repeat Yourself - DRY - Clean Code - Best Practice