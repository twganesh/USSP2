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
    
    public partial class WSSE_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WSSE_USER()
        {
            this.WSSE_SHIP = new HashSet<WSSE_SHIP>();
        }
    
        public string USERID { get; set; }
        public string USERLEVEL { get; set; }
        public string EMAIL { get; set; }
        public string NAME { get; set; }
        public string UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<decimal> LOCKED { get; set; }
        public string LOCATIONLDAP { get; set; }
        public Nullable<System.DateTime> TRAINING_COMPLETE { get; set; }
        public Nullable<System.DateTime> LASTLOGIN { get; set; }
        public decimal DELETED { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public string DELETED_BY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WSSE_SHIP> WSSE_SHIP { get; set; }
    }
}