using System.Collections.Generic;
using TurnosClinicos.Dominio;
using TurnosClinicos.Interfaces;

namespace TurnosClinicos.Estructuras
{
    /// <summary>
    /// Lista doblemente enlazada propia. Aquí (y solo aquí) se manejan
    /// los punteros Siguiente y Anterior. No usa List, LinkedList ni Queue.
    /// </summary>
    public class ListaDoble<T> : IListaTurnos<T> where T : TurnoPaciente
    {
        public NodoDoble<T>? Cabeza { get; private set; }
        public NodoDoble<T>? Cola { get; private set; }

        private int _contar;
        public int Contar => _contar;

        // ---------- DÍA 2 ----------

        /// <summary>Agrega un turno al final de la fila.</summary>
        public void Encolar(T turno)
        {
            var nuevo = new NodoDoble<T>(turno);

            if (Cabeza == null)            // lista vacía
            {
                Cabeza = nuevo;
                Cola = nuevo;
            }
            else
            {
                Cola!.Siguiente = nuevo;   // el último apunta al nuevo
                nuevo.Anterior = Cola;     // el nuevo apunta de vuelta
                Cola = nuevo;              // el nuevo es ahora el último
            }
            _contar++;
        }

        /// <summary>Saca el primer turno. Si la lista está vacía devuelve null.</summary>
        public T? Atender()
        {
            if (Cabeza == null) return null;

            var nodo = Cabeza;
            Cabeza = nodo.Siguiente;

            if (Cabeza == null)            // era el único nodo
                Cola = null;
            else
                Cabeza.Anterior = null;    // el nuevo primero ya no tiene anterior

            nodo.Siguiente = null;
            _contar--;
            return nodo.Dato;
        }

        // ---------- DÍA 3 (pendientes, Persona A) ----------
        // Por ahora son esqueletos para que el proyecto compile.

        public bool InsertarEn(int posicion, T turno) { return false; }      // TODO Día 3
        public T? BuscarPorNumero(int numero) { return null; }               // TODO Día 3
        public bool Cancelar(int numero) { return false; }                   // TODO Día 3
        public IEnumerable<T> RecorrerDirecto() { yield break; }             // TODO Día 3
        public IEnumerable<T> RecorrerInverso() { yield break; }             // TODO Día 3
    }
}
