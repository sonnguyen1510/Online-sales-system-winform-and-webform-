//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bán_Hàng_Onl_WebForm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public decimal productID { get; set; }
        public decimal OrderID { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public Nullable<decimal> price { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Order Order1 { get; set; }
        public virtual Product Product { get; set; }
    }
}
