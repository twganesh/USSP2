//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLB.USSP.Entities.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class WSSE_MAT_SHIP
    {
        public decimal ID { get; set; }
        public string PRODUCT { get; set; }
        public Nullable<decimal> WT_VOL { get; set; }
        public string WT_VOL_UNIT { get; set; }
        public string UPDATE_BY { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public decimal SHIPID { get; set; }
        public Nullable<decimal> SORTORDER { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal DOT_SHIPID { get; set; }
        public Nullable<short> DRY_BLEND { get; set; }
        public Nullable<decimal> CONCENTRATION { get; set; }
    
        public virtual WSSE_DOT_SHIP WSSE_DOT_SHIP { get; set; }
        public virtual WSSE_SHIP WSSE_SHIP { get; set; }
    }
}
