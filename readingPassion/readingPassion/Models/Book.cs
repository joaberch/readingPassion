using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readingPassion.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int NbrPage { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
        public string State { get; set; }
        public string[] Tags { get; set; }
        
        //Debug
        public override string ToString()
        {
            return $"[Book {Id}]";
        }
    }
}
