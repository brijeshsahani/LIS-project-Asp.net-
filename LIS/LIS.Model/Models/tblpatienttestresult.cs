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
    using System.ComponentModel.DataAnnotations;

    public partial class tblpatienttestresult
    {
        public int patienttestresultid { get; set; }
        public Nullable<int> recordid { get; set; }
        public Nullable<int> patientid { get; set; }
        public Nullable<int> testid { get; set; }
        public Nullable<int> analyticid { get; set; }
        public string reading { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual tblanalytic tblanalytic { get; set; }
        public virtual tblpatient tblpatient { get; set; }
        public virtual tblrecord tblrecord { get; set; }
        public virtual tbltestmaster tbltestmaster { get; set; }
    }
}
