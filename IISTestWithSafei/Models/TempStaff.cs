using System;
using System.Collections.Generic;

namespace IISTestWithSafei.Models
{
    public partial class TempStaff
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Gender { get; set; }
        public int Position { get; set; }
    }
}
