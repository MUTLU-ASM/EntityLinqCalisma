//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityOrnek.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class notlar
    {
        public int id { get; set; }
        public Nullable<int> ogrenci { get; set; }
        public Nullable<int> ders { get; set; }
        public Nullable<short> sinav1 { get; set; }
        public Nullable<short> sinav2 { get; set; }
        public Nullable<short> sinav3 { get; set; }
        public Nullable<decimal> ortalama { get; set; }
        public Nullable<bool> durum { get; set; }
    
        public virtual ders ders1 { get; set; }
        public virtual ogrenci ogrenci1 { get; set; }
    }
}
