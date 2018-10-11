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
    public partial class GrafosEspeciales : Form
    {
        private GrafosEspecialesN Grafos;
        private int tipo;

        public GrafosEspeciales(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        //Evento del boton de aceptar, manda llamar un delegado para crear el grafo especial
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Grafos(tipo, (int)numericUpDownTamano.Value);
            Close();
        }

        //metodo de acceso para regresar y asignar el delegado
        public GrafosEspecialesN GetDelegado
        {
            get
            {
                return Grafos;
            }

            set
            {
                Grafos = value;
            }
        }
    }
}
