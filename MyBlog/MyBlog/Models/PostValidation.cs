﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
    [MetadataType(typeof(PostMetaData))]
    public partial class Post
    {
    }

    public class PostMetaData
    {
        [Required(ErrorMessage="You need to enter a title")
        , Display(Name="Title")]
        public string PostTitle;

        [Required(ErrorMessage = "Author name required")
        , Display(Name="Author")]
        public string PostAuthor;

        [Required(ErrorMessage = "A Date is required")
        , Display(Name = "Date")]
        public string PostedOn;

        [Display(Name="Picture (Optional)")]
        public string PostPic;

        [Required(ErrorMessage="Text body is required")
        , Display(Name="Body")]
        public string PostBody;
        
        [Required(ErrorMessage = "Please provide at least one tag")
        , Display(Name="Tags")]
        public string PostTags;
    }
}