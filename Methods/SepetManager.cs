using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //Naming Convention
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi: " + product.Name);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Sepet Guncellendi: " + product.Price);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Sepetteki Urunler Silindi: " + product.Descpription);
        }
    }
}