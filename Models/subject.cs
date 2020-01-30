
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PrivateLessons.Models
{
   public partial class subject
{
   [Display(Name = "ID")]
 public int id { get; set; }
[StringLength(60, MinimumLength = 5)]
[Display(Name = "Name")]
 public string name { get; set; }

 [DataType(DataType.Date)]
 [Display(Name = "Start Date")]
  public System.DateTime date { get; set; }
  [Display(Name = "Time")]
  public string time {get; set;}

[Display(Name = "Price")]
[DataType(DataType.Currency)]
 public  double price { get; set; }
 
 [Display(Name = "Place")]
 public string place { get; set; }
 /* 
 //subject can have many students (list of students)
 public ICollection <student_subject_registration> students{ get; set; }
public ICollection <teachers> teachers{get;set;}

public ICollection <book> book{get; set;}
public ICollection <exam> exam{get; set;}
*/




}}