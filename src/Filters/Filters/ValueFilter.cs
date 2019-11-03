using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filters.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters
{
    public class ValueFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.Result is ObjectResult)
            {
                var result = (ObjectResult) context.Result;
                var students = (IEnumerable<Student>) result.Value;
                var students2 = result.Value as IEnumerable<Student>;
                result.Value = students.Where(s => s.Age < 30);
            }

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //
        }
    }
}
