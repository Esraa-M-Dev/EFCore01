using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string ISBNNumber { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int Year { get; set; }
        public int Stock { get; set; }
    }
}
