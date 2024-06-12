using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conSolid.Clases
{
    public class ServicioDeRenderizacion
    {
        // DIP: Principio de Inversión de Dependencias
        private IRenderizadorDeVideo _renderizador;

        // Constructor de renderizadores
        public ServicioDeRenderizacion(IRenderizadorDeVideo renderizadorDeVideo)
        {
            _renderizador = renderizadorDeVideo;
        }

        // Método que llama al método Renderizar 
        public void Renderizar()
        {
            _renderizador.Renderizar();
        }
    }
}