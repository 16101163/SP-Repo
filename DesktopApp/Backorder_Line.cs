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
    
    public partial class Backorder_Line
    {
        public int Backorder_Line_ID { get; set; }
        public Nullable<int> Quantity_Received { get; set; }
        public Nullable<int> Supplier_Order_Line_ID { get; set; }
        public Nullable<int> Supplier_Backorder_ID { get; set; }
    
        public virtual Supplier_Backorder Supplier_Backorder { get; set; }
        public virtual Supplier_Order_Line Supplier_Order_Line { get; set; }
    }
}
