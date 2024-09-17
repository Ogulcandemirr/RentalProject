﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUser { get; set; } 
		public DateTime Commentdate { get; set; }

        public string CommentContent { get; set; } 
		public bool CommentState { get; set; }

        public int CarId { get; set; }
        
        public Car Car { get; set; }

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }
    }
}
