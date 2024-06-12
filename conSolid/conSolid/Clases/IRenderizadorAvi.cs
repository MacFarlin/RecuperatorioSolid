using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conSolid.Clases
{
    // Implementamos la interfaz para renderizar en formato AVI
    public class RenderizadorAvi : IRenderizadorDeVideo
    {
        public void Renderizar()
        {
            // Renderiza video en AVI
            Console.WriteLine("Renderizando Video en Formato AVI");
        }
    }
}
