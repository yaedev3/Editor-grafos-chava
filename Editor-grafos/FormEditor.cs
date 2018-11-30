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
        private Grafo grafo, grafoPrimero, grafoSegundo;
        private int accion, algoritmo, aristaSeleccionada;
        private Pen pluma;
        private SolidBrush etiquetas;
        private Font font;
        private StringFormat formato;
        private Nodo origen, destino;
        private List<Color> colores;
        private bool grafoActual;

        public FormEditor()
        {
            InitializeComponent();
            grafoPrimero = new Grafo();
            grafoSegundo = new Grafo();
            grafo = grafoPrimero;
            accion = -1;
            pluma = new Pen(Color.Black);//pluma para dibujar
            etiquetas = new SolidBrush(Color.Black);//color de fondo de los nodos
            font = new Font("Arial", 11);//estilo de la letra
            formato = new StringFormat();//formato de la cadena
            formato.FormatFlags = StringFormatFlags.FitBlackBox;
            destino = origen = new Nodo(0, 0, '♪');//inicializa los nodos
            colores = new List<Color>();
            DefineColores();
            algoritmo = -1;
            numericUpDownPeso.Visible = false;
            grafoActual = false;
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
            numericUpDownPeso.Visible = false;
        }

        //metodo para dibujar los nodos y aristas
        private void FormEditor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;//hace las lineas mas suaves a la vista

            foreach (Arista arista in grafoPrimero.GetAristas)
            {
                e.Graphics.DrawLines(pluma, arista.GetCentro());
                e.Graphics.DrawString(arista.GetPeso.ToString(), font, etiquetas, arista.GetNombreRectangulo, formato);
            }

            foreach (Nodo nodo in grafoPrimero.GetNodos)
            {
                e.Graphics.DrawEllipse(pluma, nodo.GetRectangulo);
                switch(algoritmo)
                {
                    case -1:
                        e.Graphics.FillEllipse(new SolidBrush(Color.White), nodo.GetRectangulo);
                        break;
                    case 0://coloreado
                        e.Graphics.FillEllipse(new SolidBrush(colores[nodo.GetGrupo]), nodo.GetRectangulo);
                        break;
                }               
                e.Graphics.DrawString(nodo.GetNombre, font, etiquetas, nodo.GetNombreRectangulo, formato);
            }

            foreach (Arista arista in grafoSegundo.GetAristas)
            {
                e.Graphics.DrawLines(pluma, arista.GetCentro());
                e.Graphics.DrawString(arista.GetPeso.ToString(), font, etiquetas, arista.GetNombreRectangulo, formato);
            }

            foreach (Nodo nodo in grafoSegundo.GetNodos)
            {
                e.Graphics.DrawEllipse(pluma, nodo.GetRectangulo);
                switch (algoritmo)
                {
                    case -1:
                        e.Graphics.FillEllipse(new SolidBrush(Color.White), nodo.GetRectangulo);
                        break;
                    case 0://coloreado
                        e.Graphics.FillEllipse(new SolidBrush(colores[nodo.GetGrupo]), nodo.GetRectangulo);
                        break;
                }
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
            int inicio = toolStrip1.Height + toolStrip2.Height + 100;
            grafo.GetTipoArista = 1;
            pluma.CustomEndCap = new AdjustableArrowCap(0, 0);
            toolStripButtonAristaD.Enabled = false;


            switch (tipo)
            {
                case 1:
                    grafo.CN(tamano, inicio , Height - inicio, Width, 0);
                    Text = "C" + tamano.ToString();
                    break;
                case 2:
                    grafo.KN(tamano, inicio, Height - inicio, Width, 0);
                    Text = "K" + tamano.ToString();
                    break;
                case 3:
                    grafo.WN(tamano, inicio, Height - inicio, Width, 0);
                    Text = "W" + tamano.ToString();
                    break;
            }

            Invalidate();
        }

        //calcula los corolarios para saber si el grafo es plano y muestra un mensaje.
        private void toolStripButtonCorolarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.Corolario(), "Corolarios");
        }

        //calcula el algoritmo de caminos de euler en el grafo actual.
        private void toolStripButtonEuler_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.Euler(), "Euler");
        }

        //calcula kuratowsky automatico.
        private void toolStripButtonKura_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.Kuratowsky(), "Kuratoswki");
        }

        //
        private void toolStripButtonIso_Click(object sender, EventArgs e)
        {
            string resultado = "";
            grafoPrimero.isomorfismo(grafoSegundo, ref resultado, "Grafo uno", "Grafo dos");
            MessageBox.Show(resultado, "Isomorfismo");
        }

        //calcula el numero cromatico de los nodos
        private void toolStripButtonNumeroCromatico_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            algoritmo = 0;
            Invalidate();
            resultado = MessageBox.Show(grafo.NodosColoreados(), "Numero cromatico", MessageBoxButtons.OK);

            if (resultado == DialogResult.OK)
                algoritmo = -1;

            Invalidate();
        }

        //asigna el valor que tiene a la arista seleccionada
        private void numericUpDownPeso_ValueChanged(object sender, EventArgs e)
        {
            grafo.GetAristas[aristaSeleccionada].GetPeso = (int)numericUpDownPeso.Value;
        }

        //Kuratowski interactivo
        private void toolStripButtonKuratowskiInterativo_Click(object sender, EventArgs e)
        {
            KuratowskiInteractivo kuratowski = new KuratowskiInteractivo(grafo);
            kuratowski.Show();
        }

        //Kruskal
        private void toolStripButtonKruskal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.kruskal(), "Kruskal");
        }

        private void toolStripButtonQuitarArista_Click(object sender, EventArgs e)
        {
            accion = 3;
        }

        private void toolStripButtonEliminarNodo_Click(object sender, EventArgs e)
        {
            accion = 4;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            grafoActual = !grafoActual;

            if (grafoActual)
            {
                toolStripLabelGrafoActual.Text = "Dos";
                grafo = grafoSegundo;
            }
            else
            {
                toolStripLabelGrafoActual.Text = "Uno";
                grafo = grafoPrimero;
            }
        }

        private void toolStripButtonFloyd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.floyd(), "Floyd");
        }

        //evento del raton, hace diferentes cosas dependiendo de la accion
        //1 agrega un nuevo nodo
        //2 agrega una nueva arista
        private void FormEditor_MouseDown(object sender, MouseEventArgs e)
        {
            int indice;

            if (numericUpDownPeso.Visible)
            {
                numericUpDownPeso_ValueChanged(null, null);
                numericUpDownPeso.Visible = false;
            }
            switch (accion)
            {
                case 1:
                    if (!grafo.EstaDentro(e.X, e.Y))
                        grafo.NuevoNodo(e.X, e.Y);
                    break;
                case 2:
                    if (grafo.EstaDentro(e.X, e.Y) && origen.Igual(new Nodo(0, 0, '♪')))
                        origen = grafo.GetNodoSeleccionado(e.X, e.Y);
                    else if (grafo.EstaDentro(e.X, e.Y) && destino.Igual(new Nodo(0, 0, '♪')) && !origen.EstaDentro(e.X, e.Y))
                    {
                        destino = grafo.GetNodoSeleccionado(e.X, e.Y);
                        grafo.NuevaArista(origen, destino);
                        destino = origen = new Nodo(0, 0, '♪');
                    }
                    else
                        destino = origen = new Nodo(0, 0, '♪');//reinicia los nodos
                    break;
                case 3:
                    indice = -1;

                    for (int i = 0; i < grafo.GetAristas.Count; i++)
                        if (grafo.GetAristas[i].EstaDentro(e.X, e.Y))
                        {
                            indice = i;
                            break;
                        }
                    if (indice != -1)
                        grafo.EliminaArista(indice);
                    break;
                case 4:
                    indice = -1;

                    for (int i = 0; i < grafo.GetNodos.Count; i++)
                        if (grafo.GetNodos[i].EstaDentro(e.X, e.Y))
                        {
                            indice = i;
                            break;
                        }
                    if (indice != -1)
                        grafo.EliminaNodo(indice);

                    break;

            }

            foreach (Arista arista in grafo.GetAristas)
                if (arista.GetNombreRectangulo.Contains(e.X, e.Y))
                {
                    aristaSeleccionada = grafo.GetAristas.IndexOf(arista);
                    numericUpDownPeso.Visible = true;
                    numericUpDownPeso.Location = new Point(arista.GetNombreRectangulo.X, arista.GetNombreRectangulo.Y);
                    numericUpDownPeso.Value = arista.GetPeso;
                }

            Invalidate();//refresca la pantalla
        }

        //inicializa todos los colores posibles
        private void DefineColores()
        {
            try
            {
                int limite = 100;
                colores = Enum.GetValues(typeof(KnownColor)).Cast<KnownColor>().Select(Color.FromKnownColor).ToList();
                colores.RemoveRange(limite, colores.Count - 1 - limite);
                colores.Sort();
            }
            catch
            {

            }
        }
    }
}
