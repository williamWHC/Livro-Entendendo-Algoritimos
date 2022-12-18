using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Definir recebimento de lista de dados
            List<int> myList = new List<int> { 1, 3, 5, 7, 9 };

            Console.WriteLine(BinarySearch(myList, 3));     // => 3 
            Console.WriteLine(BinarySearch(myList, -1));    // => ? 

        }

        public static int? BinarySearch(List<int> list, int item)
        {
            //TODO - LOG DE ENTRADA DE METODO.
            try
            {
                //Numero baixo
                int low = 0;

                //Numero Alto / quantidade de elementos da minha lista
                int high = list.Count() - 1;

                //Numero do chute'
                int guess;

                //Valida se o numero e baixo
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    guess = list[mid];

                    //Valida se aceitou o chute
                    if (guess == item) return list[mid];

                    //Valida se o meu chute é alto ou baixo
                    if (guess >= item)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                //TODO - Capturar excessão.
                //TODO - Capturar Log de error.
                throw;
            }
        }
    }
}