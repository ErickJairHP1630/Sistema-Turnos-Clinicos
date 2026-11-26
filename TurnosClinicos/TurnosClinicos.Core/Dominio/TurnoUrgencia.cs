namespace TurnosClinicos.Dominio
{
    // PENDIENTE (Día 2, Persona B): completar. Por ahora es solo un esqueleto para que compile.
    public class TurnoUrgencia : TurnoPaciente
    {
        public TurnoUrgencia(int numero, string nombre) : base(numero, nombre) { }
        public override string Tipo => "Urgencia";
    }
}
