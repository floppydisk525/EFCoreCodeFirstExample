using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstExample.Data.Entities
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
