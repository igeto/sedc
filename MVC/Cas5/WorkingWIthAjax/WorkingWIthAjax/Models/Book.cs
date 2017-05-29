using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWIthAjax.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }

        public Book(int id, string name, int pageCount)
        {
            Id = id;
            Name = name;
            PageCount = pageCount;
        }
    }
}