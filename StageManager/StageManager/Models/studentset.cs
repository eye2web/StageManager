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
    
    public partial class studentset
    {
        public studentset()
        {
            this.stagesets = new HashSet<stageset>();
            this.stagesets1 = new HashSet<stageset>();
        }
    
        public int Studentnummer { get; set; }
        public bool EC_norm_behaald { get; set; }
        public int OpleidingId { get; set; }
        public int Id { get; set; }
        public int webkeysets_Id { get; set; }
    
        public virtual opleidingset opleidingset { get; set; }
        public virtual persoonset persoonset { get; set; }
        public virtual ICollection<stageset> stagesets { get; set; }
        public virtual ICollection<stageset> stagesets1 { get; set; }
        public virtual webkeyset webkeyset { get; set; }
    }
}