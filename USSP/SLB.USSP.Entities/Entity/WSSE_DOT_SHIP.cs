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
    
    public partial class WSSE_DOT_SHIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WSSE_DOT_SHIP()
        {
            this.WSSE_MAT_SHIP = new HashSet<WSSE_MAT_SHIP>();
        }
    
        public string CAT { get; set; }
        public string PRODUCT { get; set; }
        public Nullable<decimal> ACTUAL_QTY { get; set; }
        public string ACTUAL_UNIT { get; set; }
        public string PACKTYPE { get; set; }
        public Nullable<decimal> PACKNO { get; set; }
        public decimal ID { get; set; }
        public Nullable<decimal> SHIPID { get; set; }
        public Nullable<decimal> SORT { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
        public string BULKITEM { get; set; }
        public string LOTNO { get; set; }
        public string TANKNO { get; set; }
        public string SLINGNO { get; set; }
        public Nullable<System.DateTime> SLINGDATE { get; set; }
        public string PACKLOC { get; set; }
        public short RESIDUE { get; set; }
        public string ORDER_RELEASE_ID { get; set; }
    
        public virtual WSSE_SHIP WSSE_SHIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WSSE_MAT_SHIP> WSSE_MAT_SHIP { get; set; }
    }
}
