
using System.Text.RegularExpressions;

namespace consoleapp1
{
    public class Class1
    {
        public static string Response(string statement)
        {
            statement = statement.Trim();
            if (statement == "")
            {
                return "Fine. Be that way!";
            }else if (Regex.IsMatch(statement,"[A-Z]") &&
                !Regex.IsMatch(statement,"[a-z]"))
            {
               return "Whoa, chill out!";
            }else if(statement.Substring (statement.Length - 1) == "?")
            {
                return "Sure .";
            }
            return "Whatever .";
        }
    }
}

//Bob é um adolescente indiferente. Na conversa, suas respostas são muito limitadas.
//Bob responde 'Claro'. se você fizer uma pergunta, como "Como você está?".
//Ele responde 'Uau, relaxe!' se você GRITAR COM ELE (em todas as maiúsculas).
//Ele responde 'Calma, eu sei o que estou fazendo!' se você gritar uma pergunta para ele.
//Ele diz 'Tudo bem. Seja desse jeito!' se você se dirigir a ele sem realmente dizer nada.
//Ele responde 'Tanto faz'. a qualquer outra coisa.
//O parceiro de conversação de Bob é um purista quando se trata de comunicação escrita e sempre segue as regras normais em relação à pontuação das frases em inglês.