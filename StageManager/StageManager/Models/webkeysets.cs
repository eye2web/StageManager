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
    
    public partial class webkeysets
    {
        public webkeysets()
        {
            this.docentsets = new HashSet<docentsets>();
            this.studentsets = new HashSet<studentsets>();
            this.tempemailsets = new HashSet<tempemailsets>();
        }
    
        public int Id { get; set; }
        public string ConnectionKey { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<docentsets> docentsets { get; set; }
        public virtual ICollection<studentsets> studentsets { get; set; }
        public virtual ICollection<tempemailsets> tempemailsets { get; set; }
    }
}
