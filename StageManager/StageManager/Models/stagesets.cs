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
    
    public partial class stagesets
    {
        public stagesets()
        {
            this.kennisgebiedset = new HashSet<kennisgebiedset>();
        }
    
        public int Stage_Id { get; set; }
        public Nullable<System.DateTime> Start_datum { get; set; }
        public Nullable<System.DateTime> Eind_datum { get; set; }
        public string Stageopdracht_omschijving { get; set; }
        public int studentset_Id { get; set; }
        public Nullable<int> docentset_Id { get; set; }
        public Nullable<int> Bedrijfsbegeleider_id { get; set; }
    
        public virtual studentsets studentsets { get; set; }
        public virtual docentsets docentsets1 { get; set; }
        public virtual eindstagesets eindstagesets { get; set; }
        public virtual ICollection<kennisgebiedset> kennisgebiedset { get; set; }
        public virtual bedrijfsbegeleidersets bedrijfsbegeleidersets1 { get; set; }
    }
}
