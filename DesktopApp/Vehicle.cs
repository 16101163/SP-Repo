//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.Dispatches = new HashSet<Dispatch>();
        }
    
        public int Vehicle_ID { get; set; }
        public string Vehicle_Registration_Number { get; set; }
        public string Vehicle_Make { get; set; }
        public string Vehicle_Model { get; set; }
        public string VIN_Number { get; set; }
        public Nullable<System.DateTime> Last_Serviced { get; set; }
        public Nullable<int> Vehicle_Status_ID { get; set; }
        public string V_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dispatch> Dispatches { get; set; }
        public virtual Vehicle_Status Vehicle_Status { get; set; }
    }
}
