namespace TurnosClinicos.Dominio
{
    /// <summary>Paciente de urgencia: se inserta en una posición específica de la fila.</summary>
    public class TurnoUrgencia : TurnoPaciente
    {
        public TurnoUrgencia(int numero, string nombre) : base(numero, nombre) { }

        public override string Tipo => "Urgencia";
    }
}
