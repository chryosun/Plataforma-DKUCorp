//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlataformaDKUCorp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Simulacion
    {
        public string SimID { get; set; }
        public string SimNom { get; set; }
        public int NumRondas { get; set; }
        public string SimDesc { get; set; }
        public int SimNota { get; set; }
        public Nullable<decimal> PresupuestoInit { get; set; }
        public Nullable<decimal> PrecioProdInit { get; set; }
        public Nullable<decimal> MaqValor { get; set; }
        public string ClaseID { get; set; }
        public string Autor { get; set; }
    
        public virtual Clase Clase { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
