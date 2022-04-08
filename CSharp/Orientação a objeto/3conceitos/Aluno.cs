using System;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    //média
    public double media()
    {
        return(nota1+nota2)/2;
    }

    //situação
    public string situacao(double media)
    {
        return media >=7 ? "aprovado" : "reprovado";
    }


    //Mensagem
    public void mensagem()
    {
        //obter a media
        double obterMedia=media();
        
        //obter a situação
        string obterSituacao=situacao(obterMedia);
        //Mensagem
        Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia}");

    }
}