using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Editor_grafos
{
    public class Arista
    {
        private Nodo origen, destino;
        private string nombre;
        private List<Point> puntos;
        private bool visitado;
        private int peso, grupo;
        private List<Rectangle> rectangulos;

        public Arista(Nodo origen, Nodo destino, int nombre)
        {
            this.origen = origen;
            this.destino = destino;
            this.nombre = "E" + nombre;
            visitado = false;
            puntos = new List<Point>();
            rectangulos = new List<Rectangle>();
            CalculaArista();
            peso = 0;
            grupo = 0;
        }

        //devuelve el grupo
        public int GetGrupo
        {
            get
            {
                return grupo;
            }
            set
            {
                grupo = value;
            }
        }

        //regresa el nodo origen
        public Nodo GetOrigen
        {
            get
            {
                return origen;
            }
        }

        //regresa el nodo destino
        public Nodo GetDestino
        {
            get
            {
                return destino;
            }
        }

        //regresa el nombre de la arista
        public string GetNombre
        {
            get
            {
                return nombre.ToString();
            }
        }

        //regresa y asigna una lista de puntos
        public List<Point> GetPuntos
        {
            get
            {
                return puntos;
            }
            set
            {
                puntos = value;
            }
        }

        //devuelve dos puntos que representan los centros de los dos nodos
        public Point[] GetCentro()
        {
            Point[] ret = new Point[2];

            if(puntos.Count !=0)
            {
                ret[0] = puntos[0];
                ret[1] = puntos[puntos.Count - 1];
            }
            else
            {
                ret[0] = origen.GetCentro();
                ret[1] = destino.GetCentro();
            }
            
            return ret;
        }

        //devuelve el peso de la arista
        public int GetPeso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;
            }
        }

        //calcula los puntos que recorre la arista con formulas de graficacion a
        private void CalculaArista()
        {
            double y1, y2, x1, x2, dt, distancia;
            int tamano, xNueva, yNueva;

            tamano = origen.GetTamano;
            dt = .001;
            distancia = tamano * dt;
            y1 = origen.GetY + (tamano / 2);
            y2 = destino.GetY + (tamano / 2);
            x1 = origen.GetX + (tamano / 2);
            x2 = destino.GetX + (tamano / 2);

            for (double i = 0; i < 1; i += dt)
            {
                xNueva = (int)(x1 + i * (x2 - x1));
                yNueva = (int)(y1 + i * (y2 - y1));
                if (!origen.EstaDentro(xNueva, yNueva) && !destino.EstaDentro(xNueva, yNueva))
                {
                    puntos.Add(new Point(xNueva, yNueva));
                    rectangulos.Add(new Rectangle(xNueva - 3, yNueva - 3, 3, 3));
                }
            }              
        }

        //verifica si se dio un click en la arista
        public bool EstaDentro(int x, int y)
        {
            bool respuesta = false;

            foreach(Rectangle rectangulo in rectangulos)
                if(rectangulo.Contains(x,y))
                {
                    respuesta = true;
                    break;
                }

            return respuesta;
        }

        //regresa un rectangulo para dibujar el nombre de la arista
        public Rectangle GetNombreRectangulo
        {
            get
            {
                int puntoMedio = puntos.Count / 2;
                Rectangle auxiliar;

                if (puntos.Count != 0)
                    auxiliar = new Rectangle(puntos[puntoMedio].X + origen.GetTamano / 4, puntos[puntoMedio].Y + origen.GetTamano / 4 + 5, origen.GetTamano, origen.GetTamano);
                else auxiliar = new Rectangle(origen.GetRectangulo.X + origen.GetTamano / 4, origen.GetRectangulo.Y + origen.GetTamano / 4 + 5, origen.GetTamano, origen.GetTamano);

                return auxiliar;
            }
        }

        //devuelve la bandera si la arista esta visitada
        public bool GetVisitado
        {
            get
            {
                return visitado;
            }
            set
            {
                visitado = value;
            }
        }
    }
}
