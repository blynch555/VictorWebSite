//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace escortagram.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class blog_tag
    {
        public int tagid { get; set; }
        public Nullable<int> post_id { get; set; }
        public string tag { get; set; }
    
        public virtual blog_post blog_post { get; set; }
    }
}