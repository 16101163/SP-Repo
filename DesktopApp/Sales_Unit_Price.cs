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
    
    public partial class Sales_Unit_Price
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sales_Unit_Price()
        {
            this.Sales_Order_line = new HashSet<Sales_Order_line>();
        }
    
        public int Sales_Price_ID { get; set; }
        public Nullable<decimal> Sales_Price { get; set; }
        public Nullable<System.DateTime> Sales_Price_Year { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public string SP_Number { get; set; }
    
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Order_line> Sales_Order_line { get; set; }
    }
}
