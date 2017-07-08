using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public abstract partial class BaseEntity
    {
        public long Id { get; set; }
    }
}
