//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServisWinUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLCARI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCARI()
        {
            this.TBLFATURABILGI = new HashSet<TBLFATURABILGI>();
            this.TBLURUNHAREKET = new HashSet<TBLURUNHAREKET>();
            this.TBLURUNKABUL = new HashSet<TBLURUNKABUL>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string BANKA { get; set; }
        public string VERGIADRESI { get; set; }
        public string VERGINO { get; set; }
        public string STATU { get; set; }
        public string ADRES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFATURABILGI> TBLFATURABILGI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUNHAREKET> TBLURUNHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUNKABUL> TBLURUNKABUL { get; set; }
    }
}
