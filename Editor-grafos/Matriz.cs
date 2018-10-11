using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_grafos
{
    public partial class Matriz : Form
    {
        //ventana para mostrar las matrices
        public Matriz(List<List<string>> valores, string nombre)
        {
            InitializeComponent();
            AgregaValores(valores);
            this.Text = nombre;
        }

        //agrega los valores al data grid
        private void AgregaValores(List<List<string>> valores)
        {
            foreach (string encabezado in valores[0])
                dataGridViewMatriz.Columns.Add("", encabezado);

            for (int i = 1; i < valores.Count; i++)
            {
                dataGridViewMatriz.Rows.Add();
                for (int j = 0; j < valores[i].Count; j++)
                    dataGridViewMatriz[j, i - 1].Value = valores[i][j];
            }
        }
    }
}
