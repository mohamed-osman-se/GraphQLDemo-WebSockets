using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;


        public int AuthorId { get; set; }
        public Author Author { get; set; } = default!;
    }
}
