using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithEnums
{
    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public StatusEnum Status { get; set; }
    }
    enum StatusEnum
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}
