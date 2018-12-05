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
        private int accion;
        private Nodo origen, destino;

        public KuratowskiInteractivo(Grafo grafo)
        {
            InitializeComponent();
            this.grafo = new Grafo();
            this.grafo.GetAristas.AddRange(grafo.GetAristas);
            this.grafo.GetNodos.AddRange(grafo.GetNodos);
            this.grafo.nombreNodo += grafo.GetNodos.Count;
            pluma = new Pen(Color.Black);//pluma para dibujar
            etiquetas = new SolidBrush(Color.Black);//color de fondo de los nodos
            font = new Font("Arial", 11);//estilo de la letra
            formato = new StringFormat();//formato de la cadena
            formato.FormatFlags = StringFormatFlags.FitBlackBox;
            toolStripComboBoxGrafos.Items.Add("K5");
            toolStripComboBoxGrafos.Items.Add("K3,3");
            destino = origen = new Nodo(0, 0, '♪');//inicializa los nodos
            accion = -1;
        }

        //comprueba si el grafo es isomorfico al grafo especificado
        private void toolStripButtonComprobar_Click(object sender, EventArgs e)
        {
            if (!toolStripComboBoxGrafos.Text.Equals(""))
                if (toolStripComboBoxGrafos.SelectedIndex == 0)
                    MessageBox.Show(grafo.Kuratowsky(), "Kuratoswki");
                else MessageBox.Show(grafo.KuratowskyK33(), "Kuratoswki");
            else MessageBox.Show("Selecciona un grafo con cual comparar");

            toolStripButtonAgregarNodo.BackColor = Color.White;
            toolStripButtonQuitarNodo.BackColor = Color.White;
            accion = -1;
        }

        
        private void toolStripButtonAgregarNodo_Click(object sender, EventArgs e)
        {
            CambiaBlanco();
            toolStripButtonAgregarNodo.BackColor = Color.Red;
            accion = 0;
        }

        private void toolStripButtonQuitarNodo_Click(object sender, EventArgs e)
        {
            CambiaBlanco();
            toolStripButtonQuitarNodo.BackColor = Color.Red;
            accion = 1;
        }

        private void CambiaBlanco()
        {
            toolStripButtonQuitarNodo.BackColor = Color.White;
            toolStripButtonAgregarNodo.BackColor = Color.White;
            toolStripButtonAgregarAristas.BackColor = Color.White;
            toolStripButtonQuitar.BackColor = Color.White;
        }

        private void KuratowskiInteractivo_MouseDown(object sender, MouseEventArgs e)
        {
            switch (accion)
            {
                case 0:
                    for(int i=0;i<grafo.GetAristas.Count;i++)
                        if (grafo.GetAristas[i].EstaDentro(e.X, e.Y))
                        {
                            AgregaNodo(grafo.GetAristas[i], e.X, e.Y);
                            grafo.GetAristas.RemoveAt(i);
                            break;
                        }
                    Invalidate();
                    break;
                case 1:

                    for (int i = 0; i < grafo.GetAristas.Count; i++)
                        if (grafo.GetAristas[i].EstaDentro(e.X, e.Y))
                        {
                            grafo.GetAristas.RemoveAt(i);
                            break;
                        }
                    Invalidate();
                    break;
                case 2:
                    if (grafo.EstaDentro(e.X, e.Y) && origen.Igual(new Nodo(0, 0, '♪')))
                        origen = grafo.GetNodoSeleccionado(e.X, e.Y);
                    else if (grafo.EstaDentro(e.X, e.Y) && destino.Igual(new Nodo(0, 0, '♪')))
                    {
                        destino = grafo.GetNodoSeleccionado(e.X, e.Y);
                        grafo.NuevaArista(origen, destino);
                        destino = origen = new Nodo(0, 0, '♪');
                    }
                    else
                        destino = origen = new Nodo(0, 0, '♪');//reinicia los nodos
                    Invalidate();
                    break;
                case 3:
                    int indice = -1;

                    for (int i = 0; i < grafo.GetNodos.Count; i++)
                        if (grafo.GetNodos[i].EstaDentro(e.X, e.Y))
                        {
                            indice = i;
                            break;
                        }
                    if (indice != -1)
                        grafo.EliminaNodo(indice);
                    Invalidate();
                    break;
            }
        }

        //elimina una arista y crea un nodo en su lugar
        private void AgregaNodo(Arista arista, int x , int y)
        {
            grafo.NuevoNodo(x, y);
            grafo.NuevaArista(arista.GetOrigen, grafo.GetNodos[grafo.GetNodos.Count - 1]);
            grafo.NuevaArista(grafo.GetNodos[grafo.GetNodos.Count - 1], arista.GetDestino);
        }

        //metodo para dibujar los nodos y aristas
        private void KuratowskiInteractivo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;//hace las lineas mas suaves a la vista

            foreach (Arista arista in grafo.GetAristas)
                arista.PintaArista(e.Graphics, pluma, false);

            foreach (Nodo nodo in grafo.GetNodos)
            {
                e.Graphics.DrawEllipse(pluma, nodo.GetRectangulo);
                e.Graphics.FillEllipse(new SolidBrush(Color.White), nodo.GetRectangulo);
                e.Graphics.DrawString(nodo.GetNombre, font, etiquetas, nodo.GetNombreRectangulo, formato);
            }
        }

        private void toolStripButtonAgregarAristas_Click(object sender, EventArgs e)
        {
            CambiaBlanco();
            accion = 2;
            toolStripButtonAgregarAristas.BackColor = Color.Red;
        }

        private void toolStripButtonQuitar_Click(object sender, EventArgs e)
        {
            CambiaBlanco();
            accion = 3;
            toolStripButtonQuitar.BackColor = Color.Red;
        }
    }
}
