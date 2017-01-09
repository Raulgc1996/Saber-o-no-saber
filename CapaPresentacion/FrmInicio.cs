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
      // privare rafaga 
        public FrmInicio()
        {

            InitializeComponent();
            // cargar pregunta
            PREGUNTA pregunta = negocio.returnQuestion(1);
            lblPregunta.Text = (String) pregunta.DESCRIPCION;
            List<RESPUESTA> preguntas = new List<RESPUESTA>();
            preguntas = negocio.returnAnswersFromQuestion(pregunta.ID);

            Btnjuego1.Text = preguntas[0].DESCRIPCION;
            Btnjuego1.Tag = preguntas[0].IDPREGUNTA;
            Btnjuego2.Text = preguntas[1].DESCRIPCION;
            Btnjuego2.Tag = preguntas[1].IDPREGUNTA;
            Btnjuego3.Text = preguntas[2].DESCRIPCION;
            Btnjuego3.Tag = preguntas[2].IDPREGUNTA;
            Btnjuego4.Text = preguntas[3].DESCRIPCION;
            Btnjuego4.Tag = preguntas[3].IDPREGUNTA;
            Btnjuego5.Text = preguntas[4].DESCRIPCION;
            Btnjuego5.Tag = preguntas[4].IDPREGUNTA;
            Btnjuego6.Text = preguntas[5].DESCRIPCION;
            Btnjuego6.Tag = preguntas[5].IDPREGUNTA;
            Btnjuego7.Text = preguntas[6].DESCRIPCION;
            Btnjuego7.Tag = preguntas[6].IDPREGUNTA;
            Btnjuego8.Text = preguntas[7].DESCRIPCION;
            Btnjuego8.Tag = preguntas[7].IDPREGUNTA;
            Btnjuego9.Text = preguntas[8].DESCRIPCION;
            Btnjuego9.Tag = preguntas[8].IDPREGUNTA;
            Btnjuego10.Text = preguntas[9].DESCRIPCION;
            Btnjuego10.Tag = preguntas[9].IDPREGUNTA;
            Btnjuego11.Text = preguntas[10].DESCRIPCION;
            Btnjuego11.Tag = preguntas[10].IDPREGUNTA;
            Btnjuego12.Text = preguntas[11].DESCRIPCION;
            Btnjuego12.Tag = preguntas[11].IDPREGUNTA;
            //respuestas

        }

        private void Btnjuego_Click(object sender, EventArgs e)
        {
            Button botonJuego  = (Button) sender;
            MessageBox.Show("vcbf");
            //comprovar

        }
    }
}
