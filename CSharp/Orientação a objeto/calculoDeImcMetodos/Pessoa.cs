using System;
class Pessoa
{
    public string nome;
    public double altura,peso;
    public double calculo()
    {
        return peso/(altura*altura);
    }
    public string situacao(double calculo)
    {
        string print;
        if (calculo<18.5)
        {
            print =$" {nome} abaixo do peso";
        }
        else if(calculo>25)
        {
            print = " com o peso normal";
        }
        else
        {
            print =" Obeso morbido";    
        }
        return print;
    }
    public void mensagem()
    {
        double obterCalculo=calculo();
        string obterSituacao=situacao(obterCalculo);
        Console.WriteLine($"Seu IMC é {obterCalculo} você está {obterSituacao}");
    }
}
