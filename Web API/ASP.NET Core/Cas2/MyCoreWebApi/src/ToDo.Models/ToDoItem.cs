﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class ToDoItem : BaseEntity
    {
        public bool IsComplete { get; set; }
        public string Name { get; set; }
        public ToDoItem()
        {
        }
    }
}
