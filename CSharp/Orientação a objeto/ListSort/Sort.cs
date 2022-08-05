namespace ConsoleApp1
{
    public class Sort
    {
       static void Main(string[] args)
       {
            var nomes = new List<string>()
            {
                "Adriano",
                "Felipe francisco",
                "Saci-perere",
                "Ana"
            };

            nomes.Sort();

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
                //return nomes em ordem alfabética
            }
       }
    }
}