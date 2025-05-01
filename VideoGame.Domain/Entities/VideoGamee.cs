using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame.Domain.Entities
{
    public class VideoGamee
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Platform { get; set; }
        public int? DeveloperId { get; set; }
        public int? PublisherId { get; set; }
    }

}
