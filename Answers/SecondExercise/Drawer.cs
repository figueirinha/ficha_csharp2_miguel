using System;
using System.Collections.Generic;

namespace Answers
{
    /// <summary>
    /// Criação do atributo Stuck que se aplica apenas a classes
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class StuckAttributte : Attribute
    {

    }    
    /// <summary>
    /// implementação do atributo Stuck à classe Drawer
    /// </summary>
    [StuckAttributte]
    public class Drawer
    {
        /// <summary>
        /// dicionario com indexador
        /// </summary>
        private Dictionary<string, object> _data;
        public Drawer()
        {
            _data = new Dictionary<string, object>();
            if (_data.ContainsValue(7)) throw new IsStuckException(); //valor aleatorio 7
        }
        public object this[string index]
        {
            get => _data.ContainsKey(index) ? _data[index] : null;
            set => _data[index] = value;
        } 
           
    }
    /// <summary>
    /// criação de uma exceção para gaveta cheia
    /// </summary>
    public class IsStuckException: Exception { }
}
