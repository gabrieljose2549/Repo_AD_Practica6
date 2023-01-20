using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using JugadorPartido;

namespace ChampionsLeage
{
    public partial class frmChampions : Form
    {
        Equipo Chocolate;
        Equipo ManjarLeche;
        Partido PartidoA;
        int golA;
        int golB;

        public frmChampions()
        {
            InitializeComponent();
        }

        private void frmChampions_Load(object sender, EventArgs e)
        {
            Chocolate = new Equipo();
            ManjarLeche = new Equipo();
            Jugador Messi = new Jugador(5, 5, 1);
            Jugador Ronaldo = new Jugador(4, 4, 2);
            Jugador Pique = new Jugador(1, 1, 3);
            Jugador Valencia = new Jugador(10, 10, 4);
            Chocolate.AgregarJugador(Messi);
            Chocolate.AgregarJugador(Ronaldo);
            ManjarLeche.AgregarJugador(Pique);
            ManjarLeche.AgregarJugador(Valencia);
            PartidoA = new Partido(Chocolate, ManjarLeche, 2, 3);
            pbJugador.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPartido.Image = Properties.Resources.Partido;
        }

        private void rbEquipo1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEquipo1.Checked)
            {
                Equipo.Presupuesto = 2000;
                lblPresupuesto.Text = $"El presupuesto máximo es: {Equipo.Presupuesto}";
                lblAsistenciasEquipo.Text = $"Las Asistencias Totales son: {Chocolate.AsistenciasTotalesEquipo()}";
                nudEquipo1.Value = PartidoA.GolesEquipo1;
                nudEquipo2.Value = PartidoA.GolesEquipo2;
                RecargarJugadores(1);
            }
        }

        private void rbEquipo2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEquipo2.Checked)
            {
                Equipo.Presupuesto = 1000;
                lblPresupuesto.Text = $"El presupuesto máximo es: {Equipo.Presupuesto}";
                lblAsistenciasEquipo.Text = $"Las Asistencias Totales son: {ManjarLeche.AsistenciasTotalesEquipo()}";
                nudEquipo1.Value = PartidoA.GolesEquipo1;
                nudEquipo2.Value = PartidoA.GolesEquipo2;
                RecargarJugadores(2);
            }
        }

        public void RecargarJugadores(int a)
        {
            switch (a)
            {
                case 1:
                    lbJugadores.DataSource = null;
                    lbJugadores.DataSource = Chocolate.getListaJugador();
                    break;
                case 2:
                    lbJugadores.DataSource = null;
                    lbJugadores.DataSource = ManjarLeche.getListaJugador();
                    break;
            }
        }

        public void CambiarInformacionJugador(int a)
        {
            switch(a)
            {
                case 0:
                    pbJugador.Image = Properties.Resources.Messi;
                    break;
                case 1:
                    pbJugador.Image = Properties.Resources.Ronaldo;
                    break;
                case 2:
                    pbJugador.Image = Properties.Resources.Traidor;
                    break;
                case 3:
                    pbJugador.Image = Properties.Resources.Valencia;
                    break;
            }
        }

        public void ActualizarCampos(Jugador j, Equipo e)
        {
            txtIdJugador.Text = $"{j.IdJugador}";
            txtPuntos.Text = $"{j.Puntos}";
            txtAsistencias.Text = $"{j.Asistencias}";
            txtSueldo.Text = $"{e.SueldoXjugador()}";
        }

        private void lbJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbJugadores.SelectedItem != null)
            {
                if (rbEquipo1.Checked)
                {
                    CambiarInformacionJugador(lbJugadores.SelectedIndex);
                    Jugador jp = (Jugador)lbJugadores.SelectedItem;
                    ActualizarCampos(jp, Chocolate);

                }
                if (rbEquipo2.Checked)
                {
                    CambiarInformacionJugador(lbJugadores.SelectedIndex + 2);
                    Jugador jp = (Jugador)lbJugadores.SelectedItem;
                    ActualizarCampos(jp, ManjarLeche);
                }
            }
        }

        private void chkAumentarGoles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAumentarGoles.Checked)
            {
                golA = PartidoA.GolesEquipo1;
                golB = PartidoA.GolesEquipo2;
                nudEquipo1.Enabled = true;
                nudEquipo2.Enabled = true;
                nudEquipo1.Value = PartidoA.GolesEquipo1;
                nudEquipo2.Value = PartidoA.GolesEquipo2;
            }
            else
            {
                nudEquipo1.Enabled = false;
                nudEquipo2.Enabled = false;
            }
        }

        private void nudEquipo1_ValueChanged(object sender, EventArgs e)
        {
            // Restringido a que cuando anota un gol, no se pueda disminuir, únicamente incrementar
            if (nudEquipo1.Value > golA && nudEquipo1.Value >= 0)
            {
                PartidoA.GolesEquipo1 = (int)nudEquipo1.Value;
                golA = (int)nudEquipo1.Value;
            }
            else if (nudEquipo1.Value != 0)
            {
                MessageBox.Show("No se admite disminuir el puntaje", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudEquipo1.Value = PartidoA.GolesEquipo1;
            }
        }

        private void nudEquipo2_ValueChanged(object sender, EventArgs e)
        {
            // Restringido a que cuando anota un gol, no se pueda disminuir, únicamente incrementar
            if (nudEquipo2.Value > golB && nudEquipo2.Value >= 0)
            {
                PartidoA.GolesEquipo2 = (int)nudEquipo2.Value;
                golB = (int)nudEquipo2.Value;
            }
            else
            {
                MessageBox.Show("No se admite disminuir el puntaje", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudEquipo2.Value = PartidoA.GolesEquipo2;
            }
        }

        private void btnEquipoGanador_Click(object sender, EventArgs e)
        {
            if (PartidoA.GolesEquipo1 > PartidoA.GolesEquipo2)
            {
                MessageBox.Show($"Felicidades Equipo Chocolate, han ganado {PartidoA.GolesEquipo1} - {PartidoA.GolesEquipo2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (PartidoA.GolesEquipo1 < PartidoA.GolesEquipo2)
            {
                MessageBox.Show($"Felicidades Equipo Manjar de Leche, han ganado {PartidoA.GolesEquipo2} - {PartidoA.GolesEquipo1}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"Han empatado equipo Chocolate y Manjar de Leche, {PartidoA.GolesEquipo1} - {PartidoA.GolesEquipo2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
