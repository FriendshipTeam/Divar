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
    
    public partial class TBL_State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityID { get; set; }
    
        public virtual TBL_City TBL_City { get; set; }
    }
}
