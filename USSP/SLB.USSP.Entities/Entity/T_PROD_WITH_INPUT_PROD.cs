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
    
    public partial class T_PROD_WITH_INPUT_PROD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PROD_WITH_INPUT_PROD()
        {
            this.T_PROD_WITH_INPUT_PROD_GROUPS = new HashSet<T_PROD_WITH_INPUT_PROD_GROUPS>();
        }
    
        public string F_PRODUCT { get; set; }
        public string F_INPUT_PRODUCT { get; set; }
        public Nullable<decimal> F_PERCENT { get; set; }
        public string F_PRODUCT_NAME { get; set; }
        public string F_USER_UPDATED { get; set; }
        public Nullable<System.DateTime> F_DATE_STAMP { get; set; }
        public Nullable<decimal> F_SORTORDER { get; set; }
        public Nullable<decimal> F_FROM_PERCENT { get; set; }
        public short F_REQUIRED { get; set; }
        public string F_INPUT_PRODUCT_MODEL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PROD_WITH_INPUT_PROD_GROUPS> T_PROD_WITH_INPUT_PROD_GROUPS { get; set; }
    }
}
