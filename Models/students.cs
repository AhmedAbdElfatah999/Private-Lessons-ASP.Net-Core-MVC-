
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateLessons.Models
{
    public class students
    {
        [Key]
        public int code { get; set; }
        public int user_id { get; set; }
        //student can register to more than one subject
       // public ICollection <student_subject_registration> subject { get; set; }
    }
}