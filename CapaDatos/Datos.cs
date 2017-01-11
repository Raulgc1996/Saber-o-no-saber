using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class Datos
    {
        private SABER_DBEntities DB = new SABER_DBEntities();

        public CapaEntidades.PREGUNTA returnQuestion(int index)
        {
            List<PREGUNTA> pregs = (from pr in DB.PREGUNTAS select (pr)).ToList();
            Random rnd = new Random();
            int indice;
            while ((indice = rnd.Next(pregs.Count)) == index) { }
            return pregs[indice];
        }

        public List<CapaEntidades.RESPUESTA> returnAnswersFromQuestion(int id)
        {
            List<RESPUESTA> resps = (from rs in DB.RESPUESTAS where rs.IDPREGUNTA == id select (rs)).ToList();
            return resps;
        }

        public String ComprobarPregunta(int id)
        {
            INCORRECTA_EXPLICACION resp = (from rs in DB.INCORRECTA_EXPLICACION where rs.IDRESPUESTA == id select rs).SingleOrDefault();
            if (resp != null) { return resp.JUSTIFICACION; }
            return "";
        }




        public static List<T> DesordenarLista<T>(List<T> input)
        {
            List<T> arr = input;
            List<T> desordenada = new List<T>();

            Random randNum = new Random();
            while (arr.Count > 0)
            {
                int val = randNum.Next(0, arr.Count - 1);
                desordenada.Add(arr[val]);
                arr.RemoveAt(val);
            }

            return desordenada;
        }

    }

}
