using System;
using System.Collections.Generic;
using System.Linq;

namespace Answers
{
    public class OneC
    {
        /// <summary>
        /// Recebe uma lista de inteiros e retorna o resultado da operação a ^ 2 * 8 * 3 com a = a cada elemento da lista
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> LetsDosomeMath(List<int> list)
        {
            var result = new List<int>();

            for (int i = 0; i < list.Count; i++) result.Add(((int)Math.Pow(list[i], 2) * 8 * 3));

            return result;
        }
        /// <summary>
        /// Recebe uma lista de inteiros e retorna o resultado da operação a ^ 2 * 8 * 3 com a = a cada elemento da lista utiizando o LINQ
        /// </summary>
        /// <param name="list"></param>
        public static void LetsDoMathWithLinq(List<int> list)
        {
            var num = from n in list select (int)Math.Pow(n, 2) * 8 * 3;            
        }
    }
    /// <summary>
    /// Classe estatica para métodos de extensão
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Método de extensão que recebe uma data e retorna o proximo dia util (segunda a sexta)
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime NextWrokingDay(this DateTime date)
        {
            if (date.DayOfWeek.ToString() == "Friday") return date.AddDays(3);
            else if (date.DayOfWeek.ToString() == "Saturday") return date.AddDays(2);
            else return date.AddDays(1);
        }
    }    

}
