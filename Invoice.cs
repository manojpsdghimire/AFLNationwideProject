//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AFL_GLOBAL_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public System.Guid InvoiceID { get; set; }
        public string Invoice1 { get; set; }
        public System.Guid SubOrgID { get; set; }
    
        public virtual SubOrganization SubOrganization { get; set; }
    }
}
