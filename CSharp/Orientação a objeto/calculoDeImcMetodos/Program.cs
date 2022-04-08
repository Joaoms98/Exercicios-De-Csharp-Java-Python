using System;

namespace calculoDeImcMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a=new Pessoa();
            Console.WriteLine("Informe sua altura: ");
            a.altura=double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua peso: ");
            a.peso=double.Parse(Console.ReadLine());;
            a.nome="Joao";
            a.mensagem();
        }
    }  
}
