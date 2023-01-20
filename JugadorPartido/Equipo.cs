using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JugadorPartido
{
    public class Equipo
    {
        private ArrayList listaJ;
        /// <summary>
        /// Atributo estático
        /// </summary>
        private static double presupuesto;

        public Equipo()
        {
            listaJ = new ArrayList();
        }

        public static double Presupuesto { get => presupuesto; set => presupuesto = value; }

        /// <summary>
        /// Busca un jugador por vId y retorna el Jugador
        /// </summary>
        public Jugador BuscarJugadorXId(int vidJugador)
        {
            foreach (Jugador j in listaJ)
            {
                if (j.IdJugador == vidJugador)
                {
                    return j;
                }
            }
            return null;
        }

        /// <summary>
        /// Divide el presupuesto para el número de jugadores y retorna el valor
        /// </summary>
        public double SueldoXjugador()
        {
            double sueldo = presupuesto / listaJ.Count;
            return sueldo;
        }

        /// <summary>
        /// Suma las asistencias de todos los jugadores de la lista y retorna el valor
        /// </summary>
        public int AsistenciasTotalesEquipo()
        {
            int n = 0;
            foreach(Jugador j in listaJ)
            {
                n = n + j.Asistencias;
            }
            return n;
        }

        /// <summary>
        /// Agrega un jugador a la lista
        /// </summary>
        public void AgregarJugador(Jugador Jugador)
        {
            listaJ.Add(Jugador);
        }

        /// <summary>
        /// Retorna la Lista
        /// </summary>
        public ArrayList getListaJugador()
        {
            return listaJ;
        }

        /// <summary>
        /// Setea la lista
        /// </summary>
        public void setListaJugador(ArrayList vLista)
        {
            listaJ = vLista;
        }
    }
}