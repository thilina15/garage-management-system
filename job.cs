//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myFirstApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public job()
        {
            this.jobItems = new HashSet<jobItem>();
        }
    
        public int jobID { get; set; }
        public string vehicle { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string specialNote { get; set; }
        public Nullable<int> itemsCost { get; set; }
        public Nullable<int> serviceCost { get; set; }
        public string customerNIC { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jobItem> jobItems { get; set; }
    }
}
