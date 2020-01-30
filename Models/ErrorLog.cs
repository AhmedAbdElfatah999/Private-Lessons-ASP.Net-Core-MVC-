//this class is made for log any error ecoured in the Web app

using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//namespace for action filter attribute class
using Microsoft.AspNetCore.Mvc.Filters;
namespace PrivateLessons.Models
{
    public class ErrorLog :ActionFilterAttribute
    {
        public override void  OnActionExecuted(ActionExecutedContext context)
             {


             if(context.Exception !=null)
                 {
                   //log in file 
                 File.AppendAllText("~/LogErr.txt",context.Exception.ToString());
                 }

             }
        
    }
}