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
    
    public partial class persoonset_docentset
    {
        public persoonset_docentset()
        {
            this.adressets = new HashSet<adresset>();
            this.webkeysets = new HashSet<webkeyset>();
            this.opleidingsets = new HashSet<opleidingset>();
            this.tool_vaardigheidset = new HashSet<tool_vaardigheidset>();
        }
    
        public int Leraar_Id { get; set; }
        public Nullable<short> DBU1 { get; set; }
        public Nullable<short> DBU2 { get; set; }
        public Nullable<short> DBU3 { get; set; }
        public Nullable<short> DBU4 { get; set; }
        public int stagesetStage_Id { get; set; }
        public int algemeensetId { get; set; }
        public string Webkey { get; set; }
        public int Id { get; set; }
    
        public virtual ICollection<adresset> adressets { get; set; }
        public virtual algemeenset algemeenset { get; set; }
        public virtual persoonset persoonset { get; set; }
        public virtual stageset stageset { get; set; }
        public virtual ICollection<webkeyset> webkeysets { get; set; }
        public virtual ICollection<opleidingset> opleidingsets { get; set; }
        public virtual ICollection<tool_vaardigheidset> tool_vaardigheidset { get; set; }
    }
}
