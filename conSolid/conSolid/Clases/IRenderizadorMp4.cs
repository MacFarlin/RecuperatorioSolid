using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conSolid.Clases
{
    // Implementamos la interfaz para renderizar en formato MKV
    public class RenderizadorMp4 : IRenderizadorDeVideo
    {
        public void Renderizar()
        {
            // Renderiza video en mp4
            Console.WriteLine("Renderizando Video en Formato MP4");
        }
    }
}
