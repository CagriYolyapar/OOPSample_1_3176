using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_1.Models
{
    public class Article : BaseEntity
    {
        public string Content { get; set; }
        public Editor Editor { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public List<Tag> Tags { get; set; }


    }
}
