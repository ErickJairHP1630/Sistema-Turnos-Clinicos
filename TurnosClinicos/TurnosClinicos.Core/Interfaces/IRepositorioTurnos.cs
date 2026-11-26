using System.Collections.Generic;
using TurnosClinicos.Dominio;

namespace TurnosClinicos.Interfaces
{
    /// <summary>Acceso a los turnos almacenados.</summary>
    public interface IRepositorioTurnos
    {
        int Cantidad { get; }
        void Agregar(TurnoPaciente turno);
        TurnoPaciente? ObtenerPorNumero(int numero);
        bool Eliminar(int numero);
        IEnumerable<TurnoPaciente> ObtenerTodos();
    }
}
