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
    
    public partial class Sales_Order_line
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sales_Order_line()
        {
            this.Refund_Line = new HashSet<Refund_Line>();
        }
    
        public int Sales_Order_line_Id { get; set; }
        public Nullable<int> Product_Quantity { get; set; }
        public Nullable<int> Sales_Price_ID { get; set; }
        public Nullable<int> Sale_Id { get; set; }
        public Nullable<int> Product_ID { get; set; }
    
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Refund_Line> Refund_Line { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Sales_Unit_Price Sales_Unit_Price { get; set; }
    }
}
