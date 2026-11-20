using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace frmPracticasEventos
{
    public partial class frmEventos : Form
    {

        private int segundos = 0;
        private bool estado = true;
        public frmEventos()
        {
            InitializeComponent();

            panelImagen.AllowDrop = true;

            timer1.Interval = 1000;
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {
            estado = !estado;

            if (estado)
            {
                lblEstado.Text = "Activo";
                lblEstado.ForeColor = Color.Green;
            }
            else
            {
                lblEstado.Text = "Inactivo";
                lblEstado.ForeColor = Color.Red;
            }
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] archivos =
                    (string[])e.Data.GetData(DataFormats.FileDrop);

                if (archivos.Length > 0 && EsImagen(archivos[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos =
                (string[])e.Data.GetData(DataFormats.FileDrop);

            if (archivos.Length > 0 && EsImagen(archivos[0]))
            {
                try
                {
                    using (Image imagen = Image.FromFile(archivos[0]))
                    {
                        Image copia = new Bitmap(imagen);

                        Image anterior = panelImagen.BackgroundImage;

                        panelImagen.BackgroundImage = copia;
                        panelImagen.BackgroundImageLayout = ImageLayout.Zoom;

                        if (anterior != null)
                        {
                            anterior.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private bool EsImagen(string archivo)
        {
            string extension = Path.GetExtension(archivo).ToLower();

            return extension == ".jpg" ||
                   extension == ".jpeg" ||
                   extension == ".png" ||
                   extension == ".bmp" ||
                   extension == ".gif";
        }

        private void btnTemporizador_Click(object sender, EventArgs e)
        {
            segundos = 0;

            lblTiempo.Text = "Tiempo: 0 segundos";

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            lblTiempo.Text = "Tiempo: " + segundos + " segundos";
        }
    }
}
