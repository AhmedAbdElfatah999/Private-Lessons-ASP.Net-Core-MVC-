using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PrivateLessons.Models
{
    public partial class users{

//id,username,password,f_name,l_name,email,type_id
[Key]
[Display(Name = "ID")]
public int id { get; set; }
[Required(ErrorMessage="user name is Too Short"),MinLength(5),MaxLength(25),DataType(DataType.Text)]
[Display(Name = "User Name")]
[StringLength(60, MinimumLength = 3)]
public string username { get; set; }

[Required(ErrorMessage="This Password is Too Short"),MinLength(10),MaxLength(25),DataType(DataType.Password)]
[Display(Name = "Password")]
public string password { get; set; }
[Required]
[Display(Name = "First Name")]
public string f_name { get; set; }
[Required]
[Display(Name = "Last Name")]
public string l_name { get; set; }

[DataType(DataType.EmailAddress)]
[Display(Name = "Email")]
public string email { get; set; }
[Display(Name = "Type ID")]
[Range(1, 3)]
public int type_id { get; set; }











    }


}