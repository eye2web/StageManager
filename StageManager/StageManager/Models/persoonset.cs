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
    
    public partial class persoonset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<int> Telefoonnummer { get; set; }
    
        public virtual bedrijfsbegeleiderset bedrijfsbegeleiderset { get; set; }
        public virtual docentset docentset { get; set; }
        public virtual studentset studentset { get; set; }
    }
}