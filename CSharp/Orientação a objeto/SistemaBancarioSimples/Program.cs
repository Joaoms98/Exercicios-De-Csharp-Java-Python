using Conta;


ContaCorrente conta1 = new ContaCorrente();
conta1.Saldo = 1000;

string Esc;

do
{
    Console.WriteLine($"Saldo Atual "+conta1.Saldo);
    Console.Write($"Informe a quantinha de saque:");

    conta1.Transacao(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine(conta1.Status);
    Console.WriteLine($"Saldo Atual " + conta1.Saldo);

    Console.WriteLine("############# Aperte qualquer tecla para sair ou digite 1 para realizar uma nova transação ##############");
    Esc = Console.ReadLine();
} while (Esc == "1");


