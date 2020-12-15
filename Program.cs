using System;
using EX2.classe;


namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(10, "Cheddar duplo", "lanche com tudo",10);

            Produto produto2 = new Produto(10);

            Produto produto3 = new Produto(5);

            produto3.Nome = "Coca-Cola";

            Produto produto = new Produto(8);
            
        }
    }
}
