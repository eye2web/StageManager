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
    
    public partial class bedrijfsets
    {
        public bedrijfsets()
        {
            this.bedrijfsbegeleidersets = new HashSet<bedrijfsbegeleidersets>();
        }
    
        public int Bedrijfs_Id { get; set; }
        public string Naam { get; set; }
        public string Telefoonnummer { get; set; }
        public string Website { get; set; }
        public int adresset_Id { get; set; }
    
        public virtual adressets adressets { get; set; }
        public virtual ICollection<bedrijfsbegeleidersets> bedrijfsbegeleidersets { get; set; }
    }
}
