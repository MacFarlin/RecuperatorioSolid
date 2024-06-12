using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conSolid.Clases
{
    // Implementamos la interfaz para renderizar en formato MKV
    public class RenderizadorMkv : IRenderizadorDeVideo
    {
        public void Renderizar()
        {
            // Renderiza video en MKV
            Console.WriteLine("Renderizando Video en Formato MKV");
        }
    }
}
