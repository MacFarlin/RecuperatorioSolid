using conSolid.Clases;

namespace conSolid
{
    class Programa
    {
        static void Main(string[] args)
        {   
            // Creamos instancias de los diferentes renderizadores
            IRenderizadorDeVideo renderizadorMp4 = new RenderizadorMp4();
            IRenderizadorDeVideo renderizadorAvi = new RenderizadorAvi();
            IRenderizadorDeVideo renderizadorMkv = new RenderizadorMkv();

            // Creamos instancias del servicio de renderización
            ServicioDeRenderizacion servicioMp4 = new ServicioDeRenderizacion(renderizadorMp4);
            ServicioDeRenderizacion servicioAvi = new ServicioDeRenderizacion(renderizadorAvi);
            ServicioDeRenderizacion servicioMkv = new ServicioDeRenderizacion(renderizadorMkv);

            // Llamamos al método Renderizar
            servicioMp4.Renderizar();
            servicioAvi.Renderizar();
            servicioMkv.Renderizar();
        }
    }
}