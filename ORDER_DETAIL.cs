//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER_DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER_DETAIL()
        {
            this.SUPPLIERs = new HashSet<SUPPLIER>();
        }
    
        public int Order_Detail_ID { get; set; }
        public double Unit_Price { get; set; }
        public int Quantity { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public Nullable<int> Order_ID { get; set; }
        public Nullable<int> Bill_Number { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ORDER ORDER { get; set; }
        public virtual PAYMENT PAYMENT { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLIER> SUPPLIERs { get; set; }
    }
}