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
    
    public partial class webkeyset
    {
        public webkeyset()
        {
            this.docentsets = new HashSet<docentset>();
            this.studentsets = new HashSet<studentset>();
            this.tempemailsets = new HashSet<tempemailset>();
        }
    
        public int Id { get; set; }
        public string ConnectionKey { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<docentset> docentsets { get; set; }
        public virtual ICollection<studentset> studentsets { get; set; }
        public virtual ICollection<tempemailset> tempemailsets { get; set; }
    }
}