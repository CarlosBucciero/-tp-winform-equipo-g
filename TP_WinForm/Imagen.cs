using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TP_WinForm
{
   public class Imagen
    {
        public int IdArticulo { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return Url;
        }

    }
}
