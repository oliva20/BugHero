//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bug
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.TimeSpan Timestamp { get; set; }
        public int Severity { get; set; }
        public string Id1 { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Project Project { get; set; }
    }
}