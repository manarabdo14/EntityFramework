﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
