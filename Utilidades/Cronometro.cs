using System;
using System.Diagnostics;

namespace MetodosBusqueda.Utilidades
{
    public static class Cronometro
    {
        public static long MedirTiempo(Action accion)
        {
            Stopwatch sw = Stopwatch.StartNew();
            accion();
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
