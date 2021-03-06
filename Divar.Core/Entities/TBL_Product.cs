//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Divar.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public int KiloMeters { get; set; }
        public string Color { get; set; }
        public Nullable<int> IdAdvertisement { get; set; }
        public int AdvertisementTypeID { get; set; }
        public int AdvertiserTypeID { get; set; }
    
        public virtual TBL_Advertisement TBL_Advertisement { get; set; }
        public virtual TBL_AdvertisementType TBL_AdvertisementType { get; set; }
        public virtual TBL_AdvertiserType TBL_AdvertiserType { get; set; }
    }
}
