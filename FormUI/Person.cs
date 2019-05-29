using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    {
        public string AuthorId { get; set; }

        public string Name { get; set; }

        public string FullInfo

        {
            get
            {
                return $"{AuthorId} {Name}";
            }

        }
    }
}
