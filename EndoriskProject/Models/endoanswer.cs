using System;
using System.Collections.Generic;

namespace EndoriskProject.Models
{
    public partial class endoanswer
    {
        public int idQuiz { get; set; }
        public int idQuestion { get; set; }
        public string answer { get; set; }
    }
}
