namespace ex
{
    class Program
    {

        class msg
        {
            //indexof seleciona o numero da letra na string que você determinou entre parenteses e o remove exclui o restante da string determinando a pos, o trim elimina um caractere após o termino do indexof
            public void Hello()
            {
                string hello = "[Hello]HHoão";
                int pos = hello.IndexOf("]")+2;
                hello = hello.Remove(pos).Trim('H');
                Console.WriteLine(hello);
            }

            //retorno: 
        }

        static void Main(string[]args)
        {
            msg msg = new msg();
            msg.Hello();
        }
    } 
}
