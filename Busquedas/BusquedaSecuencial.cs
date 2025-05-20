namespace MetodosBusqueda.Busquedas
{
    public static class BusquedaSecuencial
    {
        public static int Buscar(int[] arreglo, int objetivo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == objetivo)
                    return i;
            }
            return -1;
        }
    }
}
