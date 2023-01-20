using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JugadorPartido
{
    public class Partido
    {
        private Equipo equipo1;
        private Equipo equipo2;
        private int golesEquipo1;
        private int golesEquipo2;

        public Equipo Equipo1 { get => equipo1; set => equipo1 = value; }
        public Equipo Equipo2 { get => equipo2; set => equipo2 = value; }
        public int GolesEquipo1 { get => golesEquipo1; set => golesEquipo1 = value; }
        public int GolesEquipo2 { get => golesEquipo2; set => golesEquipo2 = value; }

        public Partido(Equipo equipo1, Equipo equipo2, int golesEquipo1, int golesEquipo2)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
            this.golesEquipo1 = golesEquipo1;
            this.golesEquipo2 = golesEquipo2;
        }

        /// <summary>
        /// Aquel equipo con mas goles en el partido
        /// </summary>
        public Equipo EquipoGanador()
        {
            if (golesEquipo1 > golesEquipo2) { return equipo1; } else { return equipo2; }
        }

        /// <summary>
        /// Suma las asistencias de todos los jugadores del partido
        /// </summary>
        public int AsistenciasXPartido()
        {
            int asistencia = equipo1.AsistenciasTotalesEquipo() + equipo2.AsistenciasTotalesEquipo();
            return asistencia;
        }
    }
}