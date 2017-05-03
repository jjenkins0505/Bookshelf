using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {

        [Key]
        public int ID { get; set; }

        [Display(Name= "Category Name")]
        public string Name { get; set; }


        //ICollection is more efficient when setting up a one to many relationship code first. type of collection (cousin to a list)
        public virtual ICollection<Book> Books { get; set; }



    }
}