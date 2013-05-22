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
    
    public partial class docentsets
    {
        public docentsets()
        {
            this.eindstagesets = new HashSet<eindstagesets>();
            this.stagesets = new HashSet<stagesets>();
            this.kennisgebiedset = new HashSet<kennisgebiedset>();
            this.opleidingsets = new HashSet<opleidingsets>();
        }
    
        public int Id { get; set; }
        public Nullable<double> DBU1 { get; set; }
        public Nullable<double> DBU2 { get; set; }
        public Nullable<double> DBU3 { get; set; }
        public Nullable<double> DBU4 { get; set; }
        public int algemeensetId { get; set; }
        public int adresset_Id { get; set; }
        public int webkeysets_Id { get; set; }
    
        public virtual adressets adressets { get; set; }
        public virtual algemeensets algemeensets { get; set; }
        public virtual ICollection<eindstagesets> eindstagesets { get; set; }
        public virtual persoonsets persoonsets { get; set; }
        public virtual ICollection<stagesets> stagesets { get; set; }
        public virtual webkeysets webkeysets { get; set; }
        public virtual ICollection<kennisgebiedset> kennisgebiedset { get; set; }
        public virtual ICollection<opleidingsets> opleidingsets { get; set; }
    }
}
