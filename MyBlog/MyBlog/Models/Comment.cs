//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBlog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentsID { get; set; }
        public int PostID { get; set; }
        public System.DateTime CommetedOn { get; set; }
        public string CommentAuthor { get; set; }
        public string CommentBody { get; set; }
        public int CommentRespect { get; set; }
    
        public virtual Post Post { get; set; }
    }
}