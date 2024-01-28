using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w67248
{
    public class Historia
    {
        public List<Data> ListaHistoria = new List<Data>();

        public Historia(List<Data> listaHistoria)
        {
            ListaHistoria = listaHistoria;
        }
    }
}
