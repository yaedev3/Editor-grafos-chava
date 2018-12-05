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
    public partial class BusquedaProfundidad : Form
    {
        private Pen wiw;
        private Grafo grafo;
        private Font font;
        private StringFormat formato;

        public BusquedaProfundidad(Grafo grafo)
        {
            InitializeComponent();
            wiw = new Pen(Color.Aqua);
            wiw.Width = 3;
            this.grafo = grafo.CopiarGrafo();          
            font = new Font("Arial", 11);//estilo de la letra
            formato = new StringFormat();//formato de la cadena
            formato.FormatFlags = StringFormatFlags.FitBlackBox;
            BuscaNodos();

            if (grafo.GetTipoArista == 0)
                Text = "Busqueda en profundidad";
            else
                Text = "Busqueda en amplitud";
        }

        private void BuscaNodos()
        {
            foreach (Nodo nodo in grafo.GetNodos)
                toolStripComboBoxNodos.Items.Add(nodo.GetNombre);
        }

        private void BusquedaProfundidad_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //wiw.CustomEndCap = new AdjustableArrowCap(5, 5);
            g.SmoothingMode = SmoothingMode.HighQuality;

            if(grafo.GetTipoArista == 0)
            {
                g.DrawString("Arco", new Font("Arial", 13), Brushes.Red, 10, toolStrip1.Height + 10);
                g.DrawString("Cruzado", new Font("Arial", 13), Brushes.Blue, 10, toolStrip1.Height + 30);
                g.DrawString("Retroceso", new Font("Arial", 13), Brushes.Green, 10, toolStrip1.Height + 50);
                g.DrawString("Avance", new Font("Arial", 13), Brushes.Orange, 10, toolStrip1.Height + 70);
            }

            foreach(Arista arista in grafo.GetAristas)
            {
                if (arista.GetGrupo == 1)
                    wiw.Color = Color.Red;
                else if (arista.GetGrupo == 2)
                    wiw.Color = Color.Blue;
                else if (arista.GetGrupo == 3)
                    wiw.Color = Color.Green;
                else if (arista.GetGrupo == 4)
                    wiw.Color = Color.Orange;
                e.Graphics.DrawLines(wiw, arista.GetCentro());
            }
            
            foreach (Nodo nodo in grafo.GetNodos)
            {
                e.Graphics.DrawEllipse(Pens.Black, nodo.GetRectangulo);
                e.Graphics.FillEllipse(Brushes.White, nodo.GetRectangulo);
                e.Graphics.DrawString(nodo.GetNombre, font, Brushes.Black, nodo.GetNombreRectangulo, formato);
            }
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxNodos.SelectedIndex != -1)
            {
                grafo.Busqueda(toolStrip1.Height + 90, Width, 15, toolStripComboBoxNodos.SelectedIndex);
                Invalidate();
            }
            else MessageBox.Show("Escoge un nodo raiz.");
        }
    }
}
