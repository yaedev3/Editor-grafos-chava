using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Editor_grafos
{
    class Grafo
    {
        private List<Nodo> nodos;
        private List<Arista> aristas;
        private int tipoArista, nombreNodo, nombreArista;

        public Grafo()
        {
            nodos = new List<Nodo>();
            aristas = new List<Arista>();
            tipoArista = -1;
            nombreNodo = 65;
            nombreArista = 65;
        }

        //regresa los nodos del grafo
        public List<Nodo> GetNodos
        {
            get
            {
                return nodos;
            }
        }

        //regresa las aristas del grafo
        public List<Arista> GetAristas
        {
            get
            {
                return aristas;
            }
        }

        //limpia el grafo
        public void Clear()
        {
            nodos.Clear();
            aristas.Clear();
            tipoArista = -1;
            nombreNodo = 65;
            nombreArista = 65;
        }

        //agrega un nuevo nodo al grafo
        public void NuevoNodo(int x, int y)
        {
            if (nombreNodo > 90 && nombreNodo < 97)
                nombreNodo = 97;
            nodos.Add(new Nodo(x, y, (char)nombreNodo));
            nombreNodo++;
        }

        //verifica si el cursor esta dentro de algun nodo del grafo
        public bool EstaDentro(int x, int y)
        {
            bool respuesta = false;

            foreach(Nodo nodo in nodos)
                if(nodo.EstaDentro(x,y))
                {
                    respuesta = true;
                    break;
                }

            return respuesta;
        }

        //agrega una nueva arista al grafo
        public void NuevaArista(Nodo origen, Nodo destino)
        {
            if (nombreArista > 90 && nombreArista < 97)
                nombreArista = 97;
            aristas.Add(new Arista(origen, destino, (char)nombreArista));

            if (tipoArista == 0)//dirigido
                AgregarRelacion(origen, destino);
            else //No dirigido
            {
                AgregarRelacion(origen, destino);
                AgregarRelacion(destino, origen);
            }

            nombreArista++;
        }

        //regresa el tipo de arista que tiene el grafo
        //dirigida = 0
        //no dirigida = 1
        public int GetTipoArista
        {
            get
            {
                return tipoArista;
            }
            set
            {
                tipoArista = value;
            }
        }

        //regresa el nodo seleccionado por el cursor
        public Nodo GetNodoSeleccionado(int x, int y)
        {
            int indice = -1;

            for (int i = 0; i < nodos.Count; i++)
                if (nodos[i].EstaDentro(x, y))
                {
                    indice = i;
                    break;
                }

            return nodos[indice];
        }

        //agrega una nueva relacion a un nodo seleccionado
        public void AgregarRelacion(Nodo nodo, Nodo relacion)
        {
            for (int i = 0; i < nodos.Count; i++)
                if (nodos[i].Igual(nodo))
                {
                    nodos[i].AgregarRelacion(relacion);
                    break;
                }
        }

        //genera la matriz de adyacencia del grafo
        public List<List<string>> MatrizAdyacencia()
        {
            List<List<string>> matriz = new List<List<string>>();

            matriz.Add(new List<string>());
            matriz[0].Add("");
            foreach (Nodo nodo in nodos)
                matriz[matriz.Count - 1].Add(nodo.GetNombre);

            foreach (Nodo nodo in nodos)
            {
                matriz.Add(new List<string>());
                matriz[matriz.Count - 1].Add(nodo.GetNombre);
                for (int i = 1; i < matriz[0].Count; i++)
                    matriz[matriz.Count - 1].Add(nodo.BuscaRelacion(matriz[0][i]));
            }
            
            return matriz;
        }

        //genera la lista de adyacencia del grafo
        public List<List<string>> ListaAdyacencia()
        {
            List<List<string>> matriz = new List<List<string>>();

            matriz.Add(new List<string>());
            matriz[0].Add("");

            foreach (Nodo nodo in nodos)
                matriz[0].Add("");
            
            foreach (Nodo nodo in nodos)
            {
                matriz.Add(new List<string>());
                matriz[matriz.Count - 1].Add(nodo.GetNombre);
                for (int i = 0; i < nodos.Count; i++)
                    if (i < nodo.GetRelaciones.Count)
                        matriz[matriz.Count - 1].Add(nodo.GetRelaciones[i].GetNombre);
                    else matriz[matriz.Count - 1].Add("");
            }

            return matriz;
        }

        //genera grados de los nodos
        public List<List<string>> GradosDirigido()
        {
            List<List<string>> matriz = new List<List<string>>();
            int busqueda;

            matriz.Add(new List<string>());
            matriz[0].Add("Nodo");
            matriz[0].Add("Entrada");
            matriz[0].Add("Salida");

            foreach (Nodo nodo in nodos)
            {
                busqueda = 0;
                matriz.Add(new List<string>());
                matriz[matriz.Count - 1].Add(nodo.GetNombre);

                foreach (Nodo nodo2 in nodos)
                    if (!nodo2.Igual(nodo) && nodo2.BuscaRelacion(nodo.GetNombre).Equals("1"))
                        busqueda++;
         
                matriz[matriz.Count - 1].Add(busqueda.ToString());
                matriz[matriz.Count - 1].Add(nodo.GetRelaciones.Count.ToString());
            }

            return matriz;
        }

        //genera grados de los nodos
        public List<List<string>> GradosNoDirigido()
        {
            List<List<string>> matriz = new List<List<string>>();

            matriz.Add(new List<string>());
            matriz[0].Add("Nodo");
            matriz[0].Add("Grados");

            foreach (Nodo nodo in nodos)
            {
                matriz.Add(new List<string>());
                matriz[matriz.Count - 1].Add(nodo.GetNombre);
                matriz[matriz.Count - 1].Add(nodo.GetRelaciones.Count.ToString());
            }

            return matriz;
        }

        //genera la matriz de adyacencia del grafo
        public List<List<string>> MatrizIncidencia()
        {
            List<List<string>> matriz = new List<List<string>>();

            matriz.Add(new List<string>());
            matriz[0].Add("");

            foreach (Arista arista in aristas)
                matriz[0].Add(arista.GetNombre);

            foreach (Nodo nodo in nodos)
            {
                matriz.Add(new List<string>());
                matriz[matriz.Count - 1].Add(nodo.GetNombre);
                foreach (Arista arista in aristas)
                    foreach (Nodo relacion in nodo.GetRelaciones)
                        if (relacion.Igual(arista.GetOrigen) || relacion.Igual(arista.GetDestino))
                        {
                            matriz[matriz.Count - 1].Add("1");
                            break;
                        }
            }

            return matriz;
        }

        //genera el grafo especial cn apartir de el numero de nodos y el tamaño de la pantalla
        public void KN(int N, int arriba, int abajo, int derecha, int izquierda)
        {
            int tamano, posicionX, posicionY, alto, ancho, auxiliar, radio;
            double angulo;
            Point centro;

            Clear();
            tamano = 30;

            angulo = 360.0 / N;

            alto = (abajo + arriba) / 2;
            ancho = (derecha + izquierda) / 2;

            if (alto > ancho)
                auxiliar = ancho;
            else auxiliar = alto;

            centro = new Point(ancho, alto);
            radio = auxiliar * 3 / 4;

            for (int i = 0; i < N; i++)
            {
                posicionY = (int)(radio * Math.Sin(Math.PI * (angulo * i) / 180.0));
                posicionX = (int)(radio * Math.Cos(Math.PI * (angulo * i) / 180.0));
                NuevoNodo(centro.X + posicionX - (tamano / 2), centro.Y + posicionY - (tamano / 2));
            }

            for (int i = 0; i < nodos.Count; i++)
                for (int j = i + 1; j < nodos.Count; j++)
                    NuevaArista(nodos[i], nodos[j]);
        }

        //genera el grafo especial kn apartir de el numero de nodos y el tamaño de la pantalla
        public void CN(int N, int arriba, int abajo, int derecha, int izquierda)
        {
            int tamano, posicionX, posicionY, alto, ancho, auxiliar, radio;
            double angulo;
            Point centro;

            Clear();
            tamano = 30;

            angulo = 360.0 / N;

            alto = (abajo + arriba) / 2;
            ancho = (derecha + izquierda) / 2;

            if (alto > ancho)
                auxiliar = ancho;
            else auxiliar = alto;

            centro = new Point(ancho, alto);
            radio = auxiliar * 3 / 4;

            for (int i = 0; i < N; i++)
            {
                posicionY = (int)(radio * Math.Sin(Math.PI * (angulo * i) / 180.0));
                posicionX = (int)(radio * Math.Cos(Math.PI * (angulo * i) / 180.0));
                NuevoNodo(centro.X + posicionX - (tamano / 2), centro.Y + posicionY - (tamano / 2));
            }

            for (int i = 0; i < nodos.Count; i++)
                if (i < nodos.Count - 1)
                    NuevaArista(nodos[i], nodos[i + 1]);
                else
                    NuevaArista(nodos[i], nodos[0]);
        }

        //genera el grafo especial wn apartir de el numero de nodos y el tamaño de la pantalla
        public void WN(int N, int arriba, int abajo, int derecha, int izquierda)
        {
            int tamano, posicionX, posicionY, alto, ancho, auxiliar, radio;
            double angulo;
            Point centro;

            Clear();
            tamano = 30;

            angulo = 360.0 / N;

            alto = (abajo + arriba) / 2;
            ancho = (derecha + izquierda) / 2;

            if (alto > ancho)
                auxiliar = ancho;
            else auxiliar = alto;

            centro = new Point(ancho, alto);
            radio = auxiliar * 3 / 4;
            NuevoNodo(centro.X - (tamano / 2), centro.Y - (tamano / 2));

            for (int i = 0; i < N; i++)
            {
                posicionY = (int)(radio * Math.Sin(Math.PI * (angulo * i) / 180.0));
                posicionX = (int)(radio * Math.Cos(Math.PI * (angulo * i) / 180.0));
                NuevoNodo(centro.X + posicionX - (tamano / 2), centro.Y + posicionY - (tamano / 2));
            }
            for (int i = 1; i < nodos.Count; i++)
                NuevaArista(nodos[0], nodos[i]);

            for (int i = 0; i < nodos.Count; i++)
                if (i < nodos.Count - 1)
                    NuevaArista(nodos[i], nodos[i + 1]);
                else
                    NuevaArista(nodos[i], nodos[1]);
        }

        public string Corolario()
        {
            int E, V, resultado;
            string mensaje = "Corolario 1:\nE <= 3V - 6\n";

            E = aristas.Count;
            V = nodos.Count;
            resultado = 0;

            mensaje += string.Format("{0} <= 3({1}) - 6\n", E, V);
            mensaje += string.Format("{0} <= {1} - 6\n", E, 3 * V);
            mensaje += string.Format("{0} <= {1}\n", E, 3 * V - 6);

            if (E <= 3 * V - 6)
                mensaje += "Es plano!\n\n";
            else mensaje += "No es plano\n\n";
            mensaje += "Corolario 2:\nE <= 2V - 4\n";

            if (V > 2)
                for (int i = 0; i < nodos.Count; i++)
                {
                    for (int j = 0; j < nodos[i].GetRelaciones.Count; j++)
                    {
                        nodos[i].GetVisitado = true;
                        resultado = BuscaCiclos(nodos[i].GetRelaciones[j], 1, nodos[i]);

                        CambiaANoVisitados();

                        if (resultado > 0)
                            break;
                    }
                    if (resultado > 0)
                        break;
                }

            if (resultado == 0)
            {
                mensaje += string.Format("{0} <= 2({1}) - 4\n", E, V);
                mensaje += string.Format("{0} <= {1} - 4\n", E, 2 * V);
                mensaje += string.Format("{0} <= {1}\n", E, 2 * V - 4);
                if (E <= 2 * V - 4)
                    mensaje += "Es plano!\n";
                else mensaje += "No es plano\n";
            }
            else mensaje += "No se puede aplicar porque tiene circuito de longitud 3\n";

            return mensaje;
        }

        public void CambiaANoVisitados()
        {
            foreach (Nodo nodo in nodos)
                nodo.GetVisitado = false;
        }

        private int BuscaCiclos(Nodo siguiente, int tam, Nodo busqueda)
        {
            int f = 0;
            siguiente.GetVisitado = true;

            if (tam > 0)
            {
                for (int i = 0; i < siguiente.GetRelaciones.Count; i++)
                    if (!siguiente.GetRelaciones[i].GetVisitado)
                        f += BuscaCiclos(siguiente.GetRelaciones[i], tam - 1, busqueda);
            }
            else if (siguiente.GetRelaciones.Contains(busqueda))
                f = 1;

            return f;
        }
    }
}
