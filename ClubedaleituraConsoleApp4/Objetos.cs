using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaleituraConsoleApp4
{
    internal class Objetos
    {
       public int acharaposicaocorreta ( dynamic array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                    continue;
                    return i;
            }
            return -1;

        }



    }
}
