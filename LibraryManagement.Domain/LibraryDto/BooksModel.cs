﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.LibraryDto
{
    public class BooksModel
    {
        public int Book_id { get; set; }
        public string? Author { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public int CopiesAvailable { get; set; }
    }

}
