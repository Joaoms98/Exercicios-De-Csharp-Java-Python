using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExtensoes.Extensoes
{
    public static class ListExtensoes
    {
        public static void Addmany<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)  //percorrer a lista
            {
                lista.Add(item);
            }
        }   

        static void Teste()     
        {
            List<int> idades = new List<int>();
            idades.Add(1); 
            idades.Add(2);
            idades.Add(3);
            idades.Add(4);

            idades.Addmany(1, 2, 3, 4, 5, 6, 7, 8, 98, 64); //método para adicionar vários
        }
    }
}
    