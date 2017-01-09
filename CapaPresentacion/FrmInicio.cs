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
            foreach ( RESPUESTA pre in preguntas)
            {

            }
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
