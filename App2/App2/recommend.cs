using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    [Table("recommend")]
    public class recommend
    {
        [PrimaryKey, AutoIncrement, Column("recom_id")]
        public int recom_id { get; set; }

        public string name_place { get; set; }
        public string address { get; set; }
        public string working_hours { get; set; }
    }
}
