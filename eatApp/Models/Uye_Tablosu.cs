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
    
    public partial class uye_Tablosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uye_Tablosu()
        {
            this.favori_Tablo = new HashSet<favori_Tablo>();
            this.takipci_Tablosu = new HashSet<takipci_Tablosu>();
            this.takipci_Tablosu1 = new HashSet<takipci_Tablosu>();
            this.Yemekler = new HashSet<Yemekler>();
        }
    
        public string uyeId { get; set; }
        public string uyeAdSoyad { get; set; }
        public string uyeEmail { get; set; }
        public string uyeSifre { get; set; }
        public string uyeTelefon { get; set; }
        public bool uyeAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<favori_Tablo> favori_Tablo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<takipci_Tablosu> takipci_Tablosu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<takipci_Tablosu> takipci_Tablosu1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yemekler> Yemekler { get; set; }
    }
}
