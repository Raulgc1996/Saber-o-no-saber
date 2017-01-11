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
        private List<Button> botones;
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
                    foreach (Button boton in botones)
                    {
                        boton.Enabled = false;
                    }
                    MessageBox.Show("has ganado", "Enorabuena");
                }
            }else {
                contFallos += 1;
                rafaga = 0;
                botonJuego.BackColor = Color.Red;
                lblJusti.Text = respuesta;
                puntuacion = puntuacion / 2;
                lblPuntos.Text = Convert.ToString(puntuacion);
                botonJuego.Enabled = false;
                if (contFallos == 4)
                {
                    MessageBox.Show("has perdido", "Loser");
                    foreach (Button boton in botones)
                    {
                        boton.Enabled = false;
                    }
                }
            }

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            foreach (Button boton in botones)
            {
                boton.BackColor = DefaultBackColor;
                boton.Enabled = true;
            }
            contFallos = 0;
            contAciertos = 0;
            // cargar pregunta
            PREGUNTA pregunta = negocio.returnQuestion(1);
            lblPregunta.Text = pregunta.DESCRIPCION;
            List<RESPUESTA> preguntas = new List<RESPUESTA>();
            preguntas = negocio.returnAnswersFromQuestion(pregunta.ID);

           
                for (int i = 0; i< preguntas.Count; i++)
                {
                    botones[i].Text = preguntas[i].DESCRIPCION;
                botones[i].Tag = preguntas[i].ID;
                }
                
            
           
            //respuestas
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted termino la partida con " + Convert.ToString(puntuacion) + " Puntos");
            foreach (Button boton in botones)
            {
                boton.Enabled = false;
            }
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            botones = new List<Button> { Btnjuego1, Btnjuego2, Btnjuego3, Btnjuego4, Btnjuego5, Btnjuego6, Btnjuego7, Btnjuego8, Btnjuego9, Btnjuego10, Btnjuego11, Btnjuego12 };
        foreach (Button boton in botones){
                boton.Enabled = false;
                boton.BackColor = DefaultBackColor;
            }
        }
    }
}
