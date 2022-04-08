using System;

namespace Orientação_a_objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar um objeto
            Pessoa obj = new Pessoa ();
            obj.nome = "Ralf";
            obj.idade = 30;
            obj.mensagem();
        }
    }
}
