using System.Collections.Generic;

namespace BlogDotnet5.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public List<Post> Posts { get; set; }
    }
}