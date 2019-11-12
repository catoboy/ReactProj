using System;
using System.ComponentModel.DataAnnotations;

namespace VYFAQ.Model
{
    public class innQA
    {
        [Key]
        public int ID { get; set; }
        public String question { get; set; }
        public String time { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String email { get; set; }
    }
}