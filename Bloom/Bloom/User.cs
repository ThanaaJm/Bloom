using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bloom
{
    public class User
    {
        [PrimaryKey]
        public int id { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public string email { get; set; }


    }
}