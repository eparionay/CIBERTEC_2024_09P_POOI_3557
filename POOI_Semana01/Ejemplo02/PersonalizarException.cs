using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    internal class PersonalizarException : Exception
    {
        public PersonalizarException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
