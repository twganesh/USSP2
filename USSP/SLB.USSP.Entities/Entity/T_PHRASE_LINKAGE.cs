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
    
    public partial class T_PHRASE_LINKAGE
    {
        public decimal F_LINK_ID { get; set; }
        public decimal F_PHRASE_ID { get; set; }
        public string F_DATA_CODE { get; set; }
        public string F_TEXT_CODE { get; set; }
        public short F_TEXT_TYPE { get; set; }
        public short F_SEVERITY { get; set; }
        public string F_COMMENTS { get; set; }
        public Nullable<short> F_STATUS { get; set; }
        public string F_USER_REQUESTED { get; set; }
        public string F_USER_ADDED { get; set; }
        public string F_USER_UPDATED { get; set; }
        public System.DateTime F_DATE_STAMP { get; set; }
    }
}
