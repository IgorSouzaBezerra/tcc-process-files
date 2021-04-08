using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Domain.Entities
{
    public class ColumnControl : BaseEntity
    {
        public int ColumnPosition { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int Size { get; set; }
        public string Field { get; set; }
        public string FieldCode { get; set; }
        public string Typing { get; set; }
        public string Company { get; set; }
    }
}
