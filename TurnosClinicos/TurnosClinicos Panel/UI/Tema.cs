namespace TurnosClinicos.UI
{
    /// <summary>
    /// Paleta (4 colores) y fuentes (2) de toda la aplicación.
    /// Nadie usa colores sueltos: todo sale de aquí.
    /// </summary>
    public static class Tema
    {
        // Paleta
        public static readonly Color Fondo = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color Primario = ColorTranslator.FromHtml("#0F766E"); // verde azulado
        public static readonly Color Secundario = ColorTranslator.FromHtml("#F1F5F4"); // gris suave
        public static readonly Color Texto = ColorTranslator.FromHtml("#1F2937");

        // Fuentes
        public static readonly Font Normal = new Font("Segoe UI", 10F);
        public static readonly Font Titulo = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static readonly Font Numero = new Font("Consolas", 64F, FontStyle.Bold);
    }
}
