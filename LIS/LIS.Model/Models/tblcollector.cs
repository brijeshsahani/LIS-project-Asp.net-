//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIS.Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblcollector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblcollector()
        {
            this.tblrecords = new HashSet<tblrecord>();
        }
    
        public int collectorid { get; set; }
        public string collectorname { get; set; }
        public string collectoremail { get; set; }
        public string collectorphno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblrecord> tblrecords { get; set; }
    }
}
