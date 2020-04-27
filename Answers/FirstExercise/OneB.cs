using System;

namespace Answers
{
    public static class OneB
    {
        /// <summary>
        /// recebe uma string e retorna a última metade dessa string (arredondada para baixo)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HalfOfString(string str)
        {
            var halfStr = (double)str.Length / 2;
            var halfIndex = (int)Math.Floor(halfStr);
            var whatsLeft = (int)Math.Ceiling(halfStr);
            return str.Substring(halfIndex, whatsLeft);
        }
        /// <summary>
        /// recebe uma string e retorna verdadeiro se a string começar com 'a' e terminar com 'z'
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool StartsWithAEndsWithZ(string str)
        {
            return str.StartsWith("a") && str.EndsWith("z");
        }
        /// <summary>
        /// recebe uma string e retorna essa string sem espaços iniciais nem finais
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string TrimThatString(string str)
        {
            return str.Trim();
        }
    }

  
}
