//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFBS.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class OBSERVACION_COMPETENCIA
    {
        public decimal ID_OBSERVACION { get; set; }
        public Nullable<decimal> ID_COMPETENCIA { get; set; }
        public Nullable<decimal> ID_AREA { get; set; }
        public Nullable<decimal> NIVEL_INFERIOR { get; set; }
        public Nullable<decimal> NIVEL_SUPERIOR { get; set; }
        public string MENSAJE { get; set; }
    
        public virtual AREA AREA { get; set; }
        public virtual COMPETENCIA COMPETENCIA { get; set; }
    }
}
