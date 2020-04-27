using System;
using System.Collections.Generic;

namespace Answers
{
    public static class OneA
    {
        /// <summary>
        /// recebe um array de inteiros e retorna um array que contém os valores superior a 50, impares e divisiveis por 9
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] NumsWithArray(int[] array)
        {
            var result = new int[array.Length];
            var count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 50 && array[i] % 2 != 0 && array[i] % 9 == 0)
                {
                    result[count] = array[i];
                    count++;
                }
            }
            return result;
        }
        /// <summary>
        /// recebe uma lista de inteiros e retorna uma lista que contém os valores superiores a 50, impares e divisiveis por 9
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> NumsWithList(List<int> list)
        {
            var result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 50 && list[i] % 2 != 0 && list[i] % 9 == 0) result.Add(list[i]);                
            }
            return result;
        }        
    }

  
}
