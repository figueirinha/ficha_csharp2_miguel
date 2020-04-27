using System;
using System.Collections.Generic;
using System.Text;

namespace Extras
{
    public static class Serializer
    {

        public static bool IsSerializable(object obj)
        {
            Type type = null; //altera esta linha para obter o tipo do objeto
            foreach(var att in type.GetCustomAttributes(true))
            {
                //Coloca algo neste contexto de forma a que verifiques se o atributo é serializable
            }
            return false;
        }
    }
}
