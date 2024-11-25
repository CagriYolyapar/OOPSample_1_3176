using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_1.Models
{
    public class Category : BaseEntity
    {
        public string Description { get; set; }
        public List<Article> Articles { get; set; }

    }
}
