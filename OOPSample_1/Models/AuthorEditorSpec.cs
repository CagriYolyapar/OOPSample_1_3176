using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_1.Models
{
    public abstract class AuthorEditorSpec: BaseEntity
    {
        public string LastName { get; set; }
        public List<Article> Articles { get; set; }
    }
}
