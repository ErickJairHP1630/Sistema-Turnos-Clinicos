namespace TurnosClinicos.Dominio
{
    /// <summary>Paciente de atención normal, por orden de llegada.</summary>
    public class TurnoGeneral : TurnoPaciente
    {
        public TurnoGeneral(int numero, string nombre) : base(numero, nombre) { }

        public override string Tipo => "General";
    }
}
