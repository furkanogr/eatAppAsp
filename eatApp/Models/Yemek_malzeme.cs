//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eatApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yemek_malzeme
    {
        public string yemekMalzemeId { get; set; }
        public string Yemek_id { get; set; }
        public string Malzeme_id { get; set; }
        public int Miktar { get; set; }
        public int Birim_id { get; set; }
    
        public virtual Malzemeler Malzemeler { get; set; }
        public virtual Yemekler Yemekler { get; set; }
    }
}
