using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Group { get; set; }
        public List<Book> Books { get; set; }
    }
}
