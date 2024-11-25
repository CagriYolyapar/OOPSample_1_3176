using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_1.Models
{
    public class Tag : BaseEntity
    {
        public List<Article> Articles { get; set; }

    }
}
