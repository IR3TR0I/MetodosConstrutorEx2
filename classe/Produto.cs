using System;
namespace EX2.classe
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        
        public string Descricao { get; set; }


        public int Estoque { get; set; }
        
        
        public Produto(int codigo, string nome, string desc, int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = desc;
            Estoque = estoque;

            Console.WriteLine($"Produto cadastrado Código - {Codigo} - Nome {Nome}");
        }

        public Produto(int codigo){
            if(codigo>= 0){
                Codigo = codigo;
                Nome = "Pepsi";
                Console.WriteLine($"Produto cadastrado Código - {Codigo} - Nome {Nome}");
            }else{
                Console.WriteLine("Codigo Inválido");
            }
        }
        
    }
}