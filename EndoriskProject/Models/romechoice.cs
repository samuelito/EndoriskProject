using System;
using System.Collections.Generic;

namespace EndoriskProject.Models
{
    public partial class romechoice
    {
        public long idRomeChoices { get; set; }
        public string romeChoice1 { get; set; }
        public string romeOption { get; set; }
        public Nullable<int> value { get; set; }
    }
}
