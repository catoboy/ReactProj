using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VYFAQ.Model
{
    public class QA
    {
        [Key]
        public int ID { get; set; }
        public String question { get; set; }
        public String answer { get; set; }
        public String time { get; set; }
    }
}
