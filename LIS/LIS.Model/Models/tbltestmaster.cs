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
    
    public partial class tbltestmaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbltestmaster()
        {
            this.tblpatienttestresults = new HashSet<tblpatienttestresult>();
        }
    
        public int testid { get; set; }
        public string testname { get; set; }
        public Nullable<double> testprice { get; set; }
        public string analyticlist { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblpatienttestresult> tblpatienttestresults { get; set; }
        public string[] analytic_idArr { get; set; }
    }
}