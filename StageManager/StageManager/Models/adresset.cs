//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StageManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class adresset
    {
        public int Id { get; set; }
        public string Plaats { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public int bedrijfset_Bedrijfs_Id { get; set; }
        public int docentset_Id { get; set; }
    
        public virtual bedrijfset bedrijfset { get; set; }
        public virtual docentset docentset { get; set; }
    }
}
