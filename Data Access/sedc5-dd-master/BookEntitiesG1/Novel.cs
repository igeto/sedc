﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntitiesG1
{
    public class Novel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }

        public Author Author { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author.Name}";
        }
    }
}
