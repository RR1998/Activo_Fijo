//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivoFijo.DatabaseModule
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADMINISTRAR
    {
        public int IDUsuario { get; set; }
        public int IDBien { get; set; }
        public Nullable<System.DateTime> FECHAADQUISISCION { get; set; }
        public Nullable<System.DateTime> FECHACOMPRA { get; set; }
        public decimal Costo { get; set; }
        public Nullable<int> CANTIDAD { get; set; }
    
        public virtual BIEN BIEN { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
