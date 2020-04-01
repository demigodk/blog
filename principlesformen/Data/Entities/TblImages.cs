using System;
using System.Collections.Generic;

namespace principlesformen.Data.Entities
{
    public partial class TblImages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public byte[] ImageData { get; set; }
    }
}
