using System;
using System.Collections.Generic;

namespace EndoriskProject.Models
{
    public partial class disease
    {
        public int idDiseases { get; set; }
        public string disease1 { get; set; }
        public Nullable<int> idRomeQuestion { get; set; }
        public string criteria { get; set; }
        public string comparedValue { get; set; }
    }
}
