//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketOtomasyonEnti.Data2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stok
    {
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string StokSayısı { get; set; }
    
        public virtual Urunler Urunler { get; set; }
    }
}