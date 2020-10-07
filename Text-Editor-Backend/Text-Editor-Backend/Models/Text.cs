using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Text_Editor_Backend.Models
{
    public class Text
    {
        public int Id { get; set; }

        public string TextContent { get; set; }

        public IEnumerable<Writer> AllowedWriters { get; set; }
    }
}