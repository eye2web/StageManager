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
    
    public partial class docentset
    {
        public docentset()
        {
            this.eindstagesets = new HashSet<eindstageset>();
            this.stagesets = new HashSet<stageset>();
            this.kennisgebiedsets = new HashSet<kennisgebiedset>();
            this.opleidingsets = new HashSet<opleidingset>();
        }
    
        public int Id { get; set; }
        public Nullable<double> DBU1 { get; set; }
        public Nullable<double> DBU2 { get; set; }
        public Nullable<double> DBU3 { get; set; }
        public Nullable<double> DBU4 { get; set; }
        public int algemeensetId { get; set; }
        public int adresset_Id { get; set; }
        public int webkeysets_Id { get; set; }
        public string VervoerMiddel { get; set; }
    
        public virtual adresset adresset { get; set; }
        public virtual algemeenset algemeenset { get; set; }
        public virtual ICollection<eindstageset> eindstagesets { get; set; }
        public virtual persoonset persoonset { get; set; }
        public virtual ICollection<stageset> stagesets { get; set; }
        public virtual webkeyset webkeyset { get; set; }
        public virtual ICollection<kennisgebiedset> kennisgebiedsets { get; set; }
        public virtual ICollection<opleidingset> opleidingsets { get; set; }
    }
}