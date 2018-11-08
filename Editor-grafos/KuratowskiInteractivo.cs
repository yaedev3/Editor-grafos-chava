using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Editor_grafos
{
    public partial class KuratowskiInteractivo : Form
    {
        private Grafo grafo;
        private Pen pluma;
        private SolidBrush etiquetas;
        private Font font;
        private StringFormat formato;

        public KuratowskiInteractivo(Grafo grafo)
        {
            InitializeComponent();
            this.grafo = grafo;
            pluma = new Pen(Color.Black);//pluma para dibujar
            etiquetas = new SolidBrush(Color.Black);//color de fondo de los nodos
            font = new Font("Arial", 11);//estilo de la letra
            formato = new StringFormat();//formato de la cadena
            formato.FormatFlags = StringFormatFlags.FitBlackBox;
        }

        private void toolStripButtonComprobar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonAgregarNodo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonQuitarNodo_Click(object sender, EventArgs e)
        {

        }

        private void KuratowskiInteractivo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        //metodo para dibujar los nodos y aristas
        private void KuratowskiInteractivo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;//hace las lineas mas suaves a la vista

            foreach (Arista arista in grafo.GetAristas)
                e.Graphics.DrawLines(pluma, arista.GetCentro());

            foreach (Nodo nodo in grafo.GetNodos)
            {
                e.Graphics.DrawEllipse(pluma, nodo.GetRectangulo);
                e.Graphics.FillEllipse(new SolidBrush(Color.White), nodo.GetRectangulo);
                e.Graphics.DrawString(nodo.GetNombre, font, etiquetas, nodo.GetNombreRectangulo, formato);
            }
        }
    }
}
