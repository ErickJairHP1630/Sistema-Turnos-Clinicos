using System.Collections.Generic;
using TurnosClinicos.Dominio;

namespace TurnosClinicos.Interfaces
{
    /// <summary>
    /// Lo único que el formulario puede usar. Cola vacía no lanza
    /// excepciones: devuelve false o null.
    /// </summary>
    public interface IServicioSalaEspera
    {
        TurnoPaciente? TurnoEnCurso { get; }
        int TotalEnEspera { get; }

        void RegistrarTurno(TurnoPaciente turno);
        bool InsertarUrgente(TurnoUrgencia turno, int posicion);
        bool AtenderSiguiente();
        bool CancelarTurno(int numero);

        IEnumerable<TurnoPaciente> ListarDirecto();
        IEnumerable<TurnoPaciente> ListarInverso();
    }
}
