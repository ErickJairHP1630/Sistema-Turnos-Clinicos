using System;

namespace TurnosClinicos.Dominio
{
    /// <summary>
    /// Clase base de todos los turnos. Los campos son privados
    /// y las propiedades validan lo que se les asigna.
    /// </summary>
    public abstract class TurnoPaciente
    {
        private int _numero;
        private string _nombre = string.Empty;
        private readonly DateTime _horaRegistro;

        protected TurnoPaciente(int numero, string nombre)
        {
            Numero = numero;
            Nombre = nombre;
            _horaRegistro = DateTime.Now;
        }

        public int Numero
        {
            get => _numero;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("El número de turno debe ser mayor que cero.");
                _numero = value;
            }
        }

        public string Nombre
        {
            get => _nombre;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del paciente no puede estar vacío.");
                _nombre = value.Trim();
            }
        }

        public DateTime HoraRegistro => _horaRegistro;

        /// <summary>Texto que identifica el tipo de turno (polimorfismo).</summary>
        public abstract string Tipo { get; }

        public override string ToString() => $"#{Numero} - {Nombre} ({Tipo})";
    }
}
