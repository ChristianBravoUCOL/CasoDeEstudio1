namespace CasoDeEstudio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarResumen_Click(object sender, EventArgs e)
        {
            // ==========================================
            // 1. VALIDAR EL NOMBRE
            // ==========================================

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "Por favor, escribe tu nombre.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                
            }

            // ==========================================
            // 2. OBTENER LAS ACTIVIDADES SELECCIONADAS
            // ==========================================

            List<string> actividades = new List<string>();

            if (chkDeportes.Checked)
            {
                actividades.Add("Deportes");
            }

            if (chkMusica.Checked)
            {
                actividades.Add("Música");
            }

            if (chkArte.Checked)
            {
                actividades.Add("Arte");
            }

            if (chkProgramacion.Checked)
            {
                actividades.Add("Programación");
            }

            if (chkLectura.Checked)
            {
                actividades.Add("Lectura");
            }

            // ==========================================
            // 3. COMPROBAR QUE SE SELECCIONÓ
            //    AL MENOS UNA ACTIVIDAD
            // ==========================================

            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Selecciona al menos una actividad.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);                
            }

        }
    }
}
