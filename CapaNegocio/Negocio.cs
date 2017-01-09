using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
namespace CapaNegocio
{
    public class Negocio
    {
        private Datos datos = new Datos();
        public CapaEntidades.PREGUNTA returnQuestion(int index)
        {
            return datos.returnQuestion(index);
        }

        public List<CapaEntidades.RESPUESTA> returnAnswersFromQuestion(int id)
        {
            return datos.returnAnswersFromQuestion(id);
        }

        public String ComprobarPregunta(int id)
        {
            return datos.ComprobarPregunta(id);
        }
    }
}
