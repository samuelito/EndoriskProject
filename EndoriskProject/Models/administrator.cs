using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace EndoriskProject.Models
{
    public partial class administrator
    {
        public long idAdmin { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public long subadmin { get; set; }
    }
}
