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
    
    public partial class tempemailsets
    {
        public string Email { get; set; }
        public Nullable<int> Web_id { get; set; }
    
        public virtual webkeysets webkeysets { get; set; }
    }
}
