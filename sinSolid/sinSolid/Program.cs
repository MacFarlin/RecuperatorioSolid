namespace sinSolid
{   class Programa
    {
        static void Main()
        {
            RenderizadorDeVideo renderizador = new RenderizadorDeVideo();
            renderizador.RenderizarEnMp4();
            renderizador.RenderizarEnAvi();
            renderizador.RenderizarEnMkv();
        }
    }
}