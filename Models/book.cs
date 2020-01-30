using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PrivateLessons.Models
{
    public partial class book{
        [Display(Name = "ID")]
    public int id { get; set; }
[Display(Name = "Name")]
    public string name { get; set; }
    [Display(Name = "Subject ID")]
        public int subject_id { get; set; }

//public subject subject{get; set;}


        
    }}