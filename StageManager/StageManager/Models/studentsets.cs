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
    
    public partial class studentsets
    {
        public studentsets()
        {
            this.stagesets = new HashSet<stagesets>();
            this.stagesets1 = new HashSet<stagesets>();
        }
    
        public int Studentnummer { get; set; }
        public bool EC_norm_behaald { get; set; }
        public int OpleidingId { get; set; }
        public int Id { get; set; }
        public int webkeysets_Id { get; set; }
        public Nullable<int> stage_ID { get; set; }
        public Nullable<int> eindStage_ID { get; set; }
    
        public virtual opleidingsets opleidingsets { get; set; }
        public virtual persoonsets persoonsets { get; set; }
        public virtual ICollection<stagesets> stagesets { get; set; }
        public virtual ICollection<stagesets> stagesets1 { get; set; }
        public virtual webkeysets webkeysets { get; set; }
        public virtual eindstagesets eindstagesets { get; set; }
        public virtual stagesets stagesets2 { get; set; }
    }
}
