using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurnosClinicos.UI
{
    /// <summary>
    /// Formulario principal. Día 2: solo la estructura visual, sin lógica.
    /// Los servicios se conectan por constructor el Día 4.
    /// </summary>
    public class frmTurnos : Form
    {
        private Label lblNumeroEnCurso = null!;
        private Label lblNombreEnCurso = null!;
        private ListBox lstFila = null!;
        private ToolStripStatusLabel lblEstado = null!;

        public frmTurnos()
        {
            ConfigurarFormulario();

            var raiz = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                BackColor = Tema.Fondo
            };
            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));    // encabezado
            raiz.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));    // contenido
            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));    // botones

            raiz.Controls.Add(CrearEncabezado(), 0, 0);
            raiz.Controls.Add(CrearContenido(), 0, 1);
            raiz.Controls.Add(CrearBotones(), 0, 2);

            // El control que llena (Fill) se agrega primero y la barra de estado después.
            Controls.Add(raiz);
            Controls.Add(CrearBarraEstado());
        }

        private void ConfigurarFormulario()
        {
            Text = "Turnos Clínicos";
            Size = new Size(960, 600);
            MinimumSize = new Size(800, 500);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Tema.Fondo;
            ForeColor = Tema.Texto;
            Font = Tema.Normal;
        }

        private Control CrearEncabezado()
        {
            var panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Tema.Primario,
                ColumnCount = 3,
                RowCount = 1,
                Padding = new Padding(12, 0, 12, 0)
            };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            var icono = new Label
            {
                Text = "✚",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Tema.Fondo,
                Font = Tema.Titulo
            };
            var titulo = new Label
            {
                Text = "Sala de Espera - Turnos Clínicos",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Tema.Fondo,
                Font = Tema.Titulo
            };
            var equipo = new Label
            {
                Text = "Equipo: [8]",  
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Tema.Fondo,
                AutoSize = true
            };

            panel.Controls.Add(icono, 0, 0);
            panel.Controls.Add(titulo, 1, 0);
            panel.Controls.Add(equipo, 2, 0);
            return panel;
        }

        private Control CrearContenido()
        {
            var contenido = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(12),
                BackColor = Tema.Fondo
            };
            contenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            contenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));

            // Panel del turno en curso (el grande lo terminamos el Día 3)
            var panelCurso = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Tema.Secundario,
                ColumnCount = 1,
                RowCount = 3,
                Margin = new Padding(0, 0, 8, 0)
            };
            panelCurso.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            panelCurso.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCurso.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));

            var lblTitulo = new Label
            {
                Text = "TURNO EN CURSO",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Tema.Primario,
                Font = Tema.Normal
            };
            lblNumeroEnCurso = new Label
            {
                Text = "---",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Tema.Texto,
                Font = Tema.Numero
            };
            lblNombreEnCurso = new Label
            {
                Text = "Sin pacientes",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Tema.Texto,
                Font = Tema.Titulo
            };
            panelCurso.Controls.Add(lblTitulo, 0, 0);
            panelCurso.Controls.Add(lblNumeroEnCurso, 0, 1);
            panelCurso.Controls.Add(lblNombreEnCurso, 0, 2);

            // Fila de espera
            lstFila = new ListBox
            {
                Dock = DockStyle.Fill,
                BackColor = Tema.Fondo,
                ForeColor = Tema.Texto,
                Font = Tema.Normal,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(8, 0, 0, 0)
            };

            contenido.Controls.Add(panelCurso, 0, 0);
            contenido.Controls.Add(lstFila, 1, 0);
            return contenido;
        }

        private Control CrearBotones()
        {
            var flujo = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Tema.Fondo,
                Padding = new Padding(12, 10, 12, 10),
                FlowDirection = FlowDirection.LeftToRight
            };
            flujo.Controls.Add(CrearBoton("Registrar"));
            flujo.Controls.Add(CrearBoton("Atender"));
            flujo.Controls.Add(CrearBoton("Urgencia"));
            flujo.Controls.Add(CrearBoton("Cancelar"));
            return flujo;
        }

        private Button CrearBoton(string texto)
        {
            var boton = new Button
            {
                Text = texto,
                Size = new Size(130, 44),
                FlatStyle = FlatStyle.Flat,
                BackColor = Tema.Primario,
                ForeColor = Tema.Fondo,
                Font = Tema.Normal,
                Cursor = Cursors.Hand
            };
            boton.FlatAppearance.BorderSize = 0;
            // Día 2: sin lógica todavía, solo un aviso en la barra de estado
            boton.Click += (s, e) => lblEstado.Text = $"'{texto}' se conecta el Día 4";
            return boton;
        }

        private void InitializeComponent()
        {

        }

        private Control CrearBarraEstado()
        {
            var barra = new StatusStrip
            {
                BackColor = Tema.Primario,
                SizingGrip = false
            };
            lblEstado = new ToolStripStatusLabel
            {
                Text = "Listo",
                ForeColor = Tema.Fondo,
                Font = Tema.Normal
            };
            barra.Items.Add(lblEstado);
            return barra;
        }
    }
}
