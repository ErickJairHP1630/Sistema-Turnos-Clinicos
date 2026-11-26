using System.Collections.Generic;
using TurnosClinicos.Dominio;

namespace TurnosClinicos.Interfaces
{
    /// <summary>
    /// Contrato común: lo implementan ListaDoble (propia) y
    /// AdaptadorLinkedList (colección de .NET) para poder compararlas.
    /// </summary>
    public interface IListaTurnos<T> where T : TurnoPaciente
    {
        int Contar { get; }

        void Encolar(T turno);                  // agrega al final
        T? Atender();                           // saca el primero (null si está vacía)
        bool InsertarEn(int posicion, T turno); // para urgencias
        T? BuscarPorNumero(int numero);
        bool Cancelar(int numero);              // elimina un nodo de en medio

        IEnumerable<T> RecorrerDirecto();       // cabeza -> cola
        IEnumerable<T> RecorrerInverso();       // cola -> cabeza
    }
}
