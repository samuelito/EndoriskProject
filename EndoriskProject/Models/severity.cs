using System;
using System.Collections.Generic;

namespace EndoriskProject.Models
{
    public partial class severity
    {
        public int idSeverity { get; set; }
        public Nullable<int> idQuiz { get; set; }
        public string severity1 { get; set; }
    }
}
