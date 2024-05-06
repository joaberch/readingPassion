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
        /// <summary>
        /// PRIMARY KEY of the book
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Category of the book (novel, manga, etc)
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// The number of page the book has
        /// </summary>
        public int NbrPage { get; set; }
        /// <summary>
        /// The name of the author of the book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The name of the cover image, the program will use it to find the image
        /// </summary>
        public string CoverImage { get; set; }
        /// <summary>
        /// The current state of the book (reading, to read)
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// The tags the book has
        /// </summary>
        public string[] Tags { get; set; }
        
        /// <summary>
        /// Debug
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"id : {Id} | title : {Title} | category : {Category} | nbrPag : {NbrPage} | author : {Author} | coverImage : {CoverImage} | state : {State} | tags : {Tags}";
        }
    }
}
