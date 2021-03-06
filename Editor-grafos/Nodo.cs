﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Editor_grafos
{
    public class Nodo
    {
        private int x, y, tamano, grupo;
        private char nombre;
        private List<Nodo> relaciones;
        private Rectangle rectangulo;
        private bool visitado;
        private string arbol;

        public Nodo(int x, int y, char nombre)
        {
            tamano = 30;
            //centrar el nodo al cursor
            x -= tamano / 2;
            y -= tamano / 2;
            this.x = x;
            this.y = y;
            grupo = 0;
            arbol = "";
            visitado = false;
            this.nombre = nombre;
            rectangulo = new Rectangle(x, y, tamano, tamano);
            relaciones = new List<Nodo>();
        }

        //verifica si esta dentro del nodo el cursor
        public bool EstaDentro(int x, int y)
        {
            return rectangulo.Contains(x, y);
        }

        //regresa el rectangulo para dibujar
        public Rectangle GetRectangulo
        {
            get
            {
                return new Rectangle(x, y, tamano, tamano); ;
            }
        }

        //regresa un rectangulo para dibujar el nombre del nodo
        public Rectangle GetNombreRectangulo
        {
            get
            {
                return new Rectangle(x + tamano / 4, y + tamano / 4, tamano, tamano);
            }
        }

        //regresa el nombre del nodo
        public string GetNombre
        {
            get
            {
                return nombre.ToString();
            }
        }

        //regresa una copia del mismo nodo
        public Nodo Copiar()
        {
            return new Nodo(x, y, nombre);
        }

        //verifica si dos nodos son iguales
        public bool Igual(Nodo nodo)
        {
            return rectangulo.Equals(nodo.GetRectangulo);
        }

        //regresa el centro del nodo
        public Point GetCentro()
        {
            return new Point(x + tamano / 2, y + tamano / 2);
        }

        //agrega una nueva relacion al nodo
        public void AgregarRelacion(ref Nodo relacion)
        {
            relaciones.Add(relacion);
        }

        //devuelve el valor de y
        public int GetY
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Point GetPointArriba
        {
            get
            {
                return new Point(x + tamano / 2, y);
            }
        }

        public Point GetPointAbajo
        {
            get
            {
                return new Point(x + tamano / 2, y + tamano);
            }
        }

        public Point GetPoint1
        {
            get
            {
                return new Point(x, y + tamano / 2);
            }
        }

        public Point GetPoint2
        {
            get
            {
                return new Point(x + tamano / 2, y);
            }
        }

        //devuelve el valor de x
        public int GetX
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        //devuelve el tamaño
        public int GetTamano
        {
            get
            {
                return tamano;
            }
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

        //devuelve las relaciones del nodo
        public List<Nodo> GetRelaciones
        {
            get
            {
                return relaciones;
            }
        }

        //busca en las relaciones si esta un nodoe especifico y regresa un 1 si lo encontro
        public string BuscaRelacion(string nombre)
        {
            string respuesta = "0";

            foreach (Nodo relacion in relaciones)
                if (relacion.GetNombre.Equals(nombre))
                    respuesta = "1";
            return respuesta;
        }

        //devuelve la bandera si el nodo esta visitado
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

        public string GetArbol
        {
            get
            {
                return arbol;
            }
            set
            {
                arbol = value;
            }
        }
    }
}
