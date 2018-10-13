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
    public delegate void GrafosEspecialesN(int tipo, int tamano);

    public partial class FormEditor : Form
    {
        private Grafo grafo;
        private int accion;
        private Pen pluma;
        private SolidBrush etiquetas;
        private Font font;
        private StringFormat formato;
        private Nodo origen, destino;

        public FormEditor()
        {
            InitializeComponent();
            grafo = new Grafo();
            accion = -1;
            pluma = new Pen(Color.Black);//pluma para dibujar
            etiquetas = new SolidBrush(Color.Black);//color de fondo de los nodos
            font = new Font("Arial", 11);//estilo de la letra
            formato = new StringFormat();//formato de la cadena
            formato.FormatFlags = StringFormatFlags.FitBlackBox;
            destino = origen = new Nodo(0, 0, '♪');//inicializa los nodos
            toolStripButtonMatrizIncidencia.Visible = false;
        }

        //boton de agregar nodo pone la accion en 1
        private void toolStripButtonNodo_Click(object sender, EventArgs e)
        {
            accion = 1;
        }

        //boton de agregar arista dirigida pone la accion en 2
        private void toolStripButtonAristaD_Click(object sender, EventArgs e)
        {
            //0 = dirigido
            grafo.GetTipoArista = 0;
            pluma.CustomEndCap = new AdjustableArrowCap(5, 5);
            toolStripButtonAristaND.Enabled = false;
            accion = 2;
        }

        //boton de agregar la arista no dirigida pone la accion en 2
        private void toolStripButtonAristaND_Click(object sender, EventArgs e)
        {
            //1 = no dirigido
            grafo.GetTipoArista = 1;
            pluma.CustomEndCap = new AdjustableArrowCap(0, 0);
            toolStripButtonAristaD.Enabled = false;
            accion = 2;
        }

        //boton para limpiar el grafo
        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            grafo.Clear();
            toolStripButtonAristaND.Enabled = true;
            toolStripButtonAristaD.Enabled = true;
            accion = -1;
            Invalidate();
        }

        //metodo para dibujar los nodos y aristas
        private void FormEditor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;//hace las lineas mas suaves a la vista

            foreach (Arista arista in grafo.GetAristas)
            {
                e.Graphics.DrawLines(pluma, arista.GetCentro());
                e.Graphics.DrawString(arista.GetNombre, font, etiquetas, arista.GetNombreRectangulo, formato);
            }

            foreach(Nodo nodo in grafo.GetNodos)
            {
                e.Graphics.DrawEllipse(pluma, nodo.GetRectangulo);
                e.Graphics.FillEllipse(new SolidBrush(Color.White), nodo.GetRectangulo);
                e.Graphics.DrawString(nodo.GetNombre, font, etiquetas, nodo.GetNombreRectangulo, formato);
            }  
        }

        //abre una nueva ventana con la matriz de adyacencia
        private void toolStripButtonMatriz_Click(object sender, EventArgs e)
        {
            Matriz matriz = new Matriz(grafo.MatrizAdyacencia(), "Matriz de adyacencia");
            matriz.Show();
        }

        //abre una nueva ventana con la lista de adyacencia
        private void toolStripButtonListaAdyacencia_Click(object sender, EventArgs e)
        {
            Matriz matriz = new Matriz(grafo.ListaAdyacencia(), "Lista de adyacencia");
            matriz.Show();
        }

        //abre una nueva ventana con la los grados dirigidos
        private void toolStripButtonGradosDirigidos_Click(object sender, EventArgs e)
        {
            Matriz matriz = new Matriz(grafo.GradosDirigido(), "Grados dirigidos");
            matriz.Show();
        }

        //abre una nueva ventana con la los grados no dirigidos
        private void toolStripButtonGradosNoDirigidos_Click(object sender, EventArgs e)
        {
            Matriz matriz = new Matriz(grafo.GradosNoDirigido(), "Grados no dirigidos");
            matriz.Show();
        }

        //abre una nueva ventana con la matriz de incidencia
        private void toolStripButtonMatrizIncidencia_Click(object sender, EventArgs e)
        {
            Matriz matriz = new Matriz(grafo.MatrizIncidencia(), "Matriz de incidencia");
            matriz.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        //abre una nueva ventana para crear un grafo Cn
        private void toolStripButtonCn_Click(object sender, EventArgs e)
        {
            GrafosEspeciales ventana = new GrafosEspeciales(1);

            ventana.GetDelegado += GrafosEspeciales;
            ventana.Show();
        }

        //abre una nueva ventana para crear un grafo Kn
        private void toolStripButtonKn_Click(object sender, EventArgs e)
        {
            GrafosEspeciales ventana = new GrafosEspeciales(2);

            ventana.GetDelegado += GrafosEspeciales;
            ventana.Show();
        }

        //abre una nueva ventana para crear un grafo Wn
        private void toolStripButtonWn_Click(object sender, EventArgs e)
        {
            GrafosEspeciales ventana = new GrafosEspeciales(3);

            ventana.GetDelegado += GrafosEspeciales;
            ventana.Show();
        }

        //delegado para generar un grafo especial
        //1 Cn
        //2 Kn
        //3 Wn
        private void GrafosEspeciales(int tipo, int tamano)
        {
            grafo.GetTipoArista = 1;
            pluma.CustomEndCap = new AdjustableArrowCap(0, 0);
            toolStripButtonAristaD.Enabled = false;

            switch (tipo)
            {
                case 1:
                    grafo.CN(tamano, toolStrip1.Height, Height, Width, 0);
                    break;
                case 2:
                    grafo.KN(tamano, toolStrip1.Height, Height, Width, 0);
                    break;
                case 3:
                    grafo.WN(tamano, toolStrip1.Height, Height, Width, 0);
                    break;
            }

            Invalidate();
        }

        //calcula los corolarios para saber si el grafo es plano y muestra un mensaje.
        private void toolStripButtonCorolarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.Corolario(), "Corolarios");
        }

        private void toolStripButtonEuler_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.Euler(), "Euler");
        }

        //evento del raton, hace diferentes cosas dependiendo de la accion
        //1 agrega un nuevo nodo
        //2 agrega una nueva arista
        private void FormEditor_MouseDown(object sender, MouseEventArgs e)
        {
            switch(accion)
            {
                case 1:
                    if (!grafo.EstaDentro(e.X, e.Y))
                        grafo.NuevoNodo(e.X, e.Y);
                    break;
                case 2:
                    if (grafo.EstaDentro(e.X, e.Y) && origen.Igual(new Nodo(0, 0, '♪')))
                        origen = grafo.GetNodoSeleccionado(e.X, e.Y);
                    else if (grafo.EstaDentro(e.X, e.Y) && destino.Igual(new Nodo(0, 0, '♪')) && !origen.EstaDentro(e.X,e.Y))
                    {
                        destino = grafo.GetNodoSeleccionado(e.X, e.Y);
                        grafo.NuevaArista(origen, destino);
                        destino = origen = new Nodo(0, 0, '♪');
                    }
                    else
                        destino = origen = new Nodo(0, 0, '♪');//reinicia los nodos
                    break;
            }

            Invalidate();//refresca la pantalla
        }
    }
}
