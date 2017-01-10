using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        private Negocio negocio = new Negocio();
        //  private negocio
        private int rafaga;
        private int puntuacion;
        private int contAciertos;
        private int contFallos;
        public FrmInicio()
        {

            InitializeComponent();
          

        }

        private void Btnjuego_Click(object sender, EventArgs e)
        {
            Button botonJuego  = (Button) sender;
            String respuesta;
            respuesta = negocio.ComprobarPregunta((int)botonJuego.Tag);
            if (respuesta == "") {
                contAciertos += 1;
                botonJuego.BackColor = Color.Green;
                rafaga += 1;
                puntuacion = puntuacion + 5 * rafaga;
                lblPuntos.Text = Convert.ToString( puntuacion);
                botonJuego.Enabled = false;
                if (contAciertos == 8) {
                    MessageBox.Show("has ganado", "Enorabuena");
                }
            }else {
                contFallos += 1;
                botonJuego.BackColor = Color.Red;
                lblJusti.Text = respuesta;
                puntuacion = puntuacion / 2;
                lblPuntos.Text = Convert.ToString(puntuacion);
                botonJuego.Enabled = false;
                if (contFallos == 4)
                {
                    MessageBox.Show("has perdido", "Loser");
                }
            }

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Btnjuego1.BackColor = DefaultBackColor;
            Btnjuego2.BackColor = DefaultBackColor;
            Btnjuego3.BackColor = DefaultBackColor;
            Btnjuego4.BackColor = DefaultBackColor;
            Btnjuego5.BackColor = DefaultBackColor;
            Btnjuego6.BackColor = DefaultBackColor;
            Btnjuego7.BackColor = DefaultBackColor;
            Btnjuego8.BackColor = DefaultBackColor;
            Btnjuego9.BackColor = DefaultBackColor;
            Btnjuego10.BackColor = DefaultBackColor;
            Btnjuego11.BackColor = DefaultBackColor;
            Btnjuego12.BackColor = DefaultBackColor;
            Btnjuego1.Enabled = true;
            Btnjuego2.Enabled = true;
            Btnjuego3.Enabled = true;
            Btnjuego4.Enabled = true;
            Btnjuego5.Enabled = true;
            Btnjuego6.Enabled = true;
            Btnjuego7.Enabled = true;
            Btnjuego8.Enabled = true;
            Btnjuego9.Enabled = true;
            Btnjuego10.Enabled = true;
            Btnjuego11.Enabled = true;
            Btnjuego12.Enabled = true;
            contFallos = 0;
            contAciertos = 0;
            // cargar pregunta
            PREGUNTA pregunta = negocio.returnQuestion(1);
            lblPregunta.Text = pregunta.DESCRIPCION;
            List<RESPUESTA> preguntas = new List<RESPUESTA>();
            preguntas = negocio.returnAnswersFromQuestion(pregunta.ID);
            Btnjuego1.Text = preguntas[0].DESCRIPCION;
            Btnjuego1.Tag = preguntas[0].ID;
            Btnjuego2.Text = preguntas[1].DESCRIPCION;
            Btnjuego2.Tag = preguntas[1].ID;
            Btnjuego3.Text = preguntas[2].DESCRIPCION;
            Btnjuego3.Tag = preguntas[2].ID;
            Btnjuego4.Text = preguntas[3].DESCRIPCION;
            Btnjuego4.Tag = preguntas[3].ID;
            Btnjuego5.Text = preguntas[4].DESCRIPCION;
            Btnjuego5.Tag = preguntas[4].ID;
            Btnjuego6.Text = preguntas[5].DESCRIPCION;
            Btnjuego6.Tag = preguntas[5].ID;
            Btnjuego7.Text = preguntas[6].DESCRIPCION;
            Btnjuego7.Tag = preguntas[6].ID;
            Btnjuego8.Text = preguntas[7].DESCRIPCION;
            Btnjuego8.Tag = preguntas[7].ID;
            Btnjuego9.Text = preguntas[8].DESCRIPCION;
            Btnjuego9.Tag = preguntas[8].ID;
            Btnjuego10.Text = preguntas[9].DESCRIPCION;
            Btnjuego10.Tag = preguntas[9].ID;
            Btnjuego11.Text = preguntas[10].DESCRIPCION;
            Btnjuego11.Tag = preguntas[10].ID;
            Btnjuego12.Text = preguntas[11].DESCRIPCION;
            Btnjuego12.Tag = preguntas[11].ID;
            //respuestas
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted termino la partida con " + Convert.ToString(puntuacion) + " Puntos");
        }
    }
}
