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
    
    public partial class algemeenset
    {
        public algemeenset()
        {
            this.docentsets = new HashSet<docentset>();
        }
    
        public int Id { get; set; }
        public string Jaargang { get; set; }
        public string Werk_Uren { get; set; }
        public string Blokken { get; set; }
    
        public virtual ICollection<docentset> docentsets { get; set; }
    }
}