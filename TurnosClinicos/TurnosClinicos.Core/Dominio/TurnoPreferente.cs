namespace TurnosClinicos.Dominio
{
    /// <summary>Paciente con atención preferente (adulto mayor, embarazo, discapacidad).</summary>
    public class TurnoPreferente : TurnoPaciente
    {
        public TurnoPreferente(int numero, string nombre) : base(numero, nombre) { }

        public override string Tipo => "Preferente";
    }
}
