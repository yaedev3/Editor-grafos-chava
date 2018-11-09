﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Editor_grafos
{
    public class Grafo
    {
        private List<Nodo> nodos;
        private List<Arista> aristas;
        public int tipoArista, nombreNodo, nombreArista;

        public Grafo()
        {
            nodos = new List<Nodo>();
            aristas = new List<Arista>();
            tipoArista = -1;
            nombreNodo = 65;
            nombreArista = 1;
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
            nombreArista = 1;
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

            foreach (Nodo nodo in nodos)
                if (nodo.EstaDentro(x, y))
                {
                    respuesta = true;
                    break;
                }

            return respuesta;
        }

        //agrega una nueva arista al grafo
        public void NuevaArista(Nodo origen, Nodo destino)
        {
            aristas.Add(new Arista(origen, destino, nombreArista));

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
                if (nodos[i].GetNombre.Equals(nodo.GetNombre))
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

        //genera la matriz de adyacencia del grafo sin encabezados
        public List<List<string>> MatrizAdyacenciaSimple()
        {
            List<List<string>> matriz = new List<List<string>>();
            foreach (Nodo nodo in nodos)
            {
                matriz.Add(new List<string>());
                for (int i = 0; i < nodos.Count; i++)
                    matriz[matriz.Count - 1].Add(nodo.BuscaRelacion(nodos[i].GetNombre));
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

        public List<List<string>> ListaGrados()
        {
            List<List<string>> matriz = new List<List<string>>();

            foreach (Nodo nodo in nodos)
            {
                matriz.Add(new List<string>());
                matriz[matriz.Count - 1].Add(nodo.GetNombre);
                matriz[matriz.Count - 1].Add(nodo.GetRelaciones.Count.ToString());
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
                    if (nodo.Igual(arista.GetOrigen) || nodo.Igual(arista.GetDestino))
                        matriz[matriz.Count - 1].Add("1");
                    else matriz[matriz.Count - 1].Add("0");
            }

            return matriz;
        }

        //genera la matriz de adyacencia del grafo sin encabezados
        public List<List<string>> MatrizIncidenciaSimple()
        {
            List<List<string>> matriz = new List<List<string>>();

            foreach (Nodo nodo in nodos)
            {
                matriz.Add(new List<string>());
                foreach (Arista arista in aristas)
                    if (nodo.GetNombre.Equals(arista.GetOrigen.GetNombre) || nodo.GetNombre.Equals(arista.GetDestino.GetNombre))
                        matriz[matriz.Count - 1].Add("1");
                    else matriz[matriz.Count - 1].Add("0");
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

        //Verifica si dos grafos son isomorficos.
        public bool isomorfismo(Grafo grafo2, ref string resultado, string nombreGrafo1, string nombreGrafo2)
        {
            bool respuesta = false;
            List<int> biyeccion1, biyeccion2;

            resultado = "No es isomorfo porque los grados de nodos y aristas no son iguales.\n";
            resultado += nombreGrafo1 + ": numero de nodos " + nodos.Count + " y numero de aristas " + aristas.Count;
            resultado += "\n" + nombreGrafo2 + ": numero nodos " + grafo2.GetNodos.Count + " y numero de aristas " + grafo2.GetAristas.Count;
            resultado += "\nLa matriz de adyacencia de " + nombreGrafo1 + " es:\n" + ImprimeMatriz(MatrizAdyacenciaSimple());
            resultado += "La matriz de adyacencia de " + nombreGrafo2 + " es:\n" + ImprimeMatriz(grafo2.MatrizAdyacenciaSimple());

            if (aristas.Count == grafo2.GetAristas.Count && nodos.Count == grafo2.GetNodos.Count)
            {
                biyeccion1 = BiyeccionDeNodos();
                biyeccion2 = grafo2.BiyeccionDeNodos();

                if(ComparaArreglos(biyeccion1, biyeccion2))
                {
                    resultado = "El grafo es isomorfo\n";
                    resultado += nombreGrafo1 + ": numero de nodos " + nodos.Count + " y numero de aristas " + aristas.Count;
                    resultado += "\n" + nombreGrafo2 + ": numero nodos " + grafo2.GetNodos.Count + " y numero de aristas " + grafo2.GetAristas.Count;
                    resultado += "\nLa matriz de adyacencia de " + nombreGrafo1 + " es:\n" + ImprimeMatriz(MatrizAdyacenciaSimple());
                    resultado += "La matriz de adyacencia de " + nombreGrafo2 + " es:\n" + ImprimeMatriz(grafo2.MatrizAdyacenciaSimple());
                    resultado += "La matriz de resultante es:\n" + ImprimeMatriz(MatrizAdyacenciaSimple());
                    respuesta = true;
                }
            }

            return respuesta;
        }

        //Saca la biyeccion de los nodos.
        public List<int> BiyeccionDeNodos()
        {
            List<int> biyeccion = new List<int>();

            foreach (Nodo nodo in nodos)
                biyeccion.Add(nodo.GetRelaciones.Count);

            return biyeccion;
        }

        //Compara dos arreglos en busca de conincidencias
        private bool ComparaArreglos(List<int> arreglo1, List<int> arreglo2)
        {
            bool respuesta = true;
            List<int> comparaciones = new List<int>();

            for (int i = 0; i < arreglo1.Count; i++)
                for (int j = 0; j < arreglo2.Count; j++)
                    if (arreglo1[i] == arreglo2[j] && !comparaciones.Contains(j))
                    {
                        comparaciones.Add(j);
                        break;
                    }

            if (comparaciones.Count != arreglo1.Count)
                respuesta = false;

            return respuesta;
        }

        //Convierte una matriz a texto.
        private string ImprimeMatriz(List<List<string>> V)
        {
            string matriz = "";

            for (int i = 0; i < V.Count; i++)
            {
                for (int j = 0; j < V[i].Count; j++)
                    matriz += V[i][j] + " ";
                matriz += "\n";
            }

            return matriz;
        }

        //Hace el algoritmo de kuratowski con el grafo K5.
        public string Kuratowsky()
        {
            Grafo grafo2 = new Grafo();
            string resultado = "";
            string corolarios = Corolario();

            if (corolarios.Contains("No es plano"))
                corolarios = "El grafo NO es plano.\nSe comparo con K5 y este fue el resultado:\n";
            else
                corolarios = "El grafo ES plano.\nSe comparo con K5 y este fue el resultado:\n";

            grafo2.KN(5, 0, 0, 0, 0);
            isomorfismo(grafo2, ref resultado, "Grafo uno", "K5");

            return corolarios + resultado;
        }

        //Hace el algoritmo de kuratowski con el grafo K33.
        public string KuratowskyK33()
        {
            Grafo grafo2 = new Grafo();
            string resultado = "";
            string corolarios = Corolario();

            if (corolarios.Contains("No es plano"))
                corolarios = "El grafo NO es plano.\nSe comparo con K33 y este fue el resultado:\n";
            else
                corolarios = "El grafo ES plano.\nSe comparo con K33 y este fue el resultado:\n";

            grafo2.K33();
            isomorfismo(grafo2, ref resultado, "Grafo uno", "K33");

            return corolarios + resultado;
        }

        //crea un grafo k33
        public void K33()
        {
            Clear();

            for (int i = 0; i < 6; i++)
                NuevoNodo(0, 0);

            for (int i = 0; i < 3; i++)
            {
                NuevaArista(nodos[i], nodos[3]);
                NuevaArista(nodos[i], nodos[4]);
                NuevaArista(nodos[i], nodos[5]);
            }
        }

        //Verifica si un grafo es plano según sus corolarios.
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

                        NodosVisitados();

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

        //Cambia todas las banderas de los nodos a no visitados.
        public void NodosVisitados()
        {
            foreach (Nodo nodo in nodos)
                nodo.GetVisitado = false;
        }

        //Cambia todas las banderas de las aristas a no visitados.
        public void AristasVisitadas()
        {
            foreach (Arista arista in aristas)
                arista.GetVisitado = false;
        }

        //Busca ciclos dentro del grafo.
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

        //Calcula los caminos y circuitos de euler, regresa una cadena con el resultado.
        public string Euler()
        {
            string euler, mensaje;
            int gradoNodos;
            bool completo;

            euler = "Circuito\n";
            gradoNodos = 0;
            completo = false;

            //Hace el conteo de relaciones de grado par en las relaciones de los nodos.
            foreach (Nodo nodo in nodos)
                if (nodo.GetRelaciones.Count != 0 && nodo.GetRelaciones.Count % 2 == 0)
                    gradoNodos++;

            //Verifica si todas las relaciones son pares.
            if (gradoNodos == nodos.Count && nodos.Count != 0)
                foreach (Nodo nodo in nodos)
                {
                    mensaje = "";
                    mensaje = AlgoritmoEuler(nodo, mensaje, aristas.Count);
                    completo = CaminoCompleto(mensaje);
                    if (completo)
                    {
                        euler += OrdenarCircuito(mensaje.Remove(mensaje.Length - 2));
                        break;
                    }
                    AristasVisitadas();
                }
        
            if (completo)
                return euler;
            else
            {
                euler = "Camino:\n";
                gradoNodos = 0;
            }

            //Hace el conteo de relaciones de grado impar en las relaciones de los nodos.
            foreach (Nodo nodo in nodos)
                if (nodo.GetRelaciones.Count != 0 && nodo.GetRelaciones.Count % 2 == 1)
                    gradoNodos++;

            //Verifica si dos relaciones son impares.
            if (gradoNodos == 2)
            {
                foreach (Nodo nodo in nodos)
                {
                    mensaje = "";
                    mensaje = AlgoritmoEuler(nodo, mensaje, aristas.Count);
                    completo = CaminoCompleto(mensaje);
                    if (completo)
                    {
                        euler += mensaje.Remove(mensaje.Length - 2);
                        break;
                    }
                    AristasVisitadas();
                }
            }

            if (!completo)
                euler = "Circuito:\nNinguno\nCamino:\nNinguno.";

            return euler;
        }

        //Algoritmo para el camino y circuito de euler de forma recursiva.
        private string AlgoritmoEuler(Nodo inicio, string resultado, int tam)
        {
            if (inicio != null)
            {
                resultado += inicio.GetNombre + "->";
                if (tam > 0)
                    resultado = AlgoritmoEuler(SiguienteNodo(inicio), resultado, AristasSinVisitar());
            }
            return resultado;
        }

        //Obtiene el siguiente nodo apartir de un nodo de inicio.
        private Nodo SiguienteNodo(Nodo nodo)
        {
            int indice = -1;

            foreach (Arista arista in aristas)
                if (arista.GetOrigen.Igual(nodo) && !arista.GetVisitado)
                {
                    indice = nodos.IndexOf(arista.GetDestino);
                    arista.GetVisitado = true;
                    break;
                }
                else if (arista.GetDestino.Igual(nodo) && !arista.GetVisitado)
                {
                    indice = nodos.IndexOf(arista.GetOrigen);
                    arista.GetVisitado = true;
                    break;
                }

            if (indice != -1)
                return nodos[indice];
            else
                return null;
        }

        //Regresa cuantas aristas aun no han sido visitadas.
        private int AristasSinVisitar()
        {
            int resultado = 0;

            foreach (Arista arista in aristas)
                if (!arista.GetVisitado)
                    resultado++;

            return resultado;
        }

        //Verifica si se hizo correctamente el algoritmo.
        private bool CaminoCompleto(string camino)
        {
            List<string> lista = new List<string>(camino.Remove(camino.Length - 2).Replace("->", "♣").Split('♣'));

            return lista.Count == aristas.Count + 1;
        }

        //Cambia el orden del circuito para que siempre empiece con el primer nodo.
        private string OrdenarCircuito(string circuito)
        {
            string nuevoCircuito;
            List<string> lista;
            int indice;

            lista = new List<string>(circuito.Replace("->", "♣").Split('♣'));
            indice = lista.IndexOf(nodos[0].GetNombre);

            if (indice == 0)
                nuevoCircuito = circuito;
            else
            {
                nuevoCircuito = "";
                for (int i = 0; i < indice; i++)
                    lista.Add(lista[i]);

                lista.RemoveRange(0, indice);
                lista.Add(nodos[0].GetNombre);
                for (int i = 0; i < lista.Count; i++)
                    nuevoCircuito += lista[i] + "->";
                nuevoCircuito = nuevoCircuito.Remove(nuevoCircuito.Length - 2);
            }

            return nuevoCircuito;
        }

        //calcula el numero cromatico de cada nodo.
        public string NodosColoreados()
        {
            string mensaje = "Colores\n";
            int grupo = 0;

            foreach (Nodo nodo in nodos)
                nodo.GetGrupo = 0;

            foreach (Nodo nodo in nodos)
                if (!nodo.GetVisitado)
                    Corolea(nodo);

            foreach (Nodo nodo in nodos)
                if (grupo < nodo.GetGrupo)
                    grupo = nodo.GetGrupo;

            grupo++;
            NodosVisitados();

            for (int i = 1; i < grupo; i++)
            {
                mensaje += i.ToString() + " {";
                for (int j = 0; j < nodos.Count; j++)
                    if (nodos[j].GetGrupo == i)
                    {
                        mensaje += nodos[j].GetNombre + ", ";
                    }
                mensaje = mensaje.Remove(mensaje.Length - 2, 2);
                mensaje += "}\n";
            }
            return mensaje;
        }

        //define que color representa cada nodo.
        private void Corolea(Nodo nodo)
        {
            nodo.GetVisitado = true;
            nodo.GetGrupo = MaximoNumero(nodo.GetRelaciones);

            foreach(Nodo relacion in nodo.GetRelaciones)
                if (!relacion.GetVisitado)
                    Corolea(relacion);
        }

        //saca el siguiente color.
        private int MaximoNumero(List<Nodo> listaNodos)
        {
            List<int> numerosValidos = new List<int>();

            for (int i = 0; i < nodos.Count; i++)
                numerosValidos.Add(i + 1);

            for (int i = 0; i < listaNodos.Count; i++)
                for (int j = 0; j < numerosValidos.Count; j++)
                    if (numerosValidos[j] == listaNodos[i].GetGrupo)
                    {
                        numerosValidos.Remove(numerosValidos[j]);
                        j--;
                    }

            return numerosValidos[0];
        }

        //calcula el algortimo de floyd
        public string floyd()
        {
            List<List<int>> matriz = new List<List<int>>();
            List<List<int>> p = new List<List<int>>();
            List<List<List<string>>> simulacion = new List<List<List<string>>>();
            int limite = 1000;
            string mensaje = "";

            for (int i = 0; i < nodos.Count; i++)
            {
                matriz.Add(new List<int>());
                simulacion.Add(new List<List<string>>());
                p.Add(new List<int>());
                for (int j = 0; j < nodos.Count; j++)
                {
                    p[p.Count - 1].Add(0);
                    if (nodos[i].GetRelaciones.Contains(nodos[j]))
                    {
                        matriz[matriz.Count - 1].Add(GetPesoAristas(nodos[i], nodos[j]));
                        simulacion[simulacion.Count - 1].Add(new List<string>());
                        simulacion[simulacion.Count - 1][simulacion[simulacion.Count - 1].Count - 1].Add(nodos[i].GetNombre);
                        simulacion[simulacion.Count - 1][simulacion[simulacion.Count - 1].Count - 1].Add(nodos[j].GetNombre);
                    }
                    else
                    {
                        matriz[matriz.Count - 1].Add(limite);
                        simulacion[simulacion.Count - 1].Add(new List<string>());
                        simulacion[simulacion.Count - 1][simulacion[simulacion.Count - 1].Count - 1].Add(nodos[i].GetNombre);
                    }
                }
            }

            for (int i = 0; i < nodos.Count; i++)
                matriz[i][i] = 0;

            mensaje += "Matriz inicial:\n   ";
            mensaje += GeneraMatriz(matriz, limite);

            for (int k = 0; k < nodos.Count; k++)
                for (int i = 0; i < nodos.Count; i++)
                    for (int j = 0; j < nodos.Count; j++)
                        if (matriz[i][k] + matriz[k][j] < matriz[i][j])
                        {
                            matriz[i][j] = matriz[i][k] + matriz[k][j];
                            p[i][j] = k;
                            simulacion[i][j] = GeneraLista(simulacion[i][k], simulacion[k][j]);
                        }

            mensaje += "Lista de caminos mas cortos:\n";
            mensaje += CreaListaCaminos(simulacion);

            mensaje += "Matriz P:\n   ";
            mensaje += GeneraMatriz(p, limite);

            mensaje += "Matriz final:\n   ";
            mensaje += GeneraMatriz(matriz, limite);

            return mensaje;
        }

        //Crea la lista de caminos mas cortos
        private string CreaListaCaminos(List<List<List<string>>> simulacion)
        {
            string mensaje = "";

            foreach (List<List<string>> lista1 in simulacion)//se recorren todas los nodos
                foreach (List<string> lista2 in lista1)//se recorren las adyacencias
                {
                    mensaje += GetCamino(lista2);
                }
            return mensaje;
        }

        private string GetCamino(List<string> caminos)
        {
            string mensaje = "";

            if (caminos.Count > 1)
            {
                foreach (string cadena in caminos)
                    mensaje += cadena + "->";

                mensaje = mensaje.Remove(mensaje.Length - 2) + "\n";
            }
            return mensaje;
        }

        //concatena la matriz en una cadena
        private string GeneraMatriz(List<List<int>> matriz, int limite)
        {
            string mensaje = "";

            foreach (Nodo nodo in nodos)
                mensaje += nodo.GetNombre + " ";

            mensaje += "\n";

            for (int i = 0; i < matriz.Count; i++)
            {
                mensaje += nodos[i].GetNombre + " ";
                for (int j = 0; j < matriz[i].Count; j++)
                    mensaje += matriz[i][j].ToString().Replace(limite.ToString(), "∞") + " ";
                mensaje += "\n";
            }

            return mensaje;
        }

        //devuelve el peso de la arista segun sus nodos.
        private int GetPesoAristas(Nodo a, Nodo b)
        {
            int aux = -1;

            foreach (Arista arista in aristas)
            {
                if (arista.GetOrigen.Igual(a) && arista.GetDestino.Igual(b))
                {
                    aux = arista.GetPeso;
                    break;
                }
                else if (arista.GetOrigen.Igual(b) && arista.GetDestino.Igual(a))
                {
                    aux = arista.GetPeso;
                    break;
                }
            }
            return aux;
        }

        //devuelve el indice de la arista
        private int GetNumeroArista(Nodo a, Nodo b)
        {
            int aux = -1;

            foreach (Arista arista in aristas)
            {
                if (arista.GetOrigen.Igual(a) && arista.GetDestino.Igual(b))
                {
                    aux = aristas.IndexOf(arista);
                    break;
                }
                else if (arista.GetOrigen.Igual(b) && arista.GetDestino.Igual(a))
                {
                    aux = aristas.IndexOf(arista);
                    break;
                }
            }
            return aux;
        }

        //genera la lista de caminos mas cortos
        private List<string> GeneraLista(List<string> a, List<string> b)
        {
            List<string> nuevaLista = new List<string>();

            foreach (string aux in a)
                if (!nuevaLista.Contains(aux))
                    nuevaLista.Add(aux);

            foreach (string aux in b)
                if (!nuevaLista.Contains(aux))
                    nuevaLista.Add(aux);

            return nuevaLista;
        }
    }
}
