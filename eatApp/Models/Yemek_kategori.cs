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
    
    public partial class Yemek_kategori
    {
        public string yemekKategoriId { get; set; }
        public string Yemek_id { get; set; }
        public string Kategori_yemek_id { get; set; }
    
        public virtual Kategori_yemek Kategori_yemek { get; set; }
        public virtual Yemekler Yemekler { get; set; }
    }
}
