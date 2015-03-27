using System;
using System.Collections.Generic;

namespace EndoriskProject.Models
{
    public partial class endoquestion
    {
        public long idQuestion { get; set; }
        public string endoQuestion1 { get; set; }
        public string abbr { get; set; }
        public string choiceSet { get; set; }
    }
}
