//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class RESPUESTA
    {
        public RESPUESTA()
        {
            this.INCORRECTA_EXPLICACION = new HashSet<INCORRECTA_EXPLICACION>();
        }
    
        public int ID { get; set; }
        public int IDPREGUNTA { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<INCORRECTA_EXPLICACION> INCORRECTA_EXPLICACION { get; set; }
        public virtual PREGUNTA PREGUNTA { get; set; }
    }
}
