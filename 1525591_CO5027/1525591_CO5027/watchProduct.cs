//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1525591_CO5027
{
    using System;
    using System.Collections.Generic;
    
    public partial class watchProduct
    {
        public int ID { get; set; }
        public int watchProID { get; set; }
        public string watchName { get; set; }
        public Nullable<int> watchPrice { get; set; }
        public string watchDescription { get; set; }
        public string watchImage { get; set; }
    
        public virtual watchProdType watchProdType { get; set; }
    }
}