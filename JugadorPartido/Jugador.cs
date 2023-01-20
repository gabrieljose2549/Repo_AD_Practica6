using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JugadorPartido
{
    public class Jugador
    {
        private int asistencias;
        private int puntos;
        private int idJugador;

        public Jugador(int asistencias, int puntos, int idJugador)
        {
            this.asistencias = asistencias;
            this.puntos = puntos;
            this.idJugador = idJugador;
        }

        public int Asistencias { get => asistencias; set => asistencias = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int IdJugador { get => idJugador; set => idJugador = value; }

        /// <summary>
        /// Suma vPuntosExtras al atributo puntos
        /// </summary>
        public int sumarPuntosExtras(int vPuntosExtras)
        {
            return asistencias = asistencias + puntos;
        }

        /// <summary>
        /// Método Object y retorna: "Mi id es: XX y mis asistencias son: XXX"
        /// </summary>
        public override string ToString()
        {
            return $"Mi id es: {idJugador} y mis asistencias son {asistencias}";
        }
    }
}