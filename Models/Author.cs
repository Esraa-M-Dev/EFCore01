using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Models
{
    internal class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddresss { get; set; }
        public string ShortBio { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
