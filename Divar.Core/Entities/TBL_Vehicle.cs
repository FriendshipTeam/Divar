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
    
    public partial class TBL_Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Vehicle()
        {
            this.TBL_Advertisement = new HashSet<TBL_Advertisement>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public int ColorID { get; set; }
        public int VehicleTypeID { get; set; }
        public int ManufacturerID { get; set; }
        public int AssemblerID { get; set; }
        public string Series { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Advertisement> TBL_Advertisement { get; set; }
        public virtual TBL_Assembler TBL_Assembler { get; set; }
        public virtual TBL_Color TBL_Color { get; set; }
        public virtual TBL_Manufacturer TBL_Manufacturer { get; set; }
        public virtual TBL_VehicleType TBL_VehicleType { get; set; }
    }
}
