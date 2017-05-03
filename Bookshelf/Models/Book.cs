using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {

        [Key]

        public int ID { get; set; }
        public string Title { get; set; }

        [Display (Name ="Date Published")] [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:mm/dd/yyyy}")]
        public DateTime PublishedDate { get; set; }

        public string Description { get; set; }
        public string ISBN { get; set; }


        [ForeignKey("Category")]
        public int CategoryID { get; set;}
        public virtual Category Category { get; set; }


    }
}