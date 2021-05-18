using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS
{
    class Cart_Book
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string bookName { get; set; }
        public string bookAuthor { get; set; }
        public string ISBN { get; set; }
        public string year { get; set; }
        public string pages { get; set; }
        public string language { get; set; }
        public string rating { get; set; }
        public string genre { get; set; }
        public string available { get; set; }
    }
}
