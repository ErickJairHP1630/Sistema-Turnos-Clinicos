namespace TurnosClinicos.Estructuras
{
    /// <summary>
    /// Nodo genérico con dos enlaces: uno al siguiente y otro al anterior.
    /// </summary>
    public class NodoDoble<T>
    {
        public T Dato { get; set; }
        public NodoDoble<T>? Siguiente { get; set; }
        public NodoDoble<T>? Anterior { get; set; }

        public NodoDoble(T dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}
